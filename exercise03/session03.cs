using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENQUYNHNAMPHUONG_31231027650_24C1INF50900503
{
    internal class session03
    {
        public static void Main()
        {
            //question01()
            //question02()
            //question03()
            //question04()
            //question05()
            Console.ReadKey();
        }
        public static void question01()
        //cac phep tinh
        {
            Console.WriteLine("Nhap so dau tien: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            double tong = a + b;
            double hieu = a - b;
            double tich = a * b;
            double thuong = a / b;
            double du = a % b;
            Console.WriteLine($"Tong hai so la {tong}");
            Console.WriteLine($"Hieu hai so la {hieu}");
            Console.WriteLine($"Tich hai so la {tich}");
            Console.WriteLine($"Thuong hai so la {thuong}");
            Console.WriteLine($"So du cua phep chia hai so la {du}");
        }
        public static void question02()
        //Tính biểu thức x=y^2+2y+1 khi y chạy trong khoảng từ -5 đến 5
        {
            Console.Write("Nhap vao so nguyen y: ");
            int y = int.Parse(Console.ReadLine());
            while (y < -5 || y > 5)
            {
                Console.Write("Nhap lai y: ");
                y = int.Parse(Console.ReadLine());
            }
            {
                Console.WriteLine("So nguyen y ban nhap vao da thoa man yeu cau ");
                int x;
                x = y * y + 2 * y + 1;
                Console.Write($"Vay neu y bang {y} thi x=y*y+2*y+1 bang {x}");
            }
            Console.ReadKey();
        }
        public static void question03()
        //tính vận tốc km/h và miles/h
        {
            Console.Write("Khoang cach la (km): ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("So gio la: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("So phut la: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("So giay la: ");
            int s = int.Parse(Console.ReadLine());
            double kmh = (double)d / (h + m / 60 + s / 3600);
            double mh = kmh / 1.609344;
            Console.WriteLine($"Van toc tinh theo km la: {kmh} km/h");
            Console.Write($"Van toc tinh theo miles la: {mh} miles/h");
            Console.ReadKey();
        }
        public static void question04()
        //tính diện tích và thể tích hình cầu
        {
            Console.Write("Nhap vao ban kinh: ");
            float a = float.Parse(Console.ReadLine());
            double pi = Math.PI;
            double s = 4 * pi * Math.Pow(a, 2);
            double v = 4 / 3 * pi * Math.Pow(a, 3);
            Console.WriteLine($"Dien tich be mat la: {s}");
            Console.WriteLine($"The tich la: {v}");
        }
        public static void question05()
        //Nhập vào kí tự và kiểm tra đó là nguyên âm, chữ số hay kí tự khác
        {
            Console.Write("Nhap vao mot ki tu: ");
            char k = char.Parse(Console.ReadLine());
            //Kiểm tra kí tự có phải số không
            if (char.IsDigit(k))
            {
                Console.WriteLine($"{k} la mot chu so");
            }
            //Kiểm tra kí tự có phải nguyên âm không
            else if (k == 'u' || k == 'U' || k == 'e' || k == 'E' || k == 'o' || k == 'O' || k == 'a' || k == 'A' || k == 'i' || k == 'I')
            {
                Console.WriteLine($"{k} la mot nguyen am");
            }
            else
            {
                Console.WriteLine($"{k} la mot ki tu khac");
            }
            Console.ReadKey();
        }
    }
}
