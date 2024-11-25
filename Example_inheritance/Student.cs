
namespace Example_inheritance
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Response()
        {
            Console.WriteLine($"Привет меня зовут {Name}  я студент");
        }

        public void ResponseText()
        {
            File.WriteAllText( "test.txt", $"Привет меня зовут {Name}  я студент");
        }


    }
}
