using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Square : Shape, IDraw
    {
        public Square(int x, int y) : base(x, y)
        {
        }

        public int Size { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1}  size={2}", typeof(Square).Name, base.GetLocation(), this.Size);
        }
    }
}
