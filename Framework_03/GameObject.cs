using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Framework_03
{
    class GameObject
    {
        private IMovement movement;
        private PictureBox pictureBoxObject;
        private bool hasGravity;
        private int speed; 
        internal GameObject(PictureBox pictureBoxObject,bool hasGravity , int speed ,IMovement movement)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.movement = movement;
            this.speed = speed;
            this.hasGravity = hasGravity;
        }
        public void update(int gravity)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
            }
            movement.moveObject(speed, pictureBoxObject);
        }
        public void update(int gravity ,int groundPositionX)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
                if (pictureBoxObject.Bottom > groundPositionX)
                {
                    pictureBoxObject.Top -= gravity;
                }
            }
            movement.moveObject(speed, pictureBoxObject);
        }
    }
}
