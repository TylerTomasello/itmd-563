using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

// github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj6-grad-tomasello
namespace Proj6_grad_tomasello.Models
{
    public class Name
    {
        [DisplayName("First Name")]
        [Required]
        public virtual string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public virtual string LastName { get; set; }

        [DisplayName("Name of Course")]
        [Required]
        public virtual string CourseName { get; set; }
    }
}