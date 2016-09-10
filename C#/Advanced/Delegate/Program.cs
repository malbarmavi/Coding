using System;

namespace Delegate {
  class Program {
    delegate void PrintHello();
    delegate int Square(int number);
    static void Main(string[] args) {

      // using lambda expressions
      PrintHello writeHello = () => Console.WriteLine("Hello World");
      writeHello(); // => Hello World
      writeHello += () => Console.WriteLine("Hello from Another World");
      writeHello.Invoke(); // => Hellow World , Hello from Another World

    }


  }
}
