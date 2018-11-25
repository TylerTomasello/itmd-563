using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proj7_grad_tomasello.Models
{
    public class Mortgage
    {

        [DisplayName("Principle amount")]
        [Required]
        public virtual float Principle { get; set; }
    }
}