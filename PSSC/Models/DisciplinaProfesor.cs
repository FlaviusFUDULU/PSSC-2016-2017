using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    class DisciplinaProfesor:Disciplina
    {
        public List<StudentProfesor> student { get; internal set; }
        public DisciplinaProfesor(/*name and identifier*/):base(/*name and ideintifier*/)
        {
            //constructor
        }

        public void setRate(/*rate*/)
        {
            //set rate to 1/2 1/3 or whatever 
        }

        public bool _isMyStudent(StudentProfesor studen)
        {
            //search for student
            return false; //this is just for the error
        }
        
        public bool tryAddStudent(StudentProfesor studen)
        {
            //search and try add and return
            return false; //this is just for the error
        }

        public bool tryRemoveStudent(StudentProfesor studen)
        {
            //search and try remove and return
            return false; //this is just for the error
        }

        public bool trySetGrade(StudentProfesor studen)
        {
            //search and try add grade and return
            return false; //this is just for the error
        }
    }
}
