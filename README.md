# MathDotNetTest
```
Func<double,double> f= SymbolicExpression.Parse("x*x").Compile("x");
Console.WriteLine(f(3));//=9
double composite = SimpsonRule.IntegrateComposite(f, 0.0, 100, 1000);
Console.WriteLine(composite);//=333333.333333
```
