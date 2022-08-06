using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AccountGroups
    {
        public int Id { get; set; } 
        public double? Code { get; set; }
        public string? Name { get; set; }
        public string? ParentCode { get; set; }
        public string? Description { get; set; }
        public string? Hidden { get; set; }
        public string? Encode { get; set; }
    }
}
