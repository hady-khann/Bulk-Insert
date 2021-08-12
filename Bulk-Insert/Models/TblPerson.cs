using System;
using System.Collections.Generic;

#nullable disable

namespace Bulk_Insert.Models
{
    public partial class TblPerson
    {
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public string Faname { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
    }
}
