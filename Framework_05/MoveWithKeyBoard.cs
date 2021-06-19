using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Framework_05
{
    public class MoveWithKeyBoard : IMultiDMovement
    {
        States currentKey;
        
        private bool isMoveRight;
        private bool isMoveLeft;
        private bool isMoveUp;
        private bool isMoveDown;
        private bool isJump;

        private int rightLimit;
        private int leftLimit;
        private int upLimit;
        private int downLimit;
        private int jumpSpeed;

        internal MoveWithKeyBoard()
        {
            this.isMoveRight = true;
            this.isMoveLeft  = true;
            this.isMoveUp    = true;
            this.isMoveDown  = true;
        }
        public void moveObject(int speed, PictureBox pictureBox)
        {
            currentKey = Game.getCurrentKey();
            if (currentKey == States.Right && isMoveRight)
            {
                pictureBox.Left += speed;
                if(pictureBox.Left >= rightLimit)
                {
                    pictureBox.Left -= speed;
                }
            }
            else if (currentKey == States.Left && isMoveLeft)
            {
                pictureBox.Left -= speed;
                if (pictureBox.Left <= leftLimit)
                {
                    pictureBox.Left += speed;
                }
            }
            else if (currentKey == States.Up && isMoveUp)
            {
                pictureBox.Top -= (speed+speed);
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += speed;
                }
            }
            else if (currentKey == States.Down && isMoveDown)
            {
                pictureBox.Top += speed;
                if (pictureBox.Top >= downLimit)
                {
                    pictureBox.Top -= speed;
                }
            }
            else if(currentKey == States.Jump && isJump)
            {
                pictureBox.Top -= jumpSpeed;
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += jumpSpeed;
                }
            }
        }
        public Types getMovementType()
        {
            return Types.KeyBoard;
        }
        public void setIsMoveRight(bool isMoveRight)
        {
            this.isMoveRight = isMoveRight;
        }
        public void setIsMoveLeft(bool isMoveLeft)
        {
            this.isMoveLeft = isMoveLeft;
        }
        public void setIsMoveUp(bool isMoveUp)
        {
            this.isMoveUp = isMoveUp;
        }
        public void setIsMoveDown(bool isMoveDown)
        {
            this.isMoveDown = isMoveDown;
        }
        public void setIsJump(bool isJump)
        {
            this.isJump = isJump;
        }
        public void setRightLimt(int rightLimit)
        {
            this.rightLimit = rightLimit;
        }
        public void setLeftLimt(int leftLimit)
        {
            this.leftLimit = leftLimit;
        }
        public void setUpLimt(int upLimit)
        {
            this.upLimit =upLimit;
        }
        public void setDownLimt(int downLimit)
        {
            this.downLimit = downLimit;
        }
        public void setJumpSpeed(int jumpSpeed)
        {
            this.jumpSpeed = jumpSpeed;
        }
    }
}
