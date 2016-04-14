using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  interface IThreeDimensional
  {
    double depth { get; set; }

    double calculateVolume();
  }
}
