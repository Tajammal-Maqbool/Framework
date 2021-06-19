using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Framework_05
{
    public class MovementPool
    {
        //Total Lists of Free and Occupied Movements
        private List<IOneDMovement> freeMovements1;
        private List<IOneDMovement> occupiedMovements1;

        //Total Lists of Free and Occupied Movements
        private List<ITwoDMovement> freeMovements2;
        private List<ITwoDMovement> occupiedMovements2;

        //Total Lists of Free and Occupied Movements
        private List<IMultiDMovement> freeMovements3;
        private List<IMultiDMovement> occupiedMovements3;

        //Singleton Class
        private static MovementPool poolObject;
        private MovementPool()
        {
            freeMovements1 = new List<IOneDMovement>();
            occupiedMovements1 = new List<IOneDMovement>();

            freeMovements2 = new List<ITwoDMovement>();
            occupiedMovements2 = new List<ITwoDMovement>();

            freeMovements3 = new List<IMultiDMovement>();
            occupiedMovements3 = new List<IMultiDMovement>();
        } 
        public static MovementPool getInstance()
        {
            if (poolObject == null)
            {
                poolObject = new MovementPool();
            }
            return poolObject;
        }
        internal void realseMovement(IOneDMovement movement)
        {
            freeMovements1.Add(movement);
            int counter = 0 ;
            for (int idx = 0; idx < occupiedMovements1.Count; idx++)
            {
                ITwoDMovement move = (ITwoDMovement) occupiedMovements1[idx];
                if (move == movement)
                {
                    occupiedMovements1.RemoveAt(counter);
                    break;
                }
                counter++;
            }
        }
       internal void realseMovement(ITwoDMovement movement)
        {
            freeMovements2.Add(movement);
            int counter = 0;
            for(int idx=0; idx<occupiedMovements2.Count; idx++)
            {
                ITwoDMovement move = (ITwoDMovement) occupiedMovements2[idx];
                if (move == movement)
                {
                    occupiedMovements2.RemoveAt(counter);
                    break;
                }
                counter++;
            }
        }
       internal void realseMovement(IMultiDMovement movement)
        {
            freeMovements3.Add(movement);
            int counter = 0;
            for (int idx = 0; idx < occupiedMovements3.Count; idx++)
            {
                ITwoDMovement move = (ITwoDMovement) occupiedMovements3[idx];
                if (move == movement)
                {
                    occupiedMovements3.RemoveAt(counter);
                    break;
                }
                counter++;
            }
        }
        public object getMovement(Types movementType)
        {
            int count,counter;
            count = 0;
            foreach (Types type in Enum.GetValues(typeof(Types)))
            {
                if (movementType == type)
                {
                    if (movementType == type && count <= 3)
                    {
                        counter = 0;
                        if (freeMovements1.Count != 0)
                        {
                            foreach (IOneDMovement movement in freeMovements1)
                            {
                                if (movement.getMovementType() == movementType)
                                {
                                    freeMovements1.RemoveAt(counter);
                                    occupiedMovements1.Add(movement);
                                    return movement;
                                }
                                counter++;
                            }
                        }
                    }
                    else if (movementType == type && count <= 5)
                    {
                        counter = 0;
                        if (freeMovements2.Count != 0)
                        {
                            foreach (ITwoDMovement movement in freeMovements2)
                            {
                                if (movement.getMovementType() == movementType)
                                {
                                    freeMovements2.RemoveAt(counter);
                                    occupiedMovements2.Add(movement);
                                    return movement;
                                }
                                counter++;
                            }
                        }
                    }
                    else if (movementType == type && count == 6)
                    {
                        counter = 0;
                        if (freeMovements3.Count != 0)
                        {
                            foreach (IMultiDMovement movement in freeMovements3)
                            {
                                if (movement.getMovementType() == movementType)
                                {
                                    freeMovements3.RemoveAt(counter);
                                    occupiedMovements3.Add(movement);
                                    return movement;
                                }
                                counter++;
                            }
                        }
                    }
                    // If Not Existing In Lists then Creating New Object
                    if (movementType == Types.Right)
                    {
                        MoveRight move = new MoveRight();
                        occupiedMovements1.Add(move);
                        return move;
                    }
                    else if (movementType == Types.Left)
                    {
                        MoveLeft move = new MoveLeft();
                        occupiedMovements1.Add(move);
                        return move;
                    }
                    else if (movementType == Types.Up)
                    {
                        MoveUp move = new MoveUp();
                        occupiedMovements1.Add(move);
                        return move;
                    }
                    else if(movementType == Types.Down)
                    {
                        MoveUp move = new MoveUp();
                        occupiedMovements1.Add(move);
                        return move;
                    }
                    else if(movementType == Types.LeftRight)
                    {
                        MoveLeftRight move = new MoveLeftRight();
                        occupiedMovements2.Add(move);
                        return move;
                    }
                    else if(movementType == Types.UpDown)
                    {
                        MoveUpDown move = new MoveUpDown();
                        occupiedMovements2.Add(move);
                        return move;
                    }
                    else if(movementType == Types.KeyBoard)
                    {
                        MoveWithKeyBoard move = new MoveWithKeyBoard();
                        occupiedMovements3.Add(move);
                        return move;
                    }
                }
                count++;
            }
            return null;
        }
        public int getTotalFreeMovements()
        {
            return freeMovements1.Count + freeMovements2.Count + freeMovements3.Count;
        }
        public int getTotalOccupiedMovements()
        {
            return occupiedMovements1.Count + occupiedMovements2.Count + occupiedMovements3.Count;
        }
    }
}
