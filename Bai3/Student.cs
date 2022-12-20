using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public float Gpa { get; set; }
        public Student() { }
        public Student(string id, string name, string age, string address, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Gpa = gpa;
        }
        public void Nhap(List<Student> students)
        {
            Console.WriteLine("Moi nhap id : ");
            this.Id = Console.ReadLine();
            Console.WriteLine("Moi nhap ten : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Moi nhap tuoi : ");
            this.Age = Console.ReadLine();
            Console.WriteLine("Moi nhap dia chi : ");
            this.Address = Console.ReadLine();
            Console.WriteLine("Moi nhap diem gpa : ");
            this.Gpa = float.Parse(Console.ReadLine());
            students.Add(this);
            hienThi(students);
        }
        public void Sua(List<Student> students)
        {
            string Id1;
            Console.WriteLine("Moi nhap vao id : ");
            Id1 = Console.ReadLine();
            var mark = (from stu in students where stu.Id == Id1 select stu).First();
            Console.WriteLine("Moi nhap id : ");
            mark.Id = Console.ReadLine();
            Console.WriteLine("Moi nhap ten : ");
            mark.Name = Console.ReadLine();
            Console.WriteLine("Moi nhap tuoi : ");
            mark.Age = Console.ReadLine();
            Console.WriteLine("Moi nhap dia chi : ");
            mark.Address = Console.ReadLine();
            Console.WriteLine("Moi nhap diem gpa : ");
            mark.Gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach sau khi sua la: ");
            hienThi(students);
        }
        public void Xoa(List<Student> students)
        {
            string Id1;
            Console.WriteLine("Moi nhap vao id : ");
            Id1 = Console.ReadLine();
            var mark = (from stu in students where stu.Id == Id1 select stu).First();
            students.Remove(mark);
            Console.WriteLine("Danh sach sau khi xoa : ");
            hienThi(students);
        }
        public void SortByGPA(List<Student> students)
        {

            var mark = from stu in students orderby stu.Gpa descending select stu;
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in mark)
            {
                Console.WriteLine($"{item.Id} {item.Name,20} {item.Age,20} {item.Address,20} {item.Gpa,20}");

            }
        }
        public void SortByName(List<Student> students)
        {

            var mark = from stu in students orderby stu.Name descending select stu;
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in mark)
            {
                Console.WriteLine($"{item.Id} {item.Name,20} {item.Age,20} {item.Address,20} {item.Gpa,20}");

            }
        }
        public void hienThi(List<Student> students)
        {
            Console.WriteLine($"{"ID"} {"Name",20} {"Age",20} {"Address",20} {"GPA",20}");
            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Id} {item.Name,20} {item.Age,20} {item.Address,20} {item.Gpa,20}");

            }
        }
    }
}
