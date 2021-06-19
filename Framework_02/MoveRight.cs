using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_02
{
    class MoveRight
    {
        private int rightLimit;
        private bool isLimitPut;
        public MoveRight()
        {
            this.isLimitPut = false;
        }
        public MoveRight(int rightLimit)
        {
            this.isLimitPut = true;
            this.rightLimit = rightLimit;
        }
        public void moveRight(int speed , PictureBox pictureBox)
        {
            pictureBox.Left += speed;
            if(isLimitPut)
            {
                if (pictureBox.Left >= rightLimit)
                {
                    pictureBox.Left -= speed;
                }
            }
        }
    }
}
