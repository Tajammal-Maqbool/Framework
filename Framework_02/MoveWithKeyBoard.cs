using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Framework_02
{
    class MoveWithKeyBoard
    {
        public void moveObject(int speed,PictureBox pictureBox , State currentKey)
        {
            if(currentKey== State.Right)
            {
                pictureBox.Left += speed;
            }
            else if (currentKey == State.Left)
            {
                pictureBox.Left -= speed;
            }
            else if (currentKey == State.Up)
            {
                pictureBox.Top -= speed;
            }
            else if (currentKey == State.Down)
            {
                pictureBox.Top += speed;
            }
        }
    }
}
