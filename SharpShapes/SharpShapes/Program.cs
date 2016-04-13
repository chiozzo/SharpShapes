using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rhombus");
            Console.WriteLine("4. Cube");
            Console.WriteLine("5. Cylinder");
            Console.Write("> ");
            Console.Read();
        }
    }
}
