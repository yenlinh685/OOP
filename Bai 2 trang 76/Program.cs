using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_trang_76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLTV ql = new QLTV();
            ql.themSach();
            ql.hienThiThongTin();
            ql.kiemTraSoLuong();
            Console.ReadKey();
        }
    }
}
