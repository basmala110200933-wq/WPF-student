using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdegree.model
{
    public class Studentcoursedegree
    {
        [Key, Column(Order = 0)]
        public int sId { get; set; }
        [Key, Column(Order = 1)]
        public int cId { get; set; }
        public int grade { get; set; }
        [ForeignKey("sId")]
        public virtual Students Students { get; set; }
        [ForeignKey("cId")]
        public virtual Courses courses { get; set; }
    }
}