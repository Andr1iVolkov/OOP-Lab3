using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Faculty
    {
        private string name; // назва факультету
        private int numberDepartment; // кількість кафедр
        private int numberSpeciality; // кількість спеціальностей
        private int numberStudent; // кількість студентів

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

        public class StartupIncubator
        {
            List<Startup> startups; //список стартапів
            Dictionary<string, List<int>> startupsGrades; // стартап, бали 
            Dictionary<string, double> bestStudents; // студент, бал - найкращі студенти з кожного стартапу

            public StartupIncubator()
            {
                startups = new List<Startup>();
                startupsGrades = new Dictionary<string, List<int>>();
                bestStudents = new Dictionary<string, double>();

                CalculateStartupsGrades();
            }

            public void AddStartup(string namesStartups, List<string> studentsNames, double finance)
            {
                Startup startup = new Startup(namesStartups, studentsNames, finance);
                startups.Add(startup);
            }

            private void CalculateStartupsGrades()
            {
                const int numberExperts = 5;
                Random random = new Random();

                foreach (var startup in startups)
                {
                    List<int> grades = new List<int>();
                    for(int i = 0; i < numberExperts; i++)
                    {
                        grades.Add(random.Next(10) + 1);
                    }
                    startupsGrades.Add(startup.Name, grades);
                }
            }

            public string GetTheBestStartup()
            {
                return startupsGrades.OrderByDescending(x => x.Value.Average()).First().Key;
            }

            public string GetTheBestStudent()
            {
                bestStudents.Clear();
                foreach(var startup in startups)
                {
                    bestStudents.Add(startup.GetTheBestStudentAndHisValue().Key, startup.GetTheBestStudentAndHisValue().Value);
                }

                return bestStudents.OrderByDescending(x => x.Value).First().Key;
            }
        }



    }
}
