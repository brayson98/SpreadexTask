using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Circle : Shape,IDraw
    {

        public Circle(int x, int y) : base(x, y)
        {
        }

        public int Size { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1} size={2}", typeof(Circle).Name, base.GetLocation(), this.Size);
        }
    }
}
