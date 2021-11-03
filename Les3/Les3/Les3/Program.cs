using System;

namespace Les3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100,100,50,60);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);

            vierkantBeweeg.MoveTo(50, 50);

            rechthoekBeweeg.Set(100, 100, 50, 60);
        }
    }
}
