using System.Drawing;
using SpaceInvaders.Properties;

namespace SpaceInvaders
{
    public abstract class Invader
    {

        
        public virtual int ScoreGain { get; set; }

        
        public PointF Location { get; set; }

        
        public virtual Image Look1 { get; set; }

        
        public virtual Image Look2 { get; set; }

        
        public bool State { get; set; } = true;

        
        public virtual int Width { get; set; }

        
        public virtual int Height { get; set; }

        protected Invader(PointF location)
        {
            Location = location;
        }

        public Image ActiveLook()
        {
            if (State)
            {
                return Look1;
            }

            return Look2;
        }

        public void SwapState()
        {
            State = !State;
        }
        public void MoveLeft()
        {
            SwapState();
            Location = new PointF(Location.X - Constants.InvaderMovingLength, Location.Y);
        }

        public void MoveRight()
        {
            SwapState();
            Location = new PointF(Location.X + Constants.InvaderMovingLength, Location.Y);
        }

        public void MoveDown(int lvl)
        {
            SwapState();
            Location = new PointF(Location.X, Location.Y + (Resources.bottom1.Height + (int)(0.5 * lvl * Resources.bottom1.Height)));
        }
    }

    class TopInvader : Invader
    {
        public override int ScoreGain { get; set; } = 30;
        public override Image Look1 { get; set; } = Resources.top1;
        public override Image Look2 { get; set; } = Resources.top2;
        public override int Width { get; set; } = 26;
        public override int Height { get; set; } = 23;

        public TopInvader(PointF location) : base(location)
        {
        }
    }

    class MiddleInvader : Invader
    {
        public override int ScoreGain { get; set; } = 20;
        public override Image Look1 { get; set; } = Resources.middle1;
        public override Image Look2 { get; set; } = Resources.middle2;
        public override int Width { get; set; } = 36;
        public override int Height { get; set; } = 23;

        public MiddleInvader(PointF location) : base(location)
        {
        }
    }

    class BottomInvader : Invader
    {
        public override int ScoreGain { get; set; } = 10;
        public override Image Look1 { get; set; } = Resources.bottom1;
        public override Image Look2 { get; set; } = Resources.bottom2;
        public override int Width { get; set; } = 38;
        public override int Height { get; set; } = 22;

        public BottomInvader(PointF location) : base(location)
        {
        }
    }
}
