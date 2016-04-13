using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Shape
    {
        public int depth { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public int calculateArea()
        {
            return this.height * this.width;
        }

        public int calculateVolume()
        {
            return this.height * this.width * this.depth;
        }
    }
}
