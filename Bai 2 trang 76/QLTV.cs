using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_trang_76
{
    internal class QLTV
    {
        private Book[] books;
        private int soSach;

        public void themSach()
        {
            Console.WriteLine("Nhap vao so luong sach: ");
            soSach = int.Parse(Console.ReadLine());
            books = new Book[soSach];
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
                books[i].nhap();

            }
        }

        public void hienThiThongTin()
        {
            for (int i = 0;i < books.Length;i++)
            {
                books[i].hien();
            }
        }

        public void kiemTraSoLuong()
        {
            for(int i = 0; i< books.Length;i++)
            {
                Console.WriteLine($"Sach {books[i].namebook} co so luong la: {books[i].soluong}");
            }
        }
  
    }
}
