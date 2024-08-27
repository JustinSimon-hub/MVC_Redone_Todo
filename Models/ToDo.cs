using System;

namespace Testing.Models
{
    public class ToDo
    {
        //mapping to domain model
        
        public int Id { get; set; }
    
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Desription { get; set; }

    }
}