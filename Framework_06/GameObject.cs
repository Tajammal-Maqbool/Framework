using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Framework_06
{
    public class GameObject
    {
        private PictureBox pictureBoxObject;
        private Movement movement;
        private bool hasGravity;
        private int speed;
        private int health;
        private int coins;
        internal GameObject(PictureBox pictureBoxObject,bool hasGravity)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = 0;
            this.movement = null;
        }
        internal GameObject(PictureBox pictureBoxObject,bool hasGravity , int speed ,Movement movement)
        {
            this.pictureBoxObject = pictureBoxObject;
            this.hasGravity = hasGravity;
            this.speed = speed;
            this.movement = movement;
        }
        internal void update(int gravity)
        {
            if (hasGravity)
            {
                pictureBoxObject.Top += gravity;
            }
            movement.moveObject(speed, pictureBoxObject);
        }
        internal void update(int gravity, int groundPositionX)
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
        public void setGravity(bool hasGravity)
        {
            this.hasGravity = hasGravity;
        }
        public void changeMovemnet(Movement move)
        {
            MovementPool pool = MovementPool.getInstance();
            if (movement != null)
            {
                pool.realseMovement(movement);
            }
            this.movement = move;
        }
        internal PictureBox getPictureBox()
        {
            return this.pictureBoxObject;
        }
        public void setHealth(int health)
        {
            this.health = health;
        }
        public int getHealth()
        {
            return this.health;
        }
        public void increaseHealth(int health)
        {
            this.health = this.health + health;
        }
        public void decreaseHealth(int health)
        {
            this.health = this.health - health;
        }
        public void setCoins(int coins)
        {
            this.coins = coins;
        }
        public int getCoins()
        {
            return this.coins;
        }
        public void increaseCoins(int coins)
        {
            this.coins = this.coins + coins;
        }
        public void decreaseCoins(int coins)
        {
            this.coins = this.coins - coins;
        }
        ~GameObject()
        {
            if (movement != null)
            {
                MovementPool pool = MovementPool.getInstance();
                pool.realseMovement(movement);
            }
        }
    }
}
