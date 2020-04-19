using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SpaceInvaders.Properties;

namespace SpaceInvaders
{
    class Utils
    {
        public static FontFamily SpaceInvadersFamily;

        
        public static void InitSpaceInvadersFont()
        {
            
            PrivateFontCollection pfc = new PrivateFontCollection();

            
            int fontLength = Properties.Resources.space_invaders.Length;

            
            byte[] fontdata = Properties.Resources.space_invaders;

            
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            
            Marshal.Copy(fontdata, 0, data, fontLength);

            
            pfc.AddMemoryFont(data, fontLength);

            SpaceInvadersFamily = pfc.Families[0];
        }
        public static void ChangeFontToSpaceInvaders(Control c)
        {
            if (SpaceInvadersFamily == null)
                InitSpaceInvadersFont();
            
            c.Font = new Font(SpaceInvadersFamily, c.Font.Size);
        }

        public static bool IsPointInRect(PointF p, RectangleF r)
        {
            if (p.X >= r.X && p.X <= r.Right)
            {
                if (p.Y >= r.Y && p.Y <= r.Bottom)
                {
                    return true;
                }
            }

            return false;
        }

        
        public static PointF TopOfTankMissile(PointF missile)
        {
            return new PointF(missile.X, missile.Y - Constants.TankMissileLength);
        }

        
        public static PointF BottomOfInvaderMissile(PointF missile)
        {
            return new PointF(missile.X, missile.Y + Resources.lightning.Height);
        }

        
        public static void Play(UnmanagedMemoryStream shoot)
        {
            SoundPlayer sp = new SoundPlayer(shoot);
            sp.Play();
        }

        
        public static float Distance(PointF pt1, PointF pt2)
        {
            return (float) Math.Sqrt(Math.Pow(pt1.X - pt2.X, 2) + Math.Pow(pt1.Y - pt2.Y, 2));
        }
    }
}
