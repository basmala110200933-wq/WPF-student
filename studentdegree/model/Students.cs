using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace studentdegree.model
{
    public class Students
    {
        [Key]
   public  int Id { get; set; }
        [Required]
        public string stdusername {  get; set; }
        [Required]
        public string stdpassword {  get; set; }
    }
}
