using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_04
{
    public class MoveUpDown : IMovement
    {
        private int minimumYValue;
        private int maximumYValue;
        private State currentState;
        public MoveUpDown(int minimumYValue, int maximumYValue)
        {
            this.minimumYValue = minimumYValue;
            this.maximumYValue = maximumYValue;
            currentState = State.Up;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            if (pictureBox.Top >= maximumYValue)
            {
                currentState = State.Up;
            }
            else if (pictureBox.Top <= minimumYValue)
            {
                currentState = State.Down;
            }
            if (currentState == State.Up)
            {
                pictureBox.Top -= speed;
            }
            else
            {
                pictureBox.Top += speed;
            }
        }
    }
}
