
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
            Console.WriteLine("Файл сохранен в \"Example_inheritance\\Example_inheritance\\bin\\Debug\\net8.0\\test.txt\"");
            Student.ResponseText();
        }

    }
}
