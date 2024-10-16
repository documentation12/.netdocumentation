
namespace test
{
    internal class Person
    {
        private int Age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public string printDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
            
    }
}
