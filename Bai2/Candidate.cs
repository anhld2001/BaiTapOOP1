using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Math { get; set; }
        public int Lit { get; set; }
        public int Eng { get; set; }

        public Candidate() { }
        public Candidate(string Id, string Name, string Date, int Math, int Lit, int Eng)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
            this.Math = Math;
            this.Lit = Lit;
            this.Eng = Eng;
        }
        
    }
}
