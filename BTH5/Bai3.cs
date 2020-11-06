using System;
using System.Collections.Generic;
using System.Text;

namespace BTH5
{
    class Matran
    {
        protected int m, n;
        protected int[,] a;
        public Matran()
        {
            m = n = 0;
            a = new int[m, n];
        }
        public Matran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }
        public void Nhap()
        {
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m="); m = int.Parse(Console.ReadLine());
            a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

    }
    class Matranvuong : Matran
    {

        public new void Nhap()
        {
            do
            {
                base.Nhap();
            } while (n != m);

        }
        public int TongDCC()
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCP()
        {
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCCk(int k)
        {
            int t = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == j)
                        t += a[i, j];

                }
            }
            return t;
        }
        public int TongDCPK(int k)
        {
            int t = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        t += a[i, j];

                }
            }
            return t;
        }
    }
    class Program2
    {
        static void Main2()
        {
            Matranvuong t = new Matranvuong();
            t.Nhap();
            Console.WriteLine("Tong duong cheo chinh:{0}", t.TongDCC());
            Console.WriteLine("Tong duong cheo phu:{0}", t.TongDCP());
            Console.WriteLine("Tong duong cheo chinh thu k:{0}", t.TongDCCk(2));
            Console.WriteLine("Tong duong cheo phu thu k:{0}", t.TongDCPK(2));
            Console.ReadKey();
        }
    }
}

