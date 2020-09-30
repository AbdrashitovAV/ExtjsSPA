using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Spa.Db;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Spa.Migrations
{
    public partial class AddData : Migration
    {
        private readonly List<People> peoples = new List<People>
            {
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                },
                new People
                {
                    FirstName = "",
                    LastName = "",
                    City = "",
                    Country = ""
                }
            };
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var context = new EfContext())
            {
                var index = 1;
                var inDb = context.Peoples.AsQueryable().ToList();

                foreach (var people in peoples)
                {
                    var row = context.Peoples.FirstOrDefault(p => p.Id == index);

                    var firstName = $"AAA {index}";
                    var lastName = $"BBB {index}";
                    var city = index % 2 == 0 ? "Moscow" : "St. Petersburg";
                    var country = "Russia";

                    if (row == null)
                    {
                        context.Database.ExecuteSqlRaw($"INSERT INTO PEOPLES (Id, FirstName, LastName, City, Country) Values ('{index}','{firstName}','{lastName}','{city}','{country}')");
                        context.SaveChanges();
                        ++index;
                        continue;
                    }

                    row.FirstName = firstName;
                    row.LastName = lastName;
                    row.City = city;
                    row.Country = country;

                    ++index;
                    context.Peoples.Update(row);
                    context.SaveChanges();
                }


            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
