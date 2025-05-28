using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    using -> add a namespace into file

    - System -> basic class as [Console, String, DateTime]
    - System.Collections.Generic -> contain generic collections as List<T>, Dictionary<Tkey, Tvaleu>
    - System.Ling -> add LINQ (Language Integrated Query) to manipulate collections as [.Where(), .Select()]
    - System.Threading.Tasks -> gives suport to asynchronous programin [Task, async, await]
*/

//define the Person class as a member of the namespace dotNet.Models (dotNet is the name of folder where this project was created)
namespace dotNet.Models
{
    //'public' keyword in the class set it 'Access Modifiers', relates with the assembly step (.dll, .exe)
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

    //@ is force to use reserved keyword to be another thing as @pbulic
        public void SayHello(string @public)
        {
            Console.WriteLine($"Hello {Name}");
        }
    }
}