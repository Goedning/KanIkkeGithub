using System.Drawing;

namespace SpaceInvaders {
    public class Player {
        private bool isShoot; 
        private int xPos; //holder x positionen af spilleren
        private int yPos; //holder y positionen af spilleren
        private int lives;

        public Player() {
        }

        public bool IsFired() { // Tjekker om vi har et aktivt projektil
            return (isShoot);
        }

        public void Fire(bool fireState) { // Fyr et skud
            isShoot = fireState;
        }

        public int GetPos(char dim) { 
            if (dim == 'x')
                return (xPos);
            else
                return (yPos);
        }

        public void SetPos(Point pos) {  
            xPos = pos.X;
            yPos = pos.Y;
        }

        public int GetLives() {
            return (lives);
        }

        public void SetLives(int l) {
            lives = l;
        }

        public void LoseLife(){
            lives--;
        }
    }
}
