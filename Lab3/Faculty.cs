using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Faculty
    {
        private string name; //назва факультету
        private int numberDepartment; //кількість кафедр
        private int numberSpeciality; //кількість спеціальностей
        private int numberStudent; //кількість студентів

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int NumberDepartment
        {
            get
            {
                return numberDepartment;
            }
            set
            {
                numberDepartment = value;
            }
        }

        public int NumberSpecials
        {
            get
            {
                return numberSpeciality;
            }
            set
            {
                numberSpeciality = value;
            }
        }
        public int NumberStudent
        {
            get
            {
                return numberStudent;
            }
            set
            {
                numberStudent = value;
            }
        }

        public Faculty()
        {
            name = string.Empty;
            numberDepartment = 0;
            numberSpeciality = 0;
            numberStudent = 0;
        }

        public Faculty(string name, int numberDepartment, int numberSpeciality, int numberStudent)
        {
            this.name = name;
            this.numberDepartment = numberDepartment;
            this.numberSpeciality = numberSpeciality;
            this.numberStudent = numberStudent;
        }

       
    }
}
