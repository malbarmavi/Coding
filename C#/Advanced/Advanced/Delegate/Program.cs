using System;

namespace Delegate {
  class Program {
    delegate void PrintHello();
    delegate int Square(int number);
    static void Main(string[] args) {

      // using lambda expressions
      PrintHello writeHello = () => Console.WriteLine("Hello World");
      writeHello(); // Hello World
      writeHello += () => Console.WriteLine("Hello from Another World");
      writeHello.Invoke(); // Hellow World , Hello from Another World

      Square calc = sqrt;
      Console.WriteLine(calc(5)); // 25
      Console.WriteLine(sqrt(5)); // 25

      calc += x => x + 2;
      calc += x => x * x * x;
      Console.WriteLine(calc(5));  // 125

      Func<int> f = () => 2;
      Console.WriteLine(f());

      Func<int, int, int> max = (x, y) => x > y ? x : y;
      Console.WriteLine(max(5,2));

      Action hello = () => Console.WriteLine("\nHello World");

      hello();

      Action<int> repeat = n => {
        for (int i = 0; i < n; i++) {
          Console.WriteLine("Hello World from Action");
        }
      };

      Console.WriteLine("");
      repeat(5);
    }

    static int sqrt(int num) => num * num;

  }
}
