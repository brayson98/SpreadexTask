using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Shape 
    {
        

        private int _x = 0;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = 0;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public string GetLocation()
        {
            return "(" + this.X + "," + this.Y + ")";
        }

    }
}
