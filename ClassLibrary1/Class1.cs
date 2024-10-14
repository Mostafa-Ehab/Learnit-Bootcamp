namespace ClassLibrary1
{
    public class Student
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }

        public Student(string id, string name, int age) {
            Id = id;
            Name = name;
            Age = age;
        }

        public string getStudent()
        {
            return $"{Id} : {Name} ({Age})";
        }
    }
}
