using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_05
{
    public interface ITwoDMovement: IMovement
    {
        public void setMinimumLimit(int minimumValue);
        public void setMaximumLimit(int maximumValue);
    }
}
