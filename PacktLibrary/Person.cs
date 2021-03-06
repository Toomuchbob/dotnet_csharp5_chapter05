using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public partial class Person : object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person() {
            // set default values for fields
            // including readonly fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        

    }
}
