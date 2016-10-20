using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student:StudentID
    {
        public List<DisciplinaStudent> disciplina { get; internal set; }
        public Student(/*dates+identifier*/):base(/*identifier*/)
        {
            //constructor
        }

        public void showDisciplines(DisciplinaStudent disc)
        {
            //show all disciplines for student
        }
    }
}
