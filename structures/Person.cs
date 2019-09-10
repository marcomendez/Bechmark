using System.Linq;

namespace Bechmark.structures
{
    public struct Person
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