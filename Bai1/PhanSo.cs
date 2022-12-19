using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        public float tuSo1 { get; set; }
        public float mauSo1 { get; set; }
        public float tuSo2 { get; set; }
        public float mauSo2 { get; set; }
        public PhanSo()
        {
            tuSo1 = this.tuSo1;
            mauSo1= this.mauSo1;
            tuSo2 = this.tuSo2;
            mauSo2= this.mauSo2;
        }
        public float CongPS()
        {
            float kq;
            kq = (mauSo2 * tuSo1 + mauSo1 * tuSo2) / (mauSo1 * mauSo2);
            return kq;
        }
        public float TruPS() 
        {
            float tru;
            tru = (mauSo2 * tuSo1 - mauSo1 * tuSo2) / (mauSo1 * mauSo2);
            return tru;
        }
        public float NhanPS()
        {
            float nhan;
            nhan = (tuSo1 * tuSo2) / (mauSo1 * mauSo2);
            return nhan;
        }
        public float ChiaPS()
        {
            float chia;
            chia = (tuSo1 * mauSo2) / (mauSo1 * tuSo2);
            return chia;
        }
    }
}
