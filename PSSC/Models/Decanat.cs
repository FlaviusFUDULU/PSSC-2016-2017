using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        
        public List<Profesor> profesor { get; internal set; }

        public List<Student> student { get; internal set; }

        public bool _isProfesor(Profesor profeso)
        {
            //your code herereturn true or false;
            return false; //this is just for the error 
        }

        public bool tryAddProfesor(Profesor profeso)
        {
            //find and add profesor and return if succes
            return false; //this is just for the error 
        }

        public bool tryRemoveProfesor(Profesor profeso)
        {
            //find and remove profesor and return if succes
            return false; //this is just for the error 
        }

        public bool _isStudent(Student studen)
        {
            //your code here, return true or false;
            return false; //this is just for the error 
        }

        public bool tryAddStudent(Student studen)
        {
            //find and add student and return if succes
            return false; //this is just for the error 
        }

        public bool tryRemovedStudent(Student studen)
        {
            //find and remove student and return if succes
            return false; //this is just for the error 
        }
    }
}
