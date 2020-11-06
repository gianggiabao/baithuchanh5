using System;
using System.Security.Cryptography.X509Certificates;

namespace BTH5
{
    class TienDien
    {
        private string TenCH, DiaChi;
        private double SoCTTT, SoCTTN;
        public TienDien()
        {
            TenCH = DiaChi = "";
            SoCTTN = SoCTTT = 0;
        }
        public TienDien(string TenCH, string DiaChi, double SoCTTN, double SoCTTT)
        {
            this.TenCH = TenCH;
            this.DiaChi = DiaChi;
            this.SoCTTT = SoCTTT;
            this.SoCTTN = SoCTTN;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ten chu ho:");
            TenCH = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap so cong to dien thang truoc:");
            SoCTTT = double.Parse(Console.ReadLine());
            Console.Write("Nhap so cong to dien thang nay:");
            SoCTTN = double.Parse(Console.ReadLine());
        }
        public virtual void Hien()
        {
            Console.WriteLine("Ten Chu Ho:" + TenCH);
            Console.WriteLine("Dia Chi:" + DiaChi);
            Console.WriteLine("So Cong To Thang Truoc :" + SoCTTT);
            Console.WriteLine("So Cong To Thang Nay:" + SoCTTN);
            Console.WriteLine("Tien Dien Phai Tra La:" + TinhTienDien());
        }
        public virtual double SoCTDien
        {
            get { return SoCTTN - SoCTTT; }
        }
        public virtual double TinhTienDien()
        {
            return (SoCTTN - SoCTTT) * 500;
        }
    }
    class TienDienMoi : TienDien
    {
        private int dinhmuc;
        public override void Nhap()
        {
            Console.Write("NHAP DINH MUC:");
            dinhmuc = int.Parse(Console.ReadLine());
            base.Nhap();
        }
        public override void Hien()
        {
            Console.Write("DINH MUC " + dinhmuc);
            base.Hien();
        }
        public override double TinhTienDien()
        {
            if (dinhmuc <= 500)
                return base.TinhTienDien();
            else
                return SoCTDien * 600;
        }
    }
    class QL
    {
        private int soho;
        private TienDien[] ds;
        public void Nhap()
        {
            Console.Write("Nhap So Ho Su Dung Dien :");
            soho = int.Parse(Console.ReadLine());
            ds = new TienDien[soho];
            for (int i = 0; i < soho; ++i)
            {
                ds[i] = new TienDien();
                ds[i].Nhap();
            }
        }
        public void Hien()
        {
            Console.Write(" THONG TIN CAC HO SU DUNG DIEN ");
            for (int i = 0; i < soho; ++i)
            {
                ds[i] = new TienDien();
                ds[i].Hien();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            QL t = new QL();
            t.Nhap();
            t.Hien();
        }
    }
}
