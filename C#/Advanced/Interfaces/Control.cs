using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
  class Control : ISavable, IDeletable
  {
    public void Delete()
    {
      Console.WriteLine("Control:Delete");
    }

    public void Save()
    {
      Console.WriteLine("Control:Save");
    }
    void ISavable.Save()
    {
      Console.WriteLine("ISavable:Save");

    }
  }
}
