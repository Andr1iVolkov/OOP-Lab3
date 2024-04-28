using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MinistryFinance
    {
        List<University> universities; // список університетів
        Dictionary<string, double> financeUniversities; // назва університету, сума фінансів на рік

        public MinistryFinance(List<University> universities, Dictionary<string, double> universityAvgGrades)
        {
            universities = new List<University>();
            this.universities = universities;
            financeUniversities = new Dictionary<string, double>();
        }

        public Dictionary<string, double> CalculateFinanceForUniversities(Dictionary<string, double> universitiesAvgGrades)
        {
            financeUniversities.Clear();

            int[] financeForOneStudent = { 6000, 4500, 3500, 2000 };

            int place = 1;

            foreach (var item in universitiesAvgGrades)
            {
                double financeUniversity = 0;
                University university = universities.Find(u => u.Equals(item.Key));
                if (place < 10)
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
