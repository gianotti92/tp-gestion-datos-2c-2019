using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Entities
{
    public class Student_Curso
    {
        public long curseId { get; set; }
        public long studentId { get; set; }

        public Student_Curso(long CurseId, long StudentId)
        {
            curseId = CurseId;
            studentId = StudentId;
        }
    }
}
