using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_03
{
    class Factory
    {
        private int[] charactersListCounter;
        private static Factory factoryObject;
        private Factory()
        {
            int counter = Enum.GetNames(typeof(Rolls)).Length;
            charactersListCounter = new int[counter];
            //Cannot Crearteable To Object
        }
        public static Factory getInstance()
        {
            if(factoryObject == null)
            {
                factoryObject = new Factory();
            }
            return factoryObject;
        }
        public GameObject createGameObject(PictureBox pictureBox,bool hasGravity,int speed,IMovement movement,Rolls roll)
        {
            charactersListCounter[(int)roll] += 1;
            return new GameObject(pictureBox, hasGravity, speed, movement);
        }
        public int[] getCounterList()
        {
            return charactersListCounter;
        }
    }
}
