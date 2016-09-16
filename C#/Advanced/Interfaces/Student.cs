using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
  using Person;
  public class Student : IPerson
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public float Age { get; set; }
    public string Id { get; set; }
    public string FullName() => $"{Id}, {Name} {LastName}, {Address}";

    public bool IsMinor() => Age < 18;


  }
}
