using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Models
{
    public class Employee:BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
