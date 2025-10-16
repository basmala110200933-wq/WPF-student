using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdegree.model
{
    public class Courses
    {
        [Key]
        public int CId {  get; set; }
        public string CName { get; set; }
    }
}
