using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Framework_02
{
    class GameObject
    {
        private MoveRight moveRight;
        private MoveLeft moveLeft;
        private MoveLeftRight moveLeftRight;
        private MoveWithKeyBoard moveWithKeyBoard;
        private PictureBox pictureBoxObject;
        private bool hasGravity;
        private int speed; 
        public GameObject(PictureBox pictureBoxObject,bool hasGravity , int speed ,MoveRight moveRight)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.moveRight = moveRight;
            this.speed = speed;
            this.hasGravity = hasGravity;
        }
        public GameObject(PictureBox pictureBoxObject,bool hasGravity , int speed, MoveLeft moveLeft)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.moveLeft = moveLeft;
            this.speed = speed;
            this.hasGravity = hasGravity;
        }
        public GameObject(PictureBox pictureBoxObject,bool hasGravity ,int speed, MoveLeftRight moveLeftRight)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.moveLeftRight = moveLeftRight;
            this.speed = speed;
            this.hasGravity = hasGravity;
        }
        public GameObject(PictureBox pictureBoxObject,bool hasGravity,int speed, MoveWithKeyBoard moveWithKeyBoard)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.moveWithKeyBoard = moveWithKeyBoard;
            this.speed = speed;
            this.hasGravity = hasGravity;
        }
        public void update(int gravity, State currentKeyPressed)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
            }
            if (moveRight != null)
            {
                moveRight.moveRight(speed, pictureBoxObject);
            }
            else if (moveLeft != null)
            {
                moveLeft.moveLeft(speed, pictureBoxObject);
            }
            else if (moveLeftRight != null)
            {
                moveLeftRight.moveLeftRight(speed, pictureBoxObject);
            }
            else if (moveWithKeyBoard != null)
            {
                moveWithKeyBoard.moveObject(speed, pictureBoxObject, currentKeyPressed);
            }
        }
        public void update(int gravity ,int groundPositionX ,State currentKeyPressed)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
                if (pictureBoxObject.Bottom > groundPositionX)
                {
                    pictureBoxObject.Top -= gravity;
                }
            }
            if (moveRight != null)
            {
                moveRight.moveRight(speed, pictureBoxObject);
            }
            else if (moveLeft != null)
            {
                moveLeft.moveLeft(speed, pictureBoxObject);
            }
            else if (moveLeftRight != null)
            {
                moveLeftRight.moveLeftRight(speed, pictureBoxObject);
            }
            else if (moveWithKeyBoard != null)
            {
                moveWithKeyBoard.moveObject(speed, pictureBoxObject , currentKeyPressed);
            }
        }
    }
}
