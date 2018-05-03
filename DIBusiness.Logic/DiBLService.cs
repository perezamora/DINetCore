using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DICommon.Logic.Model;

namespace DIBusiness.Logic
{
    public class DiBLService : IDiBLService
    {
        public List<Student> GetAll()
        {
            List<Student> lstudents = new List<Student>();
            Student s1 = new Student
            {
                Id = 1,
                Name = "Peter",
                SurName = "Parker"
            };

            Student s2 = new Student
            {
                Id = 1,
                Name = "Cascarilla",
                SurName = "Ruidoso"
            };

            lstudents.Add(s1);
            lstudents.Add(s2);

            return lstudents;
        }
    }
}
