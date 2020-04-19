using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;
using SpaceInvaders.Properties;
using Timer = System.Timers.Timer;

namespace SpaceInvaders
{
    class Game : IDisposable
    {
        public Form1 Form { get; }


        /// Sæt antal start liv.

        public int Life { get; private set; } = 5;


       
        public int Level
        {
            get => lvl;
            private set
            {
                PutTextIntoControl(value, Form.actualLevelLabel);
                lvl = value;
            }
        }
        private int lvl = 0;



        
        public int Score
        {
            get => score;
            private set
            {
                PutTextIntoControl(value, Form.actualScoreLabel);
                score = value;
            }
        }
        private int score = 0;



        
        private List<PointF> tankMissiles = new List<PointF>();

        
        private List<PointF> explosions = new List<PointF>();

        
        private List<PointF> explosionsSafe = new List<PointF>();

        
        private List<PointF> invadersMissiles = new List<PointF>();

        
        private List<PointF> invadersMissilesSafe = new List<PointF>();

        
        private List<Invader> invaders = new List<Invader>();

        
        private List<Barrier> barriers = new List<Barrier>();

       
        private List<RectangleF> bottomLine = new List<RectangleF>();

        
        private PointF? mysteryLocation = null;

        
        private PointF? mysteryExplosion;

       
        private PointF tankLocation;

        
        private Timer mysteryExplosionTimer = new Timer();

       
        private Timer drawingTimer;

        
        private Timer mysteryShouldAppearTimer;

        
        private Timer invadersShouldMoveTimer;

        
        private Timer explosionsTimer = new Timer();

        
        private Timer invadersShouldShootTimer = new Timer();

        
        private Timer tankExplosionTimer = new Timer(800);

        
        private Timer immunityTimer = new Timer(3000);

        
        private Timer tankCanShootTimer = new Timer();

        
        private bool canTankShoot = true;

        
        private bool keyLArrow = false;

        
        private bool keyRArrow = false;

        
        private bool keySpace = false;

        
        private bool invadersMovingRight = true;

        
        private bool lckMovement = false;

        
        private bool lockingToken = false;

        
        private bool shouldDrawTank = true;

        
        private bool immunity = false;

        
        private bool forcePause = false;

        
        private bool paused = false;

        
        private bool endGame = false;

        
        private bool enableExtraSpeed = false;

        
        private bool enemyShootingDisabled = false;

        
        private bool barrierDestroyedPlayed = false;

        
        private int mysterySpeed;

        
        private int movementAccelerationMs = 50;

        
        private int greenLineY;

        
        private double shootingPrecision = 0.3;

        
        private double invadersShouldMoveOriginalInterval;

        
        private float bottomInvaderY = -1;

        
        private float barrierY;

        
        private static float splashRadius;

        
        private Stopwatch immunityStopwatch = new Stopwatch();

        
        private Random random = new Random();
        public Game(Form1 f)
        {
            Form = f;

            
            drawingTimer = new Timer(15) { Enabled = true };
            drawingTimer.Elapsed += drawingTimer_Elapsed;

            
            Form.KeyPreview = true;

            
            Form.Paint += Form_Paint;
            Form.Resize += Form_Resize;
            Form.KeyDown += FormOnKeyDown;
            Form.KeyUp += FormOnKeyUp;
            Form.Deactivate += FormOnDeactivate;

            
            greenLineY = Form.Height - Constants.GreenLineYShift;
            barrierY = 0.65f * Form.Height;

            
            GenerateBarrier();

            CreateBottomLine();

            tankLocation = new PointF(Form.Width / 2f - Resources.tank.Width / 2f, Form.Height - Constants.TankBottomYShift);

            
            splashRadius = 0.01058f * (Form.Width + Form.Height);

            
            mysteryShouldAppearTimer = new Timer(random.Next(Constants.MysteryShouldAppearRange.Item1, Constants.MysteryShouldAppearRange.Item2)) { Enabled = true };
            mysteryShouldAppearTimer.Elapsed += MysteryShouldAppearTimerOnElapsed;


            
            tankCanShootTimer.Elapsed += TankCanShootTimerOnElapsed;

            immunityTimer.Elapsed += ImmunityTimerOnElapsed;

            explosionsTimer.Elapsed += ExplosionsTimerOnElapsed;
            mysteryExplosionTimer.Elapsed += MysteryExplosionTimer_Elapsed;

            invadersShouldMoveTimer = new Timer(Constants.SlowestMovingFrequencyMs) { Enabled = false };
            invadersShouldMoveTimer.Elapsed += InvadersShouldMoveTimerElapsed;

            tankExplosionTimer.Elapsed += TankExplosionTimerElapsed;
            invadersShouldShootTimer.Elapsed += InvadersShouldShootTimerOnElapsed;

            
            NextLevel();


        }

        
        private void FormOnDeactivate(object sender, EventArgs e)
        {
            if (!endGame)
            {
                paused = true;
                PauseGameWMsg();
            }
        }

        
        private void GenerateBarrier()
        {
            barrierDestroyedPlayed = false;
            int w = (int)(0.2 * Form.Width);
            int h = (int)(0.1 * Form.Height);
            float stopMovingTopX = (1 / 6f) * w;
            float barrierY = 0.7f * Form.Height;
            for (int i = 0; i < 3; i++)
            {
                Barrier b = new Barrier();
                if (i == 0)
                    CreateBarrier(new PointF(Form.Width * 0.11f, barrierY), stopMovingTopX, h, 1, ref b);

                if (i == 1)
                    CreateBarrier(new PointF(Form.Width * 0.4f, barrierY), stopMovingTopX, h, 1, ref b);

                if (i == 2)
                    CreateBarrier(new PointF(Form.Width * 0.7f, barrierY), stopMovingTopX, h, 1, ref b);

                barriers.Add(b);
            }
        }

        
        private void PutTextIntoControl(int value, Label l)
        {
            if (l.InvokeRequired)
                l.Invoke(new Action(() => l.Text = value.ToString()));
            else
                l.Text = value.ToString();
        }

        
        private void InvadersShouldMoveTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (invaders.Count == 0) return;

            drawingTimer.Stop();      
            drawingTimer.Enabled = false;
            if (invadersMovingRight)
            {
                Invader right = RightInvader();
                if (right.Location.X + 2 * right.Width + Constants.InvaderMovingLength < Form.Width)
                {
                    invaders.ForEach(x => x.MoveRight());

                }
                if (right.Location.X + 2 * right.Width + Constants.InvaderMovingLength > Form.Width)
                {
                    if (!lckMovement)
                    {
                        PrepareForMovingDown();
                        return;
                    }

                    invadersShouldMoveTimer.Interval = invadersShouldMoveOriginalInterval;
                    MovingDown();
                    lckMovement = false;
                }
            }
            else
            {
                Invader left = LeftInvader();
                if (left.Location.X - Constants.InvaderMovingLength > 0)
                    invaders.ForEach(x => x.MoveLeft());

                if (left.Location.X - Constants.InvaderMovingLength < 0)
                {
                    if (!lckMovement)
                    {
                        PrepareForMovingDown();
                        return;
                    }

                    invadersShouldMoveTimer.Interval = invadersShouldMoveOriginalInterval;
                    MovingDown();
                    lckMovement = false;
                }
            }
            drawingTimer.Enabled = true;
        }

        
        private void PrepareForMovingDown()
        {
            invadersShouldMoveOriginalInterval = invadersShouldMoveTimer.Interval;
            invadersShouldMoveTimer.Interval = 500;
            lckMovement = true;
            drawingTimer.Enabled = true;
        }

        
        private void MovingDown()
        {
            invadersMovingRight = !invadersMovingRight;
            invaders.ForEach(x => x.MoveDown(Level));
            if (!enableExtraSpeed)
            {
                double newInterval = invadersShouldMoveTimer.Interval - movementAccelerationMs * (0.7 + Level * 0.3);
                invadersShouldMoveTimer.Interval = Math.Max(newInterval, 100);
                movementAccelerationMs = (int)(movementAccelerationMs * 1.15f);
                if (invadersShouldShootTimer.Interval > 420)
                    invadersShouldShootTimer.Interval -= 30;
            }
            UpdateBottomInvader();
        }

        
        private Invader RightInvader()
        {
            Invader f = invaders[0];
            for (int i = 1; i < invaders.Count; i++)
            {
                if (invaders[i].Location.X > f.Location.X)
                {
                    f = invaders[i];
                }
            }

            return f;
        }


        
        private Invader LeftInvader()
        {
            Invader f = invaders[0];
            for (int i = 1; i < invaders.Count; i++)
            {
                if (invaders[i].Location.X < f.Location.X)
                    f = invaders[i];

            }

            return f;
        }

        
        private void FormOnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                keyLArrow = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                keyRArrow = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                keySpace = false;
            }
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        
        private void TankCanShootTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            canTankShoot = true;
            tankCanShootTimer.Enabled = false;
        }

        
        private void MysteryShouldAppearTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            Utils.Play(Resources.ufo_lowpitch);
            mysteryLocation = new PointF(Form.Width - mysterySpeed, Constants.MysteryYLocation);
            Timer s = (Timer)sender;
            mysterySpeed = random.Next(Constants.MysterySpeedRange.Item1, Constants.MysterySpeedRange.Item2);
            s.Interval = random.Next(Constants.MysteryShouldAppearRange.Item1, Constants.MysteryShouldAppearRange.Item2);
        }

        
        private void FormOnKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
                keyLArrow = true;



            if (e.KeyCode == Keys.Right)
                keyRArrow = true;


            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.X)
                keySpace = true;

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        
        private void Form_Resize(object sender, EventArgs e)
        {
            if (Form.WindowState == FormWindowState.Minimized)
                PauseGameWMsg();

        }

        
        private void CreateBottomLine()
        {
            bottomLine.Clear();
            for (int i = 0; i < Form.Width; i += Constants.GreenBottomLineRectangleSize.Item1)
            {
                RectangleF rect = new RectangleF(i, greenLineY, Constants.GreenBottomLineRectangleSize.Item1, Constants.GreenBottomLineRectangleSize.Item2);
                bottomLine.Add(rect);
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;

            
            e.Graphics.FillRectangles(Brushes.LawnGreen, bottomLine.ToArray());

            
            e.Graphics.DrawString(Life.ToString(), new Font(Utils.SpaceInvadersFamily, 28), Brushes.White, 10, Form.Height - 85);

            for (int i = 80; i <= 50 * Life; i += 50)
                e.Graphics.DrawImage(Resources.tank, new PointF(i, Form.Height - 80));

            
            if (shouldDrawTank)
            {
                if (immunity)
                {
                    e.Graphics.DrawImage(Resources.immune_tank, tankLocation);
                }
                else
                    e.Graphics.DrawImage(Resources.tank, tankLocation);
            }
            else
            {
                e.Graphics.DrawImage(Resources.tank_destroyed, tankLocation);
            }

            
            if (mysteryLocation.HasValue)
                e.Graphics.DrawImage(Resources.mystery, mysteryLocation.Value);

            
            for (int i = 0; i < tankMissiles.Count; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.LawnGreen, 3f), tankMissiles[i].X, tankMissiles[i].Y - Constants.TankMissileLength, tankMissiles[i].X, tankMissiles[i].Y);
            }

            
            for (int i = 0; i < invadersMissilesSafe.Count; i++)
                e.Graphics.DrawImage(Resources.lightning, invadersMissilesSafe[i]);
            


            
            if (mysteryExplosion != null)
                e.Graphics.DrawImage(Resources.mystery_boom, mysteryExplosion.Value);
            

            
            for (int i = 0; i < explosionsSafe.Count; i++)
                e.Graphics.DrawImage(Resources.boom, explosionsSafe[i]); 



            
            foreach (var invader in invaders)
            {
                e.Graphics.DrawInvader(invader);
            }

            
            foreach (Barrier b in barriers)
                e.Graphics.FillRectangles(Brushes.LawnGreen, b.Columns.SelectMany(x => x.Rectangles).ToArray());
        }

        
        private void CreateBarrier(PointF origin, float w, float h, int partN, ref Barrier b)
        {
            PointF startPt = origin;
            do
            {
                Column c = new Column();
                PointF movingY = startPt;
                do
                {
                    c.Rectangles.Add(new RectangleF(movingY.X, movingY.Y, Constants.BarrierSquareSize, Constants.BarrierSquareSize));

                    if (movingY.Y < b.TopY)
                        b.TopY = movingY.Y;

                    movingY = PointF.Add(movingY, new Size(0, Constants.BarrierSquareSize));

                } while (movingY.Y < origin.Y + h);

                if (partN == 2)
                    h -= Constants.BarrierSquareSize;
                else if (partN == 4)
                    h += Constants.BarrierSquareSize;

                if (partN == 1)
                    startPt = PointF.Add(startPt, new Size(Constants.BarrierSquareSize, -Constants.BarrierSquareSize));

                else if (partN == 5)
                    startPt = PointF.Add(startPt, new Size(Constants.BarrierSquareSize, Constants.BarrierSquareSize));

                else if (partN == 2 || partN == 4 || partN == 3)
                    startPt = PointF.Add(startPt, new Size(Constants.BarrierSquareSize, 0));


                b.Columns.Add(c);

            } while (startPt.X < origin.X + w);


            if (partN < 5)
            {
                partN++;
                if (partN == 2)
                    CreateBarrier(startPt, w, h, partN, ref b);
                if (partN == 3)
                    CreateBarrier(startPt, 2f * w, h, partN, ref b);
                if (partN == 4)
                    CreateBarrier(startPt, 0.6f * w, h, partN, ref b);
                if (partN == 5)
                    CreateBarrier(startPt, w, b.Columns.First().Rectangles.Last().Y - origin.Y, partN, ref b);
            }
        }

        
        private void drawingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (lockingToken)
                return;
            lockingToken = true;

            
            if (Form.InvokeRequired)
                Form.Invoke(new Action(() =>
                {
                    Form.Refresh();
                }));
            
            if (mysteryLocation.HasValue)
            {
                
                RectangleF m = new RectangleF(mysteryLocation.Value.X, mysteryLocation.Value.Y, Resources.mystery.Width, Resources.mystery.Height);
                foreach (var shoot in tankMissiles)
                {
                    PointF topOfMissle = Utils.TopOfTankMissile(shoot);
                    if (Utils.IsPointInRect(topOfMissle, m))
                    {
                        Utils.Play(Resources.ufo_highpitch);
                        tankMissiles.Remove(shoot);
                        mysteryExplosion = mysteryLocation;
                        mysteryLocation = null;
                        ShowMysteryExplosion();
                        break;
                    }
                }

                
                if (mysteryLocation != null)
                    if (mysteryLocation.Value.X + Resources.mystery.Width < 0)
                    {
                        mysteryLocation = null;
                    }

                
                if (mysteryLocation != null)
                    mysteryLocation = new PointF(mysteryLocation.Value.X - mysterySpeed, mysteryLocation.Value.Y);
            }

            
            if (keyLArrow && tankLocation.X > 0 && shouldDrawTank)
                tankLocation.X -= Constants.TankMovingDistancePx;


            if (keyRArrow && tankLocation.X + Resources.tank.Width + 12 < Form.Width && shouldDrawTank)
                tankLocation.X += Constants.TankMovingDistancePx;

            
            if (canTankShoot && keySpace)
            {
                canTankShoot = false;
                tankCanShootTimer.Enabled = true;
                tankCanShootTimer.Interval = Constants.TankShotTimeoutMs;
                tankMissiles.Add(new PointF(tankLocation.X + Resources.tank.Width / 2f, tankLocation.Y - 2));
                Utils.Play(Resources.shoot);
            }
            invadersMissilesSafe = invadersMissiles.ToList();
            explosionsSafe = explosions.ToList();

            
            for (int i = invaders.Count - 1; i >= 0; i--)
            {
                Invader curr = invaders[i];
                RectangleF currInvader = new RectangleF(invaders[i].Location.X, invaders[i].Location.Y, invaders[i].Width, invaders[i].Height);
                for (int j = tankMissiles.Count - 1; j >= 0; j--)
                {
                    PointF tS = tankMissiles[j];
                    if (Utils.IsPointInRect(Utils.TopOfTankMissile(tankMissiles[j]), currInvader))
                    {
                        
                        Score += curr.ScoreGain;
                        ShowNormalExplosion(new PointF(currInvader.X, currInvader.Y));
                        tankMissiles.RemoveAll(x => x == tS);

                        invaders.Remove(curr);
                        --i;
                        Utils.Play(Resources.invaderkilled);
                        if (i < 0) break;
                        SmallShootingSpeedIncrease();

                        if (Math.Abs(currInvader.Y - bottomInvaderY) < 0.1)
                            UpdateBottomInvader();
                    }
                }
            }

            
            for (int i = invadersMissiles.Count - 1; i >= 0; --i)
            {
                PointF bottom = Utils.BottomOfInvaderMissile(invadersMissiles[i]);

                
                if (Math.Abs(bottom.Y - greenLineY) < 5)
                {
                    for (int j = bottomLine.Count - 1; j >= 0; j--)
                    {
                        if (bottom.X > bottomLine[j].X && bottom.X < bottomLine[j].Right)
                            bottomLine.RemoveAt(j);

                    }
                }
                 
                if (!immunity)
                { 
                    RectangleF invaderMissile = new RectangleF(invadersMissiles[i].X, invadersMissiles[i].Y, Resources.lightning.Width, Resources.lightning.Height);
                    RectangleF tank = new RectangleF(tankLocation.X, tankLocation.Y, Resources.tank.Width, Resources.tank.Height);
                    if (invaderMissile.IntersectsWith(tank))
                    {
                        if (Life - 1 > 0)
                        {
                            immunity = true;
                            immunityStopwatch.Restart();
                        }

                        if (Life - 1 == 0) 
                        {
                            Life--;
                            End();
                        }
                        else 
                        {
                            Life--;
                            ShowTankExplosion();
                        }

                        invadersMissiles.RemoveAt(i); 
                        i--;
                        if (i < 0)
                            break;
                    }
                }

                
                for (int j = tankMissiles.Count - 1; j >= 0 && i >= 0; j--)
                {
                    PointF top = Utils.TopOfTankMissile(tankMissiles[j]);
                    if (top.X >= bottom.X && top.X <= bottom.X + Resources.lightning.Width)
                    {
                        if (top.Y - bottom.Y < 11)
                        {
                            tankMissiles.RemoveAt(j); 
                            invadersMissiles.RemoveAt(i);
                            i--;
                            if (i < 0)
                                break;

                        }
                    }
                }

                
                for (int j = 0; j < barriers.Count && i >= 0; j++)
                {
                                                                             
                    if (CollisionWithBarrier(invadersMissiles[i], barriers[j], out var cIdx, true))
                    {
                        invadersMissiles.RemoveAt(i);
                        PointF topOfC = barriers[j].Columns[cIdx].Rectangles.First().Location;
                        SplashDamage(topOfC, barriers[j], cIdx, true);
                        i--;
                        if (i < 0)
                            break;

                    }
                }
            }


           
            for (int j = 0; j < barriers.Count; ++j)
            {
                for (int i = tankMissiles.Count - 1; i >= 0; i--)
                {
                    if (CollisionWithBarrier(tankMissiles[i], barriers[j], out var columnIdx, false))
                    {
                        tankMissiles.RemoveAt(i);
                        PointF bottomOfC = barriers[j].Columns[columnIdx].Rectangles.Last().Location;
                        SplashDamage(bottomOfC, barriers[j], columnIdx, false);

                    }
                }
            }



            
            for (int i = tankMissiles.Count - 1; i >= 0; i--)
            {
                if (tankMissiles[i].Y < 0)
                    tankMissiles.RemoveAt(i);

            }

            for (int i = invadersMissiles.Count - 1; i >= 0; i--)
            {
                if (invadersMissiles[i].Y > Form.Height)
                    invadersMissiles.RemoveAt(i);

            }

            
            if (invaders.Count == 1 && !enableExtraSpeed)
            {
                enableExtraSpeed = true;
                invadersShouldShootTimer.Interval = 350;
                invadersShouldMoveTimer.Interval = 100;
            }

            
            if (invaders.Count == 0)
            {
                NextLevel();
            }
            
           
            for (int i = 0; i < tankMissiles.Count; i++)
                tankMissiles[i] = new PointF(tankMissiles[i].X, tankMissiles[i].Y - Constants.MissilesMovingDistance);

            
            for (int i = 0; i < invadersMissiles.Count; i++)
                invadersMissiles[i] = new PointF(invadersMissiles[i].X, invadersMissiles[i].Y + Constants.MissilesMovingDistance);

            
            if (!barriers.Any() && !barrierDestroyedPlayed)
            {
                Utils.Play(Resources.barrier_destroyed);
                barrierDestroyedPlayed = true;
            }

            
            if (bottomInvaderY + Constants.MaxInvaderHeight >= barrierY && barriers.Any())
            {
                barriers.Clear();
                Utils.Play(Resources.barrier_destroyed);
                barrierDestroyedPlayed = true;
            }

            
            if (bottomInvaderY + Constants.MaxInvaderHeight >= tankLocation.Y)
                End();

            lockingToken = false;
        }

        
        private void SmallShootingSpeedIncrease()
        {
            if (invadersShouldShootTimer.Interval - 10 < 420)
                invadersShouldShootTimer.Interval = 420;
            else invadersShouldShootTimer.Interval -= 5;
        }

        
        private void DisableAllTimers()
        {
            foreach (FieldInfo fieldInfo in GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (fieldInfo.FieldType == typeof(Timer))
                {
                    Timer t = (Timer)fieldInfo.GetValue(this);
                    t.Stop();
                    t.Enabled = false;
                }
            }
        }

       
        public void End()
        {
            endGame = true;
            DisableAllTimers();
            Form.Invoke(new Action(() => Form.Refresh()));
            Form.Invoke(new Action(() => Form.ShowGameOver()));
            Dispose();
        }

        
        private bool CollisionWithBarrier(PointF missile, Barrier barrier, out int columnIdx, bool fromInvader)
        {
            columnIdx = -1;
            PointF btm;
            btm = fromInvader ? Utils.BottomOfInvaderMissile(missile) : Utils.TopOfTankMissile(missile);
            PointF f;
            PointF l;
            if (fromInvader)
            {
                f = barrier.Columns.First().Rectangles.First().Location;
                l = barrier.Columns.Last().Rectangles.First().Location;
            }
            else
            {
                f = barrier.Columns.First().Rectangles.Last().Location;
                l = barrier.Columns.Last().Rectangles.Last().Location;
            }

            if (btm.X >= f.X - Constants.MissilesMovingDistance && btm.X <= l.X + Constants.MissilesMovingDistance)
            {
                for (int i = 0; i < barrier.Columns.Count; i++)
                {
                    float cmp;
                    cmp = fromInvader ? barrier.Columns[i].Rectangles.First().X : barrier.Columns[i].Rectangles.Last().X;
                    if (barrier.Columns[i].Rectangles.Any() &&
                        Math.Abs(btm.X - cmp) < Constants.MissilesMovingDistance)
                    {
                        PointF topOfC;
                        topOfC = fromInvader ? barrier.Columns[i].Rectangles.First().Location : barrier.Columns[i].Rectangles.Last().Location;

                        if (Math.Abs(topOfC.Y - btm.Y) < Constants.MissilesMovingDistance)
                        {
                            columnIdx = i;
                            return true;
                        }
                    }

                }
            }

            return false;

        }
        
        private void SplashDamage(PointF impactPoint, Barrier barrier, int columnIdx, bool fromInvader)
        {
            double m;
            int j = columnIdx;
            bool second = false;
            do
            {
                if (second)
                    j = columnIdx - 1;

                PointF cmp;
                if (fromInvader)
                    cmp = barrier.Columns[j].Rectangles.First().Location;
                else
                    cmp = barrier.Columns[j].Rectangles.Last().Location;

                while (j >= 0 && j < barrier.Columns.Count && barrier.Columns[j].Rectangles.Any() && Utils.Distance(cmp,
                           impactPoint) < splashRadius)
                {
                    m = j == columnIdx ? 1.0 : 0.7;
                    int k; 
                    if (fromInvader)
                        k = 0;
                    else k = barrier.Columns[j].Rectangles.Count - 1;
                    while (j >= 0 && k >= 0 && k < barrier.Columns[j].Rectangles.Count && Utils.Distance(
                               barrier.Columns[j].Rectangles[k].Location, impactPoint) <
                           splashRadius)
                    {
                        if (random.NextDouble() <= m)
                        {
                            barrier.Columns[j].Rectangles.RemoveAt(k);
                            if (barrier.Columns[j].Rectangles.Count == 0)
                            {
                                barrier.Columns.RemoveAt(j);
                                if (barrier.Columns.Count == 0)
                                {
                                    barriers.Remove(barrier);
                                }
                                if (columnIdx > j)
                                    columnIdx--;
                                j--;
                            }
                            if (fromInvader)
                                k--;
                        }

                        if (fromInvader)
                            k++;
                        else k--;
                    }

                    if (!second)
                        j++; 
                    else j--;
                }

                second = !second && (columnIdx != 0) && (columnIdx != barrier.Columns.Count - 1);
            } while (second);


        }

        
        private void TankExplosionTimerElapsed(object sender, ElapsedEventArgs e)
        {
            tankExplosionTimer.Enabled = false;
            tankLocation.X = random.Next((int)(Form.Width * 0.1), (int)(Form.Width * 0.9));
            shouldDrawTank = true;
            tankCanShootTimer.Enabled = true;
            canTankShoot = true;
            ResumeGame();
            immunityTimer.Interval = Constants.ImmunityLengthMs;
            immunityTimer.Enabled = true;

        }

        
        private void ImmunityTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            immunityTimer.Enabled = false;
            immunity = false;
        }

        
        private void ShowTankExplosion()
        {
            PauseWOMsg();
            tankExplosionTimer.Enabled = true;
            shouldDrawTank = false;
            canTankShoot = false;
            tankCanShootTimer.Enabled = false;

            Form.Invoke(new Action(() => Form.Refresh()));
            Utils.Play(Resources.tank_explosion);

        }


        
        private void NextLevel()
        {
            invadersMissiles.Clear();
            invadersMovingRight = true;
            enableExtraSpeed = false;
            drawingTimer.Enabled = false;
            invadersShouldMoveTimer.Enabled = false;
            Level++;
            invadersShouldMoveTimer.Interval = Constants.SlowestMovingFrequencyMs;
            movementAccelerationMs = 30 + Level * 20;
            GenerateInvadersForLevel();
            invadersShouldShootTimer.Enabled = true;
            invadersShouldShootTimer.Interval = Constants.InvadersSlowestShootingSpeedMs;
            drawingTimer.Enabled = true;
            invadersShouldMoveTimer.Enabled = true;
            UpdateBottomInvader();
        }


       
        private void InvadersShouldShootTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            int numberOfShooters = Math.Min(random.Next(1, 3), invaders.Count);
            List<Invader> nClosest = NClosestInvaders(numberOfShooters);
            List<Invader> shooters = new List<Invader>();
            while (shooters.Count < numberOfShooters)
            {
                if (random.NextDouble() < shootingPrecision) //aim for tank
                {
                    shooters.Add(nClosest.First());
                    nClosest.RemoveAt(0);
                }
                else //random
                {
                    int idx = random.Next(0, invaders.Count - 1);
                    shooters.Add(invaders[idx]);
                }
            }
            shooters.ForEach(x => MakeInvaderShootMissile(x));
        }

        
        private List<Invader> NClosestInvaders(int n)
        {
            var cpy = invaders.ToArray().ToList();
            cpy.Sort(InvaderComparator);
            return cpy.Take(n).ToList();
        }

        
        private int InvaderComparator(Invader i1, Invader i2)
        {
            float diff1 = Math.Abs(tankLocation.X - i1.Location.X);
            float diff2 = Math.Abs(tankLocation.X - i2.Location.X);

            if (diff1 < diff2)
                return -1;
            if (diff1 > diff2)
                return 1;

            return 0;
        }

        
        private void MakeInvaderShootMissile(Invader invader)
        {
            PointF toAdd = PointF.Add(invader.Location, new Size(10, invader.Height));
            invadersMissiles.Add(toAdd);
        }

        
        private void GenerateInvadersForLevel()
        {
            int b = Math.Min((int)(Form.Height * Constants.InvadersPositionCoeff * Level), 380);

            for (float x = 40; x < 0.6f * Form.Width; x += Constants.InvadersDistanceCoeff * Resources.bottom1.Width)
            {
                invaders.Add(new TopInvader(new PointF(x - Resources.top1.Width / 2f, b)));
                invaders.Add(new MiddleInvader(new PointF(x - Resources.middle1.Width / 2f, b + Constants.InvadersDistanceCoeff * Resources.bottom1.Height)));
                invaders.Add(new MiddleInvader(new PointF(x - Resources.middle1.Width / 2f, b + 2 * Constants.InvadersDistanceCoeff * Resources.bottom1.Height)));
                invaders.Add(new BottomInvader(new PointF(x - Resources.bottom1.Width / 2f, b + 3 * Constants.InvadersDistanceCoeff * Resources.bottom1.Height)));
            }
            UpdateBottomInvader();
        }

        
        private void UpdateBottomInvader()
        {
            foreach (Invader invader in invaders)
            {
                if (invader.Location.Y > bottomInvaderY)
                    bottomInvaderY = invader.Location.Y;

            }
        }

        
        private void ShowNormalExplosion(PointF invaderLocation)
        {
            explosions.Add(invaderLocation);
            explosionsTimer.Enabled = true;
            explosionsTimer.Interval = Constants.ExplosionInterval;

        }

       
        private void ExplosionsTimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            drawingTimer.Stop();
            drawingTimer.Enabled = false;
            explosions.RemoveAt(0);
            explosionsTimer.Enabled = explosions.Any();
            drawingTimer.Enabled = mysteryShouldAppearTimer.Enabled;
        }

        
        private void ShowMysteryExplosion()
        {
            mysteryExplosionTimer.Enabled = true;
            mysteryExplosionTimer.Interval = Constants.ExplosionInterval;
        }

        
        private void MysteryExplosionTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            mysteryExplosion = null;
            mysteryExplosionTimer.Enabled = false;
            Score += (mysterySpeed - 2) * random.Next(20, 30);
        }

        
        public void Dispose()
        {
            drawingTimer?.Dispose();
            mysteryShouldAppearTimer?.Dispose();
            invadersShouldMoveTimer?.Dispose();
            mysteryExplosionTimer?.Dispose();
            tankCanShootTimer?.Dispose();
            explosionsTimer?.Dispose();
            invadersShouldShootTimer.Dispose();
            Form.Paint -= Form_Paint;
            Form.Resize -= Form_Resize;
            Form.KeyDown -= FormOnKeyDown;
            Form.KeyUp -= FormOnKeyUp;
        }

        
        public void CheatKey(Keys keyData)
        {
            if (keyData == Keys.H) 
            {
                Life++;
            }
            else if (keyData == Keys.S) 
            {
                Score += 100;
            }
            else if (keyData == Keys.P) 
            {
                if (paused)
                {
                    ResumeGame();
                    paused = false;
                }
                else
                {
                    paused = true;
                    PauseGameWMsg();
                }
            }
            else if (keyData == Keys.M) 
            {
                enemyShootingDisabled = !enemyShootingDisabled;
                invadersShouldShootTimer.Enabled = !invadersShouldShootTimer.Enabled;
            }
            else if (keyData == Keys.B) 
            {
                barriers.Clear();
                GenerateBarrier();
            }
            else if (keyData == Keys.D) 
            {
                invaders.RemoveAt(random.Next(0, invaders.Count - 1));
                SmallShootingSpeedIncrease();
            }
        }

        
        private void PauseWOMsg()
        {
            drawingTimer.Enabled = false;
            mysteryShouldAppearTimer.Enabled = false;
            invadersShouldMoveTimer.Enabled = false;
            immunityTimer.Enabled = false;
            invadersShouldShootTimer.Enabled = false;
            tankCanShootTimer.Enabled = false;
        }

        
        private void PauseGameWMsg()
        {

            PauseWOMsg();
            Form.pauseLabel.Visible = true;
            forcePause = tankExplosionTimer.Enabled;
            tankExplosionTimer.Enabled = false;
            immunityStopwatch.Stop();
        }


        
        private void ResumeGame()
        {
            drawingTimer.Enabled = true;
            mysteryShouldAppearTimer.Enabled = true;
            invadersShouldMoveTimer.Enabled = true;
            tankCanShootTimer.Enabled = true;

            tankExplosionTimer.Enabled = !shouldDrawTank;

            if (immunity && paused)
            {
                if(immunityTimer.Interval - immunityStopwatch.ElapsedMilliseconds > 0)
                    immunityTimer.Interval -= immunityStopwatch.ElapsedMilliseconds; 

                immunityStopwatch.Restart();
            }

            immunityTimer.Enabled = immunity;


            invadersShouldShootTimer.Enabled = !enemyShootingDisabled;
            Form.pauseLabel.Invoke(new Action(() => Form.pauseLabel.Visible = false));
            forcePause = false;
        }
    }
}
