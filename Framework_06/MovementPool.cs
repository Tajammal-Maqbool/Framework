using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Framework_06
{
    public class MovementPool
    {
        //Total Lists of Free and Occupied Movements
        private List<Movement> freeMovements;
        private List<Movement> occupiedMovements;

        //Singleton Class
        private static MovementPool poolObject;
        private MovementPool()
        {
            freeMovements = new List<Movement>();
            occupiedMovements = new List<Movement>();
        } 
        public static MovementPool getInstance()
        {
            if (poolObject == null)
            {
                poolObject = new MovementPool();
            }
            return poolObject;
        }
        internal void realseMovement(Movement movement)
        {
            freeMovements.Add(movement);
            occupiedMovements.Remove(movement);
        }
        public Movement getMovement(Types movementType)
        {
            if (freeMovements.Count != 0)
            {
                foreach (Movement movement in freeMovements)
                {
                    if (movement.getMovementType() == movementType)
                    {
                        freeMovements.Remove(movement);
                        occupiedMovements.Add(movement);
                        return movement;
                    }
                }
            }
            // If Not Existing In Lists then Creating New Object
            if (movementType == Types.Right)
            {
                Movement move = new MoveRight();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.Left)
            {
                MoveLeft move = new MoveLeft();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.Up)
            {
                MoveUp move = new MoveUp();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.Down)
            {
                MoveDown move = new MoveDown();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.LeftRight)
            {
                MoveLeftRight move = new MoveLeftRight();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.UpDown)
            {
                MoveUpDown move = new MoveUpDown();
                occupiedMovements.Add(move);
                return move;
            }
            else if (movementType == Types.KeyBoard)
            {
                MoveWithKeyBoard move = new MoveWithKeyBoard();
                occupiedMovements.Add(move);
                return move;
            }
            return null;
        }
        public int getTotalFreeMovements()
        {
            return freeMovements.Count;
        }
        public int getTotalOccupiedMovements()
        {
            return occupiedMovements.Count;
        }
    }
}
