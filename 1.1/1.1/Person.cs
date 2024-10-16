namespace _1._1
{
    internal class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            Name = name;

        }

        public string Introduction()
        {
            return $"hi i am {Name} and i am {age} years old";
        }
    }
}
