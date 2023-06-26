using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YP.Models
{
    public class Enrollee : BaseModel
    {
        private string name;
        private string surname;
        private string? patronymic;
        private string gender;
        private DateTime dateOfBirth;
        private string snils;
        private int age;
        private string address;
        private string gpa;
        private DateTime yearOfAdmission;
        private string education;
        private bool disability;
        private bool ward;

        private string speciality;
        private string citizenship;
        private bool isBudget;
        private bool isEnlisted;

        public Enrollee() { }
        public Enrollee(string name, string surname, string patronymic,
                        string gender, DateTime dateOfBirth, string snils,
                        DateTime yearOfAdmission)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Snils = snils;
            YearOfAdmission = yearOfAdmission;
        }

        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }
        public string Address
        {
            get { return address; }
            set { Set(ref address, value); }
        }
        public string Gpa
        {
            get { return gpa; }
            set { Set(ref gpa, value); }
        }
        public string Surname
        {
            get { return surname; }
            set { Set(ref surname, value); }
        }

        public string? Patronymic
        {
            get { return patronymic; }
            set { Set(ref patronymic, value); }
        }

        public string Gender
        {
            get { return gender; }
            set { Set(ref gender, value); }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { Set(ref dateOfBirth, value); }
        }

        public string Snils
        {
            get { return snils; }
            set { Set(ref snils, value); }
        }

        public int Age
        {
            get { return age; }
            set { Set(ref age, value); }
        }

        public DateTime YearOfAdmission
        {
            get { return yearOfAdmission; }
            set { Set(ref yearOfAdmission, value); }
        }

        public string Education
        {
            get { return education; }
            set { Set(ref education, value); }
        }

        public bool Disability
        {
            get { return disability; }
            set { Set(ref disability, value); }
        }

        

        public bool Ward
        {
            get { return ward; }
            set { Set(ref ward, value); }
        }

        public string Speciality
        {
            get { return speciality; }
            set { Set(ref speciality, value); }
        }

        public string Citizenship
        {
            get { return citizenship; }
            set { Set(ref citizenship, value); }
        }
        public bool IsBudget
        {
            get { return isBudget; }
            set { Set(ref isBudget, value); }
        }

        public bool IsEnlisted
        {
            get { return isEnlisted; }
            set { Set(ref isEnlisted, value); }
        }
    }
}
