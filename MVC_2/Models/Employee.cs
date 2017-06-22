using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("Id")]
        public int Id { set; get; }
        public String Name { set; get; }
        public String Gender { set; get; }
        public String City { set; get; }
    }
}