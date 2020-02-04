using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            Console.ReadKey();
        }
    }
}
