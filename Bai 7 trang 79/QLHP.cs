using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7_trang_79
{
    internal class QLHP
    {
        private Hocphan[] Hp;
        private int soLuongHP;

        public void themHP()
        {
            Console.Write("Nhap so luong hoc phan: ");
            soLuongHP = int.Parse(Console.ReadLine());
            Hp = new Hocphan[soLuongHP];
            for (int i = 0; i < soLuongHP; i++)
            {
                Hp[i] = new Hocphan();
                Hp[i].Nhap();
            }
        }

        public void kiemTraQuaMon()
        {
            for (int i = 0;i < soLuongHP; i++)
            {
                if (Hp[i].Truot())
                {
                    Console.WriteLine($"Ban da truot mon {Hp[i].tenhp} ");
                }
                else
                {
                    Console.WriteLine($"Ban da qua mon {Hp[i].tenhp}");
                }
            }
        }

        public void hienThiThongTin()
        {
            for(int i = 0; i < soLuongHP; i++)
            {
                Hp[i].Hien();
            }
        }
    }
}
