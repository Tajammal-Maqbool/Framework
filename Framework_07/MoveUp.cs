using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_07
{
    internal class MoveUp : Movement
    {
        private int  upLimit;
        private bool hasLimit;
        internal MoveUp()
        {
            this.hasLimit = false;
        }
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            pictureBox.Top -= speed;
            if (hasLimit)
            {
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += speed;
                }
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.Up;
        }
        public override void setUpLimit(int upLimit)
        {
            this.upLimit = upLimit;
        }
        public override void setIsMoveUp(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
