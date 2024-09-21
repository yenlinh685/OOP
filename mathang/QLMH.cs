using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathang
{
    internal class QLMH
    {
        private MatHang[] mh;
        private int soLuongHH;

        public void themHang()
        {
            Console.Write("Nhap so luong hang hoa: ");
            soLuongHH = int.Parse(Console.ReadLine());  
            mh = new MatHang[soLuongHH];
            for (int i = 0; i < mh.Length; i++)
            {
                mh[i] = new MatHang();
                mh[i].Nhap();
            }
        }
        public void tinhTongTien()
        {
            for (int i = 0;i < mh.Length; i++)
            {
                mh[i].tinhTien();
            }
        }

        public void HienThi()
        {
            for(int i = 0;i< mh.Length ; i++)
            {
                mh[i].hienThi();
            }
        }
    }


}
