
namespace Example_inheritance
{
    public class StudentConsole
    {
        public Student Student { get; set; }
        public StudentConsole()
        {
            Student = new Student() { Name = "Test", Id = 1 };
        }

        public void ResponseToConsole()
        {
            Student.Response();
        }

        public void ResponseToText()
        {
            Console.WriteLine("Файл сохранен в \"test.txt\"");
            Student.ResponseText();
        }

    }
}
