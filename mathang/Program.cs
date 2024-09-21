using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLMH qLMH = new QLMH();
            qLMH.themHang();
            qLMH.HienThi();
            qLMH.tinhTongTien();
            Console.ReadKey();
        }
    }
}
