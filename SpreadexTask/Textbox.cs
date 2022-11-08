using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadexAssessment
{
     class Textbox : Rectangle, IDraw
    {

        public Textbox(int x, int y)
            : base(x, y)
        { }

        public string Text { get; set; }

        public new void Print()
        {
            Console.WriteLine("{0} {1} Width={2} Height={3} Text={4}", typeof(Textbox).Name, base.GetLocation(), this.Width, this.Height, "\"" + this.Text + "\"");
        }
    }
    


}
       
 
