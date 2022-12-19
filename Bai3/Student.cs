using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string address { get; set; }
        public float gpa { get; set; }
        public Student() { }
        public Student(string id, string name, string age, string address, float gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }
    }
}
