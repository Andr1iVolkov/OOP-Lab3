using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class University
    {
        private string name; //назва університету
        private Address address; // адреса університету
        List<Faculty> faculties; //список факультетів
        private int numberSpecials; // кількість спеціальностей
        private int numberStudents; // кількість студентів за всіма спеціальностями 

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

        public Address Address
        {
            get
            {
                return address;
            }
        }

        public List<Faculty> Faculties
        {
            get
            {
                return faculties;
            }
        }

        public int NumberSpecials
        {
            get
            {
                return numberSpecials;
            }
            set
            {
                numberSpecials = value;
            }
        }

        public int NumberStudents
        {
            get
            {
                return numberStudents;
            }
            set
            {
                numberStudents = value;
            }
        }

        public University()
        {
            name = string.Empty;
            address = new Address();
            faculties = new List<Faculty>();
            numberStudents = 0;
            numberSpecials = 0;
        }

        public University(string name, Address address, int numberSpecials, int numberStudents)
        {
            this.name = name;
            this.address = address;
            faculties = new List<Faculty>();
            this.numberSpecials = numberSpecials;
            this.numberStudents = numberStudents;
        }

        public University(string name, Address address, Faculty faculty, int numberSpecials, int numberStudents)
        {
            this.name = name;
            this.address = address;
            faculties = new List<Faculty>();
            faculties.Add(faculty);
            this.numberSpecials = numberSpecials;
            this.numberStudents = numberStudents;
        }

        public University(string name, Address address, List<Faculty> faculty, int numberSpecials, int numberStudents)
        {
            this.name = name;
            this.address = address;
            faculties = new List<Faculty>(); 
            faculties = faculty;
            this.numberSpecials = numberSpecials;
            this.numberStudents = numberStudents;
        }

    }
}
