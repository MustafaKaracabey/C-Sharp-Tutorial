using System;

namespace IntroductionToOOP_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager ayhan = new Manager()
            {
                ManagerId = 1,
                ManagerName = "Ayhan",
                ManagerSurname = "Karacabey",
                ManagerPoint = 100
            };

            Manager ahmet = new Manager()
            {
                ManagerId = 2,
                ManagerName = "Ahmet",
                ManagerSurname = "Karacabey",
                ManagerPoint = 200
            };



            
            Personel mustafa = new Personel()
            {
                PersonelId = 1,
                Salary = 3000,
                PersonelName = "Mustafa",
                PersonelSurname = "Karacabey",
                PersonelBirthDay = 1999,
                Manager = ayhan
            };

            mustafa.CalculateAge();
            mustafa.CalculateSalary();

            Personel kadir = new Personel()
            {
                PersonelId = 2,
                Salary = 4000,
                PersonelName = "Kadir",
                PersonelSurname = "Karacabey",
                PersonelBirthDay = 2006,
                Manager = ahmet
            };

            kadir.CalculateAge();
            kadir.CalculateSalary();

            Personel zeynep = new Personel()
            {
                PersonelId = 3,
                Salary = 5000,
                PersonelName = "Zeynep",
                PersonelSurname = "Karacabey",
                PersonelBirthDay = 2005,
                Manager = ayhan
            };

            zeynep.CalculateAge();
            zeynep.CalculateSalary();

            Personel [] personels = { mustafa, kadir, zeynep };

            Personel.ShowPersonelInformation(personels);
        }
    }
}
