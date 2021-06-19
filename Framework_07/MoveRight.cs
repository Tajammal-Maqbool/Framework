using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_07
{
    internal class MoveRight : Movement
    {
        private int  rightLimit;
        private bool hasLimit;
        internal MoveRight()
        {
            this.hasLimit = false;
        }
        public override void moveObject(int speed , PictureBox pictureBox)
        {
            pictureBox.Left += speed;
            if(hasLimit)
            {
                if (pictureBox.Left >= rightLimit)
                {
                    pictureBox.Left -= speed;
                }
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.Right;
        }
        public override void setRightLimit(int rightLimit)
        {
            this.rightLimit = rightLimit;
        }
        public override void setIsMoveRight(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
