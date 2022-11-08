namespace SpreadexAssessment
{
    class Program
    {

        static void Main(string[] args)
        {

            //Hard-coded set of widgets 
            var widgets = new List<IDraw>()
        {
            new Rectangle(10, 10) { Width = 30, Height = 40 },
            new Square(15, 30) { Size = 35 },
            new Ellipse(100, 150) { HorizontalDiameter = 300, VerticalDiameter = 200 },
            new Circle(1, 1) { Size = 300 },
            new Textbox(5, 5) { Width = 200, Height = 100, Text = "Sample text!" }
        };

            
            foreach (var widget in widgets)
            {
                try
                {
                    widget.Print();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.ReadKey();
        }

        
            }
        }
    
