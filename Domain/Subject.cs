using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Subject
    {
        public Subject(long id, string name, string code, int espb, Professor professor)
        {
            Id = id;
            Name = name;
            Code = code;
            Espb = espb;
            Professor = professor;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Espb { get; set; }
        public Professor Professor { get; set; }
    }
}
