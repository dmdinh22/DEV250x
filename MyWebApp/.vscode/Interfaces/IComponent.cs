using System.Collections.Generic;

public interface IComponent 
{
    int ID { get; set; }
    string Name { get; set; }
    IComponent Parent { get; set; }
    ICollection<IComponent> Children {get; set; }
}