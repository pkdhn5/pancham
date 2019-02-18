using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieList.Models;

namespace MovieList.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Actors.Any())
            {
                return;   // DB has been seeded
            }

            var actors = new Actor[]
            {
            new Actor{Id=1,Name="Salman Khan",sex="M",Dob=DateTime.Parse("1975-09-01"),Bio="Superstar"},
            new Actor{Id=2,Name="Amir Khan",sex="M",Dob=DateTime.Parse("1978-09-01"),Bio="Superstar"},
            new Actor{Id=3,Name="Depika Padukon",sex="F",Dob=DateTime.Parse("1988-09-01"),Bio="Superstar"},
            new Actor{Id=4,Name="Kartik Aryan",sex="M",Dob=DateTime.Parse("1987-09-01"),Bio="star"}
            };
            foreach (Actor s in actors)
            {
                context.Actors.Add(s);
            }
            context.SaveChanges();

            var movies = new Movie[]
            {
             new Movie{Id=1,MovieId=1050,producerId=1211,Name="Wanted",plot="Mumbai",yearofRealse=DateTime.Parse("2019"),poster="circle"},
             new Movie{Id=1,MovieId=1051,producerId=1211,Name="pk",plot="Delhi",yearofRealse=DateTime.Parse("2017"),poster="square"},
             new Movie{MovieId=1052,producerId=1213,Name="piku",plot="Mumbai",yearofRealse=DateTime.Parse("2016"),poster="circle"},
             new Movie{MovieId=1053,producerId=1214,Name="Pyar ka punchnama",plot="Mumbai",yearofRealse=DateTime.Parse("2018"),poster="circle"}
            };
            foreach (Movie c in movies)
            {
                context.Movies.Add(c);
            }
            context.SaveChanges();

            var producers = new Producer[]
            {
            new Producer{producerId=1211,Name="Boney Kappor",sex="M",Dob=DateTime.Parse("1975-09-01"),Bio="Superstar"},
            new Producer{producerId=1212,MovieId=1052,Name="Vidhu Vinod chopra",sex="M",Dob=DateTime.Parse("1978-09-01"),Bio="Superstar"},
            new Producer{producerId=1213,Name="karan johar",sex="M",Dob=DateTime.Parse("1988-09-01"),Bio="Superstar"},
            new Producer{producerId=1214,Name="Sajid Khan",sex="M",Dob=DateTime.Parse("1987-09-01"),Bio="star"}
            };
            foreach (Producer e in producers)
            {
                context.producers.Add(e);
            }
            context.SaveChanges();
        }
    }
}
