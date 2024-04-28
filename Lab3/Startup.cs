using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Startup
    {
        string name; //назва стартапу 
        List<string> namesStudents; // список імен студентів
        double finance; // кількість фінансів виділених на стартап
        Dictionary<string, double> ratingStudents; // студент, вклад

        public Startup(string name, List<string> namesStudents, double finance)
        {
            this.name = name;
            namesStudents = new List<string>();
            this.namesStudents = namesStudents;
            this.finance = finance;
            ratingStudents = new Dictionary<string, double>();

            CalculateRatingStudents();
        }

        public string Name
        {
            get
            {
                return name;
            }
        }


        private void CalculateRatingStudents()
        {
            Random random = new Random();

            foreach(string student in namesStudents)
            {
                double value = random.NextDouble();
                value = value * finance;
                ratingStudents.Add(student, value);
            }
        }

        public Dictionary<string, double> GetRatingStudents()
        {
            return ratingStudents;
        }

        public KeyValuePair<string, double> GetTheBestStudentAndHisValue()
        {
            return ratingStudents.OrderByDescending(student => student.Value).First();
        }

    }
}
