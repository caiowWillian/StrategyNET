using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Operations
{
    public class OperationA : IOperation
    {
        public int Operation(string value)
        {
            Console.WriteLine(value);

            return 1;
        }
    }
}
