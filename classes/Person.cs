using System.Linq;

namespace Bechmark.classes
{
    public class Person
    {
      
        public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        
        public string name{get;}
        public string lastname{get;}
    }
}