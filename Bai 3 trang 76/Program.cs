using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_trang_76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV ql = new QLSV();
            ql.themSV();
            ql.tinhDiemTrungBinh();
            ql.hienThiThongTin();
            Console.ReadKey();
        }
    }
}
