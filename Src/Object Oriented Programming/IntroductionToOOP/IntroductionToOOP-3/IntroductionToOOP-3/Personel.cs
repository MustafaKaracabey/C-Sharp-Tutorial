using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToOOP_3
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public int PersonelBirthDay { get; set; }
        public int Salary { get; set; }
        public int NewSalary { get; set; }
        public int Age { get; set; }
        public Manager Manager { get; set; }    



        public void CalculateAge()
        {
            this.Age = DateTime.Now.Year - PersonelBirthDay ;
        }

        public void CalculateSalary()
        {
            if(this.Age > 20)
            {
                this.NewSalary = (this.Manager.ManagerPoint * this.Age) + (this.Salary);
            }
        }

        public static void ShowPersonelInformation(Personel[] personels)
        {
            foreach (var personel in personels)
            {
                if(personel.NewSalary > personel.Salary)
                {
                    Console.WriteLine($"{personel.PersonelName} old Salary is : {personel.Salary} and {personel.PersonelName} new Salary is : {personel.NewSalary}\n{personel.PersonelName} salary inreased by {personel.Manager.ManagerName} and Amount is {personel.NewSalary - personel.Salary}");
                }
            }
        }
    }
}
