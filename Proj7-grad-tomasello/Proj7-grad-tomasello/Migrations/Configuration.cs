namespace Proj7_grad_tomasello.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    // Github link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj7-grad-tomasello
    internal sealed class Configuration : DbMigrationsConfiguration<Proj7_grad_tomasello.Models.Proj7_grad_tomaselloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Proj7_grad_tomasello.Models.Proj7_grad_tomaselloContext";
        }

        protected override void Seed(Proj7_grad_tomasello.Models.Proj7_grad_tomaselloContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
