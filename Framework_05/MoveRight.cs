using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    internal class MoveRight : IOneDMovement
    {
        private int  rightLimit;
        private bool hasLimit;
        internal MoveRight()
        {
            this.hasLimit = false;
        }
        public void moveObject(int speed , PictureBox pictureBox)
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
        public Types getMovementType()
        {
            return Types.Right;
        }
        public void setLimit(int rightLimit)
        {
            this.rightLimit = rightLimit;
        }
        public void setHasLimit(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
