using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Shape
    {
        public double depth { get; set; }
        public double height { get; set; }
        public double width { get; set; }

        public virtual double calculateArea()
        {
            return this.height * this.width;
        }

        public virtual double calculateVolume()
        {
            return this.height * this.width * this.depth;
        }
    }
}
