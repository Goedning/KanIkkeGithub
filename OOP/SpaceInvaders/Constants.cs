using System;
using System.Drawing;

namespace SpaceInvaders
{
    class Constants
    {
        
        public static readonly int TankMissileLength = 20;

        
        public static readonly int InvaderMovingLength = 15;

        
        public static readonly int SlowestMovingFrequencyMs =  750;

        
        public static readonly int ExplosionInterval = 300;

        
        public static readonly int BarrierSquareSize = 5;

        
        public static readonly int MaxInvaderHeight = 23;

        
        public static readonly int InvadersSlowestShootingSpeedMs = 1000;

        
        public static readonly double InvadersPositionCoeff = 0.144444;

        
        public static readonly PointF ScoreTableLocation = new PointF(0.5f, 0.56f);

        
        public static readonly int ScoreTableLocationShift = 220;

        
        public static readonly int TankShotTimeoutMs = 1000;

       
        public static readonly int TankMovingDistancePx = 5;

      
        public static readonly int ImmunityLengthMs = 3000;

       
        public static readonly int MysteryYLocation = 80;
        
       
        public static readonly int TankBottomYShift = 127;

      
        public static readonly int GreenLineYShift = 100;

      
        public static readonly int MissilesMovingDistance = 10;

        
        public static readonly float InvadersDistanceCoeff = 1.3f;

        
        public static Tuple<int, int> MysteryShouldAppearRange = new Tuple<int, int>(10000, 20000);

        
        public static Tuple<int,int> MysterySpeedRange = new Tuple<int, int>(3, 10);

        
        public static Tuple<int,int> GreenBottomLineRectangleSize = new Tuple<int, int>(10,6);

    }
}
