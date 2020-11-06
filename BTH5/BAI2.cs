using System;
using System.Collections.Generic;
using System.Text;

namespace BTH5
{
        class Tamgiac
        {
            private double a, b, c;
            public Tamgiac()
            {
                a = b = c = 0;
            }
            public Tamgiac(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void Nhap()
            {
                Console.Write("Nhap canh a="); a = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh b="); b = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh c="); c = int.Parse(Console.ReadLine());
            }
            public void Hien()
            {
                Console.WriteLine("Ba canh lan luot la a={0}\tb={1}\tc={2}\tDientich={3}", a, b, c, Tinhdt());
            }
            public bool Ktr()
            {
                return a + b > c && b + c > a && a + c > b;
            }
            public double Tinhdt()
            {
                return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));

            }
        }
        class Tudien : Tamgiac
        {
            private double h;
            public Tudien() : base()
            {
                h = 0;
            }
            public Tudien(double a, double b, double c, double h) : base(a, b, c)
            {
                this.h = h;
            }
            public new void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap chieu cao h="); h = int.Parse(Console.ReadLine());
            }
            public new void Hien()
            {
                base.Hien();
                Console.WriteLine("Chieu cao={0}\t The tich={1}", h, Tinhtt());
            }
            public double Tinhtt()
            {
                return Tinhdt() * 1 / 3 * h;
            }
        }
    
    class Program1
    {
        static void Main1()
        {
            Tudien t = new Tudien();
            t.Nhap();
            t.Hien();
            Console.ReadKey();
        }
    }
}

