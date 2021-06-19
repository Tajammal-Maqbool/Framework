using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public class MoveLeft : IOneDMovement
    {
        private int leftLimit;
        private bool hasLimit;
        internal MoveLeft()
        {
            this.hasLimit = false;
        }
        public void moveObject(int speed, PictureBox pictureBox)
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
        public Types getMovementType()
        {
            return Types.Left;
        }
        public void setLimit(int leftLimit)
        {
            this.leftLimit = leftLimit;
        }
        public void setHasLimit(bool hasLimit)
        {
            this.hasLimit = hasLimit;
        }
    }
}
