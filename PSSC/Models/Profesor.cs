using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        public List<DisciplinaProfesor> disciplina { get; internal set; }

        public Profesor(/*variables*/)
        {
            //constructor
        }

        public bool tryAddDiscipline(/**/)
        {
            return false //just for error
        }

        public bool tryRemoveDiscipline(/**/)
        {
            return false //just for error
        }
    }
}
