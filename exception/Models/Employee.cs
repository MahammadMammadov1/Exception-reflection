using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception.Models
{
    public class Employee
    {
        public int Id { get; set; }
        private static int _id;
        
        private int _salary;


        static Employee()
        {
            _id = 0;
        }


        public Employee(string fullname ,string departmentNo , byte age ,byte experience, int salary)
        {
            _id++;
            Id = _id;
            _salary = salary;
            FullName = fullname;
            DepartmentNo = departmentNo;
            Age = age;
            Experience = experience;
        }


        private string _fullname;
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                string trimmedValue = value.Trim();
                string[] fullName = trimmedValue.Split(' ');

                if (fullName.Length == 2)
                {
                    _fullname = trimmedValue;
                }
                else
                {
                    throw new InvalidFullNameException("fullname ad + boşluq + soyad şəklində olmalıdır.");
                }
            }
        }

        private string _departmentNo;

        public string DepartmentNo
        {
            get 
            { 
                return _departmentNo;
            }
            set
            {
                if (value.Length == 2 && char.IsUpper(value[0]) && char.IsUpper(value[1]) && !char.IsDigit(value[0]) && !char.IsDigit(value[1]))
                {
                    _departmentNo = value;
                }
                else
                {
                    throw new InvalidDepartmentN0Exception("departmentNo 2 boyuk  herfden ibaret olmalıdır.");
                }
            }

        }


        private byte _age;

        public byte Age
        {
            get {
                return _age;
            }
            set 
            {
                if (value < 0 || value > 150)
                {
                    throw new InvalidAgeException("yash 0 ile 150 arasinda olmalidir");
                }

                else
                {
                    _age = value;
                }

            }
        }

        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set
            {

                if (value >= 0 && value <= 60 && _age - value >= 18)
                {
                    _experience = value;
                }
                else
                {
                    throw new InvalidExperienceException("experience 0-dan kiçik ve age - experience < 18 ola bilmez.");
                }
            }
        }








    }
}
