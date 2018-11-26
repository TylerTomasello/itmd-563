using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// Github link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj7-grad-tomasello

namespace Proj7_grad_tomasello.Models
{

    public enum DurationTypes
    {

    }

    public class CalcMortgage
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        public virtual double Principle { get; set; }

        [Required]
        public virtual double Duration { get; set; }

        [Required]
        public virtual double Rate { get; set; }

        [ScaffoldColumn(false)]
        public virtual double Result { get; set; }
    }

    
}