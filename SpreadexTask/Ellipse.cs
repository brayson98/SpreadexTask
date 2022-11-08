using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Ellipse : Shape, IDraw
    {
        public Ellipse(int x, int y) : base(x, y)
        {
        }

        public int HorizontalDiameter { get; set; }

        public int VerticalDiameter { get; set; }

        public void Print()
        {
            Console.WriteLine("{0} {1} diameterH={2} diameterY={3}", typeof(Ellipse).Name, base.GetLocation(), this.HorizontalDiameter, this.VerticalDiameter);
        }
    }
}
