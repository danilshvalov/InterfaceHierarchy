using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage bmp = new BitmapImage();
            bmp.Draw();
            bmp.DrawInBoundingBox(1, 1, 1, 1);
            bmp.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
