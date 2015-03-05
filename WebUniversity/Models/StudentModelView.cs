﻿using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUniversity.Models
{
    public class StudentModelView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<Group> Groups { get; set; }

        public StudentModelView() { }
        public StudentModelView(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            Age = student.Age;
            GroupId = student.GroupId;
        }
    }
}