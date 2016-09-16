using Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      //Basic implementation

      Student zain = new Student()
      { Name = "Zain", LastName = "Albarmawi", Address = "TR,Istanbul", Id = "TR01", Age = 5 };
      Employee omar = new Employee() { Name = "Omar", LastName = "Albarmawi", Address = "TR,Istanbul", Age = 23 };


      Console.WriteLine("Printing : ");

      PrintPersonInfo(zain);
      PrintPersonInfo(omar);

      Console.ReadKey();
    }

    static void PrintPersonInfo(IPerson person)
    {
      Console.WriteLine($"{person.FullName()}, Address: {person.Address}, IsMinor: {person.IsMinor()}");
    }
  }
}
