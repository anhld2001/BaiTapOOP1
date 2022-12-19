using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Candidate
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int math { get; set; }
        public int lit { get; set; }
        public int eng { get; set; }

        public Candidate() { }
        public Candidate(string id, string name, string date, int math, int lit, int eng)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.math = math;
            this.lit = lit;
            this.eng = eng;
        }
        
    }
}
