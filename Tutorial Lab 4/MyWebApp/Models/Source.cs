using System.Collections.Generic;

namespace MyWebApp.Models 
{
    // film domain model
    public class Film 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
    }

    // data transfer object
    public class CreateOrUpdateDTO 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
        public Operation Operation { get; set; }
    }

    // genre enum mapping
    public enum Genre 
    {
        Action,
        Adventure,
        Comedy,
        Drama,
        War
    }

    // operation enum mapping
    public enum Operation 
     {
        Create,
        Update,
        Delete
    }
}