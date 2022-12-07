using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangleApplication
{
    public class Method
    {
        public void Start()
        {
            Console.Write("Lütfen çizilmesini istediğiniz üçgenin büyüklük seçimi için bir tamsayı girin: ");
        }

        public int IsNumber()
        {
            int n = 0;
            bool answer = false;
            while (answer == false)
            {
                answer = int.TryParse(Console.ReadLine(), out n);
                if (answer == false)
                    Console.Write("Lütfen bir tamsayı giriniz: ");
                else
                    answer = true;
            }
            return n;
        }

        public void DrawTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public bool Repeat(bool ext)
        {
            Console.WriteLine("Tekrar üçgen çizdirmak ister misiniz?(e/h)");
            string sum = Console.ReadLine();
            if (sum == "h")
                ext = true;
            else if (sum == "e")
                ext = false;
            else
                Console.WriteLine("Lütfen sizden istenen cevaplardan birini giriniz(e/h)");
            return ext;
        }
        
    }
}
