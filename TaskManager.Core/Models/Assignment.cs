using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Models
{
    public class Assignment:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
