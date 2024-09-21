using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_trang_76
{
    internal class SinhVien
    {
        private string hoTen, maSV;
        private double diemToan, diemVan;

        public SinhVien()
        {
            this.hoTen = "";
            this.maSV = "";
            this.diemToan = 0;
            this.diemVan = 0;
        }

        public SinhVien(string hoTen, string maSV, double diemToan, double diemVan)
        {
            this.hoTen = hoTen;
            this.maSV = maSV;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = double.Parse(Console.ReadLine());
        }


        public void Hien()
        {
            Console.WriteLine($"Ho ten sinh vien la: {hoTen}");

            Console.WriteLine($"Ma sinh vien: {maSV} ");

            Console.WriteLine($"Diem toan: {diemToan}");

            Console.WriteLine($"Diem van: {diemVan}");

        }

        public double diemtoan
        {
            get { return this.diemToan; }
        }

        public double diemvan
        {
            get { return this.diemVan; }
        }

        public string hoten
        {
            get { return this.hoTen; }
        }
    }
}
