using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7_trang_79
{
    internal class Hocphan
    {
        private string tenHP, maHP;
        private double soTinChi, diemThi;

        public Hocphan()
        {
            this.tenHP = "";
            this.maHP = "";
            this.soTinChi = 0;
            this.diemThi = 0;
        }

        public Hocphan(string tenHP, string maHP, double soTinChi, double diemThi)
        {
            this.tenHP = tenHP;
            this.maHP = maHP;
            this.soTinChi = soTinChi;
            this.diemThi = diemThi;
        }


        public Hocphan(Hocphan hp)
        {
            this.tenHP = hp.tenHP;
            this.maHP = hp.maHP;
            this.soTinChi = hp.soTinChi;
            this.diemThi = hp.diemThi;
        }


        public bool Truot()
        {
            if (diemThi < 5)
            {
                return true;
            }
            return false;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten hoc phan: ");
            tenHP = Console.ReadLine();
            Console.Write("Nhap ma hoc phan: ");
            maHP = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            soTinChi = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi: ");
            diemThi = double.Parse(Console.ReadLine());

        }


        public void Hien()
        {
            Console.WriteLine($"Ten hoc phan: {tenHP}");
            Console.WriteLine($"Ma hoc phan: {maHP}");
            Console.WriteLine($"So tin chi: {soTinChi}");
            Console.WriteLine($"Diem thi: {diemThi}");
        }

        public string tenhp
        {
            get
            {
                return this.tenHP;
            }
        }
    }
}
