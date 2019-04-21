using Strategy.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Strategy.Model.Type t = new Strategy.Model.Type(new OperationA());


            int q = t.Action("value");

            Console.WriteLine(q);

            t = new Model.Type(new OperationB());

            q = t.Action("value");
            Console.WriteLine(q);

            Console.ReadLine();
        }
    }
}
