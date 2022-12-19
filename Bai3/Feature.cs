using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Feature
    {
        private List<Student> student;
        public Feature()
        {
            this.student = new List<Student>();
        }
        public void Nhap()
        {
            Student ds= new Student();
            Console.WriteLine("Moi nhap id : ");
            ds.id = Console.ReadLine();
            Console.WriteLine("Moi nhap ten : ");
            ds.name = Console.ReadLine();
            Console.WriteLine("Moi nhap tuoi : ");
            ds.age = Console.ReadLine();
            Console.WriteLine("Moi nhap dia chi : ");
            ds.address = Console.ReadLine();
            Console.WriteLine("Moi nhap diem gpa : ");
            ds.gpa = float.Parse(Console.ReadLine());
            student.Add(ds);
            hienThi();
        }
        public void Sua()
        {
            string id1;
            Console.WriteLine("Moi nhap vao id : ");
            id1 = Console.ReadLine();
            var mark = (from stu in student where stu.id == id1 select stu).First();
            Console.WriteLine("Moi nhap id : ");
            mark.id = Console.ReadLine();
            Console.WriteLine("Moi nhap ten : ");
            mark.name = Console.ReadLine();
            Console.WriteLine("Moi nhap tuoi : ");
            mark.age = Console.ReadLine();
            Console.WriteLine("Moi nhap dia chi : ");
            mark.address = Console.ReadLine();
            Console.WriteLine("Moi nhap diem gpa : ");
            mark.gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach sau khi sua la: ");
            hienThi();
        }
        public void Xoa()
        {
            string id1;
            Console.WriteLine("Moi nhap vao id : ");
            id1 = Console.ReadLine();
            var mark = (from stu in student where stu.id == id1 select stu).First();
            student.Remove(mark);
            Console.WriteLine("Danh sach sau khi xoa : ");
            hienThi();
        }
        public void SortByGPA()
        {
            
            var mark = from stu in student orderby stu.gpa descending select stu;
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in mark)
            {
                Console.WriteLine($"{item.id} {item.name,20} {item.age,20} {item.address,20} {item.gpa,20}");

            }
        }
        public void SortByName()
        {
           
            var mark = from stu in student orderby stu.name descending select stu;
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in mark)
            {
                Console.WriteLine($"{item.id} {item.name,20} {item.age,20} {item.address,20} {item.gpa,20}");

            }
        }
        public void hienThi()
        {
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in student)
            {
                Console.WriteLine($"{item.id} {item.name,20} {item.age,20} {item.address,20} {item.gpa,20}");

            }
        }
    }
}
