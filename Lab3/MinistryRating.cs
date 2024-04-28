using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MinistryRating
    {
        List<University> universities; // список університетів
        Dictionary<string, List<int>> universitiesGrades; // назва університету, список оцінок
        Dictionary<string, double> universitiesAvgGrade; // назва університету, середній бал

        public MinistryRating()
        {
            universities = new List<University>();
            universitiesGrades = new Dictionary<string, List<int>>();
            universitiesAvgGrade = new Dictionary<string, double>();
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

            foreach (var university in universitiesGrades)
            {
                double avgGrade = university.Value.Average();
                universitiesAvgGrade.Add(university.Key, avgGrade);
            }

            universitiesAvgGrade = universitiesAvgGrade.OrderBy(x => x.Value).ToDictionary();

            return universitiesAvgGrade;
        }
    }
}
