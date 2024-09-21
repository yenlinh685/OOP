using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Trang78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QLMH quanLyMatHang = new QLMH();

            quanLyMatHang.Nhap();
            quanLyMatHang.HienThiThongTin();
            quanLyMatHang.TinhTongTien();

            Console.ReadKey();
        }
    }
}
