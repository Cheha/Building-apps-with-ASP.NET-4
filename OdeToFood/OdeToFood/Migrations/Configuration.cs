namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Porter's", Country = "Ukraine", City = "Kiev" },
                new Restaurant { Name = "Kumpel", Country = "Ukraine", City = "Lviv" },
                new Restaurant
                {
                    Name = "B52",
                    Country = "Ukraine",
                    City = "Kiev",
                    Reviews =  
                        new List<RestaurantReview> {
                            new RestaurantReview { Rating = 9, Body = "Great Food"}
                        }
                });
        }
    }
}
