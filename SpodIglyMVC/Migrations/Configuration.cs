namespace SpodIglyMVC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SpodIglyMVC.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SpodIglyMVC.DAL.StoreContext";
        }

        protected override void Seed(SpodIglyMVC.DAL.StoreContext context)
        {

        }
    }
}
