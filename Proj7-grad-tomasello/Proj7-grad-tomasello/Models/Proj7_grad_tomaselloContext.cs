using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proj7_grad_tomasello.Models
{
    public class Proj7_grad_tomaselloContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Proj7_grad_tomaselloContext() : base("name=Proj7_grad_tomaselloContext")
        {
        }

        public System.Data.Entity.DbSet<Proj7_grad_tomasello.Models.CalcMortgage> CalcMortgages { get; set; }
    }
}
