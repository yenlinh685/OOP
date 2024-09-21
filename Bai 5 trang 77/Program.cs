using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_trang_77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSP qLSP = new QLSP();
            qLSP.themSP();
            qLSP.kiemTraSanPham();
            qLSP.hienThiThongTin();
            Console.ReadKey();
        }
    }
}
