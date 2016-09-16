using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Person
{
  interface IPerson
  {
    string Name { get; set; }
    string LastName { get; set; }
    string Address { get; set; }
    float Age { get; set; }

    string FullName();
    bool IsMinor();

  }
}
