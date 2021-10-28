namespace SpodIglyMVC.Migrations
{
    using SpodIglyMVC.DAL;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SpodIglyMVC.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SpodIglyMVC.DAL.StoreContext context)
        {
            StoreInitializer.SeedStoreData(context);
        }
    }
}
