using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework_06
{
    public class Collision
    {
        private GameObject object1;
        private GameObject object2;
        private GameObject affectedObject;
        private CollisionTypes type;
        private int value;
        public Collision(GameObject object1,GameObject object2,GameObject affectedObject,CollisionTypes type,int value)
        {
            this.object1 = object1;
            this.object2 = object2;
            this.affectedObject = affectedObject;
            this.type = type;
            this.value = value;
        }
        internal void checkCollision()
        {
            PictureBox picture1 = object1.getPictureBox();
            PictureBox picture2 = object2.getPictureBox();

            if (picture1.Bounds.IntersectsWith(picture2.Bounds))
            {
                if (type == CollisionTypes.IncreaseHealth)
                {
                    if (value < 0)
                    {
                        value = (-1) * value;
                    }
                    affectedObject.increaseHealth(value);
                }
                else if (type == CollisionTypes.DecreaseHealth)
                {
                    if (value > 0)
                    {
                        value = (-1) * value;
                    }
                    affectedObject.decreaseHealth(value);
                }
                else if (type == CollisionTypes.IncreaseCoins)
                {
                    if (value < 0)
                    {
                        value = (-1) * value;
                    }
                    affectedObject.increaseCoins(value);
                }
                else if (type == CollisionTypes.DecreaseCoins)
                {
                    if (value > 0)
                    {
                        value = (-1) * value;
                    }
                    affectedObject.decreaseCoins(value);
                }
            }
        }
    }
}
