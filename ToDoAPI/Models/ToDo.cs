using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Models
{
    //ToDo Models
    public class ToDo
    {
        //Variable class ToDo as variables on database
        public int ToDoID { get; set; }
        public DateTime DTToDo { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string percent { get; set; }
        public string mark { get; set; }
    }
}
