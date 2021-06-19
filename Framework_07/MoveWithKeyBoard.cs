using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Framework_07
{
    internal class MoveWithKeyBoard : Movement
    {
        PlayerStates currentKey;
        
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
        public override void moveObject(int speed, PictureBox pictureBox)
        {
            currentKey = Game.getCurrentKey();
            if (currentKey == PlayerStates.Right && isMoveRight)
            {
                pictureBox.Left += speed;
                if(pictureBox.Left >= rightLimit)
                {
                    pictureBox.Left -= speed;
                }
            }
            else if (currentKey == PlayerStates.Left && isMoveLeft)
            {
                pictureBox.Left -= speed;
                if (pictureBox.Left <= leftLimit)
                {
                    pictureBox.Left += speed;
                }
            }
            else if (currentKey == PlayerStates.Up && isMoveUp)
            {
                pictureBox.Top -= (speed+speed);
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += speed;
                }
            }
            else if (currentKey == PlayerStates.Down && isMoveDown)
            {
                pictureBox.Top += speed;
                if (pictureBox.Top >= downLimit)
                {
                    pictureBox.Top -= speed;
                }
            }
            else if(currentKey == PlayerStates.Jump && isJump)
            {
                pictureBox.Top -= jumpSpeed;
                if (pictureBox.Top <= upLimit)
                {
                    pictureBox.Top += jumpSpeed;
                }
            }
        }
        public override MovementTypes getMovementType()
        {
            return MovementTypes.KeyBoard;
        }
        public override void setIsMoveRight(bool isMoveRight)
        {
            this.isMoveRight = isMoveRight;
        }
        public override void setIsMoveLeft(bool isMoveLeft)
        {
            this.isMoveLeft = isMoveLeft;
        }
        public override void setIsMoveUp(bool isMoveUp)
        {
            this.isMoveUp = isMoveUp;
        }
        public override void setIsMoveDown(bool isMoveDown)
        {
            this.isMoveDown = isMoveDown;
        }
        public override void setIsJump(bool isJump)
        {
            this.isJump = isJump;
        }
        public override void setRightLimit(int rightLimit)
        {
            this.rightLimit = rightLimit;
        }
        public override void setLeftLimit(int leftLimit)
        {
            this.leftLimit = leftLimit;
        }
        public override void setUpLimit(int upLimit)
        {
            this.upLimit =upLimit;
        }
        public override void setDownLimit(int downLimit)
        {
            this.downLimit = downLimit;
        }
        public override void setJumpSpeed(int jumpSpeed)
        {
            this.jumpSpeed = jumpSpeed;
        }
    }
}
