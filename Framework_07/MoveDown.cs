using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_07
{
    internal class MoveDown : Movement
    {
        private int downLimit;
        private bool hasLimit;
        internal MoveDown()
        {
            this.hasLimit = false;
        }
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top += speed;
            if (hasLimit)
            {
                if (pictureBox.Top >= downLimit)
                {
                    pictureBox.Top -= speed;
                }
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.Down;
        }
        public override void setDownLimit(int downLimit)
        {
            this.downLimit = downLimit;
        }
        public override void setIsMoveDown(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
