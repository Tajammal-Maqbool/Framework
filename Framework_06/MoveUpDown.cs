using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_06
{
    internal class MoveUpDown : Movement
    {
        private int minimumYValue;
        private int maximumYValue;
        private bool isMoveUp;
        private bool isMoveDown;
        private States currentState;
        internal MoveUpDown()
        {
            this.minimumYValue = 0;
            this.maximumYValue = 0;
            currentState = States.Up;
        }
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            if (pictureBox.Top >= maximumYValue)
            {
                currentState = States.Up;
            }
            else if (pictureBox.Top <= minimumYValue)
            {
                currentState = States.Down;
            }
            if (currentState == States.Up && isMoveUp)
            {
                pictureBox.Top -= speed;
            }
            else if(currentState == States.Down && isMoveDown)
            {
                pictureBox.Top += speed;
            }
        }
        public override Types getMovementType()
        {
            return Types.UpDown;
        }
        public override void setUpLimit(int minimumYValue)
        {
            this.minimumYValue = minimumYValue;
        }
        public void setIsMoveUp(int maximumYValue)
        {
            this.maximumYValue = maximumYValue;
        }
        public override void setIsMoveUp(bool isMoveUp)
        {
            this.isMoveUp = isMoveUp;
        }
        public override void setIsMoveDown(bool isMoveDown)
        {
            this.isMoveDown = isMoveDown;
        }
    }
}
