using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathang
{
    internal class MatHang
    {
        private string maHH;
        private string tenHH;
        private float donGia;
        private int soLuong;

        public MatHang()
        {
            this.maHH = "";
            this.tenHH = "";
            this.donGia = 0;
            this.soLuong = 0;
        }

        public MatHang(string maHH, string tenHH, float donGia, int soLuong)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }


        public void Nhap()
        {
            Console.Write("Nhap ma hang hoa: ");
            maHH = Console.ReadLine();
            Console.Write("Nhap ten hang hoa: ");
            tenHH = Console.ReadLine();
            Console.Write("Nhap don gia cua hang hoa: ");
            donGia = float.Parse(Console.ReadLine());
            Console.Write("Nhap so luong hang hoa: ");
            soLuong = int.Parse(Console.ReadLine());
        }

        public void hienThi()
        {
            Console.WriteLine($"Ma hang hoa: {maHH}");
            Console.WriteLine($"Ten hang hoa: {tenHH}");
            Console.WriteLine($"Don gia: {donGia}");
            Console.WriteLine($"So luong: {soLuong}");
        }

        public void tinhTien()
        {
            double tien = donGia * soLuong;

            Console.WriteLine($"Gia tien cua mat hang {tenHH} la: {tien}");
        }


    }
}
