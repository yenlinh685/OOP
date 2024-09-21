using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_trang_76
{
    internal class QLSV
    {
        private SinhVien[] sv;
        private int soLuongSV;
        

        public void themSV()
        {
            Console.Write("Nhap so luong sinh vien: ");
            soLuongSV = int.Parse(Console.ReadLine());
            sv = new SinhVien[soLuongSV];
            for (int i = 0; i < sv.Length; i++)
            {
                sv[i] = new SinhVien();
                sv[i].Nhap();
            }
        }
        public void tinhDiemTrungBinh()
        {
           for (int i = 0;i < sv.Length;i++)
            {
                double diemTB = (sv[i].diemtoan + sv[i].diemvan) / 2;
                Console.WriteLine($"Diem trung binh cua sinh vien {sv[i].hoten} la: {diemTB}");
            }
        }


        public void hienThiThongTin()
        {
            for (int i = 0; i < sv.Length; i++)
            {
                sv[i].Hien();
            }
        }
    }
}
