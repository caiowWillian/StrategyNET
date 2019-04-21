using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Operations
{
    public class OperationB : IOperation
    {
        public int Operation(string value)
        {
            Console.WriteLine("OperationB " + value);
            return 2;
        }
    }
}
