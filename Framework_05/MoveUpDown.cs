using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_05
{
    public class MoveUpDown : ITwoDMovement
    {
        private int minimumYValue;
        private int maximumYValue;
        private States currentState;
        internal MoveUpDown()
        {
            this.minimumYValue = 0;
            this.maximumYValue = 0;
            currentState = States.Up;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            if (pictureBox.Top >= maximumYValue)
            {
                currentState = States.Up;
            }
            else if (pictureBox.Top <= minimumYValue)
            {
                currentState = States.Down;
            }
            if (currentState == States.Up)
            {
                pictureBox.Top -= speed;
            }
            else
            {
                pictureBox.Top += speed;
            }
        }
        public Types getMovementType()
        {
            return Types.UpDown;
        }
        public void setMinimumLimit(int minimumYValue)
        {
            this.minimumYValue = minimumYValue;
        }
        public void setMaximumLimit(int maximumYValue)
        {
            this.maximumYValue = maximumYValue;
        }
    }
}
