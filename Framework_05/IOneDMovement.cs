using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_05
{
    public interface IOneDMovement: IMovement
    {
        //Using For Updating Up , Down , Right and Left Limits 
        public void setHasLimit(bool hasLimit);
        public void setLimit(int limitValue);
    }
}
