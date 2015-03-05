using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUniversity.Models
{
    public class GroupStudents
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}