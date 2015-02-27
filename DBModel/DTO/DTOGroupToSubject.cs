using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel.DTO
{
    public class DTOGroupToSubject
    {
        public int GroupId { get; set; }
        public string Group { get; set; }
        public int SubjectId { get; set; }
        public string Subject { get; set; }
    }
}
