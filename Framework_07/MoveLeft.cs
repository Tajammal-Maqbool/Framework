using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_07
{
    internal class MoveLeft : Movement
    {
        private int leftLimit;
        private bool hasLimit;
        internal MoveLeft()
        {
            this.hasLimit = false;
        }
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Left -= speed;
            if (hasLimit)
            {
                if(pictureBox.Left <= leftLimit)
                {
                    pictureBox.Left += speed;
                }
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.Left;
        }
        public override void setLeftLimit(int leftLimit)
        {
            this.leftLimit = leftLimit;
        }
        public override void setIsMoveLeft(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
