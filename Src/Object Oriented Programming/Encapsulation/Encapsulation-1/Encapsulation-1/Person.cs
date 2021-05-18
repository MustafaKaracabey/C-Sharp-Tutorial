using System;

namespace Encapsulation_1
{
    public class Person
    { //Encapsulation Provides us to Safety.
        private DateTime _birthdate;


        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthday()
        {
            return _birthdate;
        }
        
    }
}