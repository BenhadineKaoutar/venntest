namespace venntest.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using venntest.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<venntest.DAL.VennContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(venntest.DAL.VennContext context)
        {
            var dummyproducts = new List<Product>
            {
            new Product() { Name = "The Lord of the Rings", Description = "Since it was first published in 1954, The Lord of the Rings has been a book people have treasured. Steeped in unrivalled magic and otherworldliness, its sweeping fantasy and epic adventure has touched the hearts of young and old alike.", Price = 51.64, Quantity = 2000, InStock = 9, ImagePath = "~/images/the ring210659769.PNG" },
            new Product() { Name = "The Book of Hope: A Survival Guide for an Endangered Planet", Description = "The world-renowned naturalist and conservationist Jane Goodall has spent more than a half-century warning of our impact on our planet. From her famous encounters with chimpanzees in the forests of Gombe as a young woman to her tireless campaigning for the environment in her late eighties, Jane has become the godmother to a new generation of climate activists.", Price = 21.07, Quantity = 1000, InStock = 0, ImagePath = "~/images/the book of hope214856605.jpg"  },
            new Product() { Name = "The Cat Who Saved Books", Description = "Natsuki Books was a tiny second-hand bookshop on the edge of town. Inside, towering shelves reached the ceiling, every one crammed full of wonderful books. Rintaro Natsuki loved this space that his grandfather had created. He spent many happy hours there, reading whatever he liked. It was the perfect refuge for a boy who tended to be something of a recluse.", Price = 12.50, Quantity = 2500, InStock = 500, ImagePath= "~/images/the cat211527703.PNG"}
            };
            dummyproducts.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();
        }
    }
}
