
using BenchmarkDotNet.Attributes;
using Bechmark.classes;
using Bechmark.structures;

namespace Bechmark.classes
{
    [MemoryDiagnoser]
    public class BechmarkTest
    {
        [Benchmark]
        public void PersonClass()
        {
           for(int i = 0; i <= 100 ; i++)
           {
               classes.Person person = new classes.Person("Marco" + i.ToString(), "Mendez");
           }
        } 

        
        [Benchmark]
        public void PersonStructure()
        {
           for(int i = 0; i <= 100 ; i++)
           {
               structures.Person person = new structures.Person("Marco" + i.ToString(), "Mendez");
           }
        }  
    }
}