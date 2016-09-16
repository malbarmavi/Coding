using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Person
{

  public class Employee : IPerson
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public float Age { get; set; }

    public string FullName() => $"{Name} {LastName}";

    public bool IsMinor() => Age < 18;
  }
}
