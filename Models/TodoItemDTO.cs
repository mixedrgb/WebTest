using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class TodoItemDTO
    {
        public long id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}