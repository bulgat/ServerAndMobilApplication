using AngularStrike.Server.model;
using Microsoft.EntityFrameworkCore;
using TriangleDocker.Models.graphQL;


namespace TriangleDocker.dataBasa
{
    public class AppDBcontent : DbContext
    {
        
        public AppDBcontent(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Score> Score { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Author> Authors { get; set; }
        //public Microsoft.EntityFrameworkCore.DbSet<Articles> Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*
            modelBuilder.Entity<Score>(builder =>
            {


                builder.ToTable("Score");
                builder.Property(p => p.Name).HasMaxLength(10).IsRequired();
                builder.Property(p => p.Family).HasMaxLength(10).IsRequired();
                //builder.Property(p => p.Date).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

                //builder.HasMany(score => score.PlayerList)
                //.WithOne()
                //.HasForeignKey(player => player.ScoreId);//.IsRequired();

                builder.HasData(new Score
                {
                    Id = 1,
                    Name = "kolStop",
                    Family = "sss9",
                    Date = DateTime.Now,
                    //Description="dz",
                    //Record = true
                });



            });

            modelBuilder.Entity<Articles>(builder =>
            {
                builder.ToTable("Player");
                var playerList = Enumerable.Range(1, 100).Select(id => new Articles
                {
                    Id = id,
                    Content = "cont",
                    Description = "desc",
                    Title = "title"
                }).ToList();
                builder.HasData(playerList);
            });
            modelBuilder.Entity<Score>(b => {
                b.Property(x => x.Name).IsRequired();

            });



            base.OnModelCreating(modelBuilder);
*/
        }
  

    }
}
