using MathNet.Numerics;
using MathNet.Numerics.Integration;
using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double> f= SymbolicExpression.Parse("x*x").Compile("x");
            Console.WriteLine(f(3));//=9
            double composite = SimpsonRule.IntegrateComposite(f, 0.0, 100, 1000);
            Console.WriteLine(composite);//=333333.333333
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
