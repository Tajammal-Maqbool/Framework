using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_03
{
    class MoveRight: IMovement
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
        public void moveObject(int speed , PictureBox pictureBox)
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
