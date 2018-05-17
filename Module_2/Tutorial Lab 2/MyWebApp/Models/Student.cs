public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }    
    public DateTime Birthday { get; set; }
    public bool RegisterCourse(int courseID)
    {
        // business logic here
        return true;
    }
}