using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proj7_grad_tomasello.Models
{
    public class CalcMortgage
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        public virtual double Principle { get; set; }

        [Required]
        public virtual double DurationYears { get; set; }

        [Required]
        public virtual double InterestRate { get; set; }

        [ScaffoldColumn(false)]
        public virtual double MonthlyPayment { get; set; }
    }
}