namespace PropertiesAndFields
{
    public class Person
    {
        private int _age; //This is filed
        
        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public string Name  { get; set; } //This is properties which it will create like _age field for us under the hood
    }
}