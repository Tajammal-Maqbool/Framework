using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Framework_06
{
    public class Factory
    {
        private int[] charactersListCounter;
        private static Factory factoryObject;
        //Singleton Class
        private Factory()
        {
            int counter = Enum.GetNames(typeof(Rolls)).Length;
            charactersListCounter = new int[counter];
        }
        public static Factory getInstance()
        {
            if(factoryObject == null)
            {
                factoryObject = new Factory();
            }
            return factoryObject;
        }
        // Creating Object that has No Movement
        public GameObject createGameObject(PictureBox pictureBox, bool hasGravity, Rolls roll)
        {
            charactersListCounter[(int)roll] += 1;
            return new GameObject(pictureBox, hasGravity);
        }
        // Creating Object that has Movement
        public GameObject createGameObject(PictureBox pictureBox,bool hasGravity,int speed,Movement movement,Rolls roll)
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
