using System;

namespace DrawTriangleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ext = false;
            while (ext == false)
            {
                Method methods = new Method();

                methods.Start();

                int n = methods.IsNumber();

                methods.DrawTriangle(n);

                ext = methods.Repeat(ext);
            }
        }
    }
}
