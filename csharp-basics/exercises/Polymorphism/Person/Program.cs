namespace Person;
class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee(1, "John", "Elmo", "Holeywood", "Accountant");
        var student = new Student(1, "Peter", "Parker", "NY", 4.56);
        employee.Display();
        student.Display();
    }
}