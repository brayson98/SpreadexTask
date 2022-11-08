using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Rectangle : Shape, IDraw
    {

        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle(int x, int y) : base(x, y)
        {
        }
        public void Print()
        {


             Console.WriteLine("{0} {1} Width={2} Height={3} ", typeof(Rectangle).Name, base.GetLocation(), this.Width, this.Height);
            
        }

    }
       
    }

