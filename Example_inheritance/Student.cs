
namespace Example_inheritance
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Response ()
        {
            return $"Привет меня зовут {Name}  я студент";
        }
    }
}
