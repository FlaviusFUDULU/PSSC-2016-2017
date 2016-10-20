using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //variables
    class DisciplinaStudent:Disciplina
    {
        public DisciplinaStudent(/*disc name and identifier*/):base(/*disc name and identifier*/)
        {
            //constructor
        }

        public void showGrades()
        {
            //print grades
        }

        public float getFinalGradeForDiscipline()
        {
            //calculate finalgrade
            return 10; //just for the error
        }
    }
}
