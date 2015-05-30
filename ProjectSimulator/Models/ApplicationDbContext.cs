using System.Data.Entity;

namespace ProjectSimulator.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyDatabase") {}

        public IDbSet<Map> Maps { get; set; }
    }

    public class ApplicationDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);

            Map[] maps = new Map[]
            {
                new Map
                {
                    Isbn = "978-83-88112-70-6",
                    Terrain = "Gorce i Pieniny",
                    Type = "Turystyczna",
                    Scale = 50000,
                    State = "bad"
                },
                new Map
                {
                    Isbn = "978-83-78681-93-9",
                    Terrain = "Tatry",
                    Type = "Turystyczna",
                    Scale = 27500,
                    State = "very_bad"
                }
            };

            foreach (Map map in maps)
            {
                context.Maps.Add(map);
            }
        }
    }
}
