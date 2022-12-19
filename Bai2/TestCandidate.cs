using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai2
{
    internal class TestCandidate
    {

        private List<Candidate> ds;
        public TestCandidate()
        {

            this.ds = new List<Candidate>();
            
        }

        public void Nhap()
        {
            
            int n;
            do
            {
                Console.WriteLine("Moi nhap so luong sinh vien : ");
                n = int.Parse(Console.ReadLine());
            }while(n <= 0);
            
            for(int i = 0; i< n; i++)
            {
                Candidate can = new Candidate();
                Console.WriteLine("Moi nhap ma sinh vien : ");
                can.id = Console.ReadLine();
                Console.WriteLine("Moi nhap ho ten : ");
                can.name = Console.ReadLine();
                Console.WriteLine("Moi nhap ngay sinh : ");
                can.date = Console.ReadLine();
                Console.WriteLine("Moi nhap diem Toan : ");
                can.math = int.Parse(Console.ReadLine());
                Console.WriteLine("Moi nhap diem Van : ");
                can.lit = int.Parse(Console.ReadLine());
                Console.WriteLine("Moi nhap diem Anh : ");
                can.eng = int.Parse(Console.ReadLine());
                Console.WriteLine("================================");
                ds.Add(can);
            }
        }
        public void search()
        {
            foreach(Candidate item in ds)
            {
                float tb = item.math + item.eng + item.lit;
                if (tb > 1)
                {
                    Console.WriteLine("Ma sinh vien : " + item.id);
                    Console.WriteLine("Ho ten : " + item.name);
                    Console.WriteLine("Ngay sinh : " + item.date);
                    Console.WriteLine("Diem toan : " + item.math);
                    Console.WriteLine("Diem van : " + item.lit);
                    Console.WriteLine("Diem anh : " + item.eng);
                };
            }
            
        }
    }
}
