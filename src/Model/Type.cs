using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    public class Type
    {
        public IOperation Operation { get; private set; }

        public Type(IOperation Operation)
        {
            this.Operation = Operation;
        }

        public int Action(string value)
        {
            return this.Operation.Operation(value);
        }
    }
}
