using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLib.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }    
        public List<Address> AddressList { get; set; } = new List<Address>();
        public List<Email> EmailList { get; set; } = new List<Email> ();

    }
}
