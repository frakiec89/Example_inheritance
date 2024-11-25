namespace Example_inheritance
{
    public class StudentServiceBase
    {
        public Student Student { get; set; }
        public StudentServiceBase()
        {
            Student = new Student() { Name = "Test", Id = 1 };
        }

        public virtual void Response()
        {
            Console.WriteLine(Student.Response());
        }
    }

    public class StudentConsole : StudentServiceBase
    {
        public override void Response()
        {
            base.Response();
        }
    }

    public class StudentText : StudentServiceBase
    {
        public override void Response()
        {
            Console.WriteLine("Файл сохранен в \"test.txt\"");
            File.WriteAllText("test.txt", Student.Response());
        }
    }

}
