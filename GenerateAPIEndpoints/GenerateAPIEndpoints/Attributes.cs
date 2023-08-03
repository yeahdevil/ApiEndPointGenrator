using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAPIEndpoints
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class Searchable : System.Attribute
    {
        public int Order { get; set; }
        public Searchable(int order)
        {
            this.Order = order;
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class Key : System.Attribute
    {
       // public int Order { get; set; }
        public Key()
        {
            //this.Order = order;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class Table : System.Attribute
    {
        public string Name { get; set; }    
        public Table(string name)
        {
            this.Name = name;
        }
    }
}
