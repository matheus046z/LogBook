using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.VO
{
    public class Student
    {
        // Classe é um conjunto de objetos
        private int id { get; set; } //set atribui e get recupera
        private string studentName { get; set; }
        private string miniCurriculum { get; set; }
        private string hobby { get; set; }
        private string ar { get; set; }
        private string classCode { get; set; }
        
        public void setId(int id)
        {
            this .id = id;
        }
        public int GetId()
        {
            return this .id;
        }

    }
}
