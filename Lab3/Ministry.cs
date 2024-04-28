using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Ministry
    {
        List<University> universities; // список університетів
        Dictionary<string, List<int>> universitiesGrades; // назва університету, список оцінок
        Dictionary<string, double> universitiesAvgGrade; // назва університету, середній бал
        Dictionary<string, double> financeUniversities; // назва університету, сума фінансів на рік


        public Ministry()
        {
            universities = new List<University>();
            universitiesGrades = new Dictionary<string, List<int>>();
            universitiesAvgGrade = new Dictionary<string, double>();
            financeUniversities = new Dictionary<string, double>();
        }

        private Dictionary<string, List<int>> GetUniversitiesGrade(List<University> universities)
        {
            int numberOfPlatforms = 3;
            Random random = new Random();

            universitiesGrades.Clear();

            foreach (University university in universities)
            {
                List<int> grades = new List<int>();

                for (int i = 0; i < numberOfPlatforms; i++)
                {
                    grades.Add(random.Next(200));
                }

                universitiesGrades.Add(university.Name, grades);
            }
            return universitiesGrades;
        }

        public Dictionary<string, double> GetUniversitiesAvgGrade(List<University> universities)
        {
            universitiesGrades = GetUniversitiesGrade(universities);

            universitiesAvgGrade.Clear();

            foreach(var university in universitiesGrades)
            {
                double avgGrade = university.Value.Average();
                universitiesAvgGrade.Add(university.Key, avgGrade);
            }

            universitiesAvgGrade = universitiesAvgGrade.OrderBy(x => x.Value).ToDictionary();

            return universitiesAvgGrade;
        }

        public Dictionary<string, double> CalculateFinanceForUniversities()
        {
            financeUniversities.Clear();

            int[] financeForOneStudent = { 6000, 4500, 3500, 2000 };

            int place = 1;
            foreach(var item in universitiesAvgGrade)
            {
                double financeUniversity = 0;
                University university = universities.Find(u => u.Equals(item.Key));
                if(place < 10)
                {
                    financeUniversity = university.NumberStudents * financeForOneStudent[0];
                }
                else if (place < 50)
                {
                    financeUniversity = university.NumberStudents * financeForOneStudent[1];
                }
                else if (place < 100)
                {
                    financeUniversity = university.NumberStudents * financeForOneStudent[2];
                }
                else
                {
                    financeUniversity = university.NumberStudents * financeForOneStudent[3];
                }

                financeUniversities.Add(university.Name, financeUniversity);

                place++;
            }

            return financeUniversities;
        }
    }
}
