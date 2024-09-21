using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_trang_77
{
    internal class QLSP
    {
        private Sanpham[] Sp;
        private int soLuongSP;

        public void themSP()
        {
            Console.Write("Nhap so luong san pham: ");
            soLuongSP = int.Parse(Console.ReadLine());
            Sp = new Sanpham[soLuongSP];
            for (int i = 0; i < Sp.Length; i++)
            {
                Sp[i] = new Sanpham();
                Sp[i].Nhap();
            }
        }

        public void kiemTraSanPham()
        {
            for (int i = 0;i < Sp.Length;i++)
            {
                if (Sp[i].hetHang())
                {
                    Console.WriteLine($"San pham {Sp[i].tensp} het hang, vui long nhap them");
                }
                else
                {
                    Console.WriteLine($"San pham {Sp[i].tensp} van con hang ton kho");
                }
            }
        }

        public void hienThiThongTin()
        {
            for(int i = 0;i<Sp.Length ; i++)
            {
                Sp [i].hienThi();
            }
        }
    }
}
