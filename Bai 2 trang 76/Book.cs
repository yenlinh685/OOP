using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_trang_76
{
    internal class Book
    {
        private string tenSach;
        private string maSach;
        private string tacGia;
        private int soLuong;

        public Book (string tenSach, string maSach, string tacGia, int soLuong)
        {
            this.tenSach = tenSach;
            this.maSach = maSach;
            this.tacGia = tacGia;
            this.soLuong = soLuong;
        }

        public Book()
        {
            this.tenSach = "";
            this.maSach = "";
            this.tacGia = "";
            this.soLuong = 0;
        }

        public void nhap()
        {
            Console.Write("Nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.Write("Nhap ma sach: ");
            maSach = Console.ReadLine();
            Console.Write("Nhap tac gia: ");
            tacGia = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
        }

        public void hien()
        {
            Console.WriteLine($"ten sach: {tenSach}");
           
            Console.WriteLine($"ma sach: {maSach}");
           
            Console.WriteLine($"tac gia: {tacGia}");
          
            Console.WriteLine($"so luong: {soLuong}");
        }

        public string namebook
        {
            get
            {
                return this.tenSach;
            }
            
        }
        
        public int soluong
        {
            get
            {
                return this.soLuong;
            }
        }

        
    }
}
