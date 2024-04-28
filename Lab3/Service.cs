using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Service
    {
        public void Print(University university)
        {
            Console.WriteLine("Університет");
            Console.WriteLine("Назва - " +  university.Name);
            Console.WriteLine("Адреса - \n" + university.Address.ToString());
            Console.WriteLine("Факультети: ");
            university.Faculties.ForEach(f => Print(f));
            Console.WriteLine("Кількість спеціальностей - " + university.NumberSpecials);
            Console.WriteLine("Кількість студентів - " + university.NumberStudents);
        }

        public void Print(Faculty faculty)
        {
            Console.WriteLine("Факультет:");
            Console.WriteLine("Назва - " + faculty.Name);
            Console.WriteLine("Кількість кафедр" + faculty.NumberDepartment);
            Console.WriteLine("Кількість спеціальностей" + faculty.NumberSpecials);
            Console.WriteLine("Кількість студентів - " + faculty.NumberStudent);
        }

        public void Print(List<University> universities)
        {
            universities.ForEach(f => Print(f));
        }

        public void Print(List<Faculty> faculties)
        {
            faculties.ForEach(f => Print(f));
        }

        public void AddToFile(University university, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Університет");
                sw.WriteLine("Назва - " + university.Name);
                sw.WriteLine("Адреса: \n" + university.Address.ToString());
                sw.WriteLine("Факультети:");
                university.Faculties.ForEach(f => AddToFile(f, path));
                sw.WriteLine("Кількість спеціальностей - " + university.NumberSpecials);
                sw.WriteLine("Кількість студентів - " + university.NumberStudents);
            }
        }

        public void AddToFile(Faculty faculty, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Факультет");
                sw.WriteLine("Назва - " + faculty.Name);
                sw.WriteLine("Кількість кафедр - " + faculty.NumberDepartment);
                sw.WriteLine("Кількість спеціальностей - " + faculty.NumberSpecials);
                sw.WriteLine("Кількість студентів - " + faculty.NumberStudent);
            }
        }

        public void AddToFile(List<University> universities, string path)
        {
            universities.ForEach(u => AddToFile(u, path));
        }

        public void AddToFile(List<Faculty> faculties, string path)
        {
            faculties.ForEach(f => AddToFile(f, path));
        }

    }
}
