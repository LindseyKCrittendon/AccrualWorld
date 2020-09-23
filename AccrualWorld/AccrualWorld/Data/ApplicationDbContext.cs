using System;
using System.Collections.Generic;
using System.Text;
using AccrualWorld.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccrualWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers
        {
            get; set;
        }

        public DbSet<ExpenseType> ExpeseTypes
        {
            get; set;
        }

        public DbSet<Expense> Expenses
        {
            get; set;
        }

        public DbSet<Income> Incomes
        {
            get; set;
        }

        public DbSet<Mileage> Mileages
        {
            get; set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                Id = "1",
                FirstName = "George",
                LastName = "Brown",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create Expense Types
            modelBuilder.Entity<ExpenseType>().HasData(
                new ExpenseType()
                {
                    ExpenseTypeId = 1,
                    Label = "Food"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 2,
                    Label = "Entertainment"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 3,
                    Label = "Office Supplies"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 4,
                    Label = "Cell Phone"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 5,
                    Label = "Internet"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 6,
                    Label = "Electric"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 7,
                    Label = "Child Care"
                },
                new ExpenseType()
                {
                    ExpenseTypeId = 8,
                    Label = "Gifts"
                }
            );
            //Create expenses
            modelBuilder.Entity<Expense>().HasData(
                new Expense()
                {
                    ExpenseId = 1,
                    ExpenseTypeId = 1,
                    UserId = user.Id,
                    Total = 10.50,
                    DateTime = DateTime.Parse("2020-09-23")
                },
                new Expense()
                {
                    ExpenseId = 2,
                    ExpenseTypeId = 2,
                    UserId = user.Id,
                    Total = 20.43,
                    DateTime = DateTime.Parse("2020-8-03")
                },
                new Expense()
                {
                    ExpenseId = 3,
                    ExpenseTypeId = 3,
                    UserId = user.Id,
                    Total = 14.37,
                    DateTime = DateTime.Parse("2020-09-15")
                },
                new Expense()
                {
                    ExpenseId = 4,
                    ExpenseTypeId = 4,
                    UserId = user.Id,
                    Total = 12.99,
                    DateTime = DateTime.Parse("2020-09-22")
                },
                new Expense()
                {
                    ExpenseId = 5,
                    ExpenseTypeId = 5,
                    UserId = user.Id,
                    Total = 87.92,
                    DateTime = DateTime.Parse("2020-09-15")
                },
                new Expense()
                {
                    ExpenseId = 6,
                    ExpenseTypeId = 6,
                    UserId = user.Id,
                    Total = 157.22,
                    DateTime = DateTime.Parse("2020-8-05")
                },
                new Expense()
                {
                    ExpenseId = 7,
                    ExpenseTypeId = 7,
                    UserId = user.Id,
                    Total = 237.23,
                    DateTime = DateTime.Parse("2020-09-23")
                },
                new Expense()
                {
                    ExpenseId = 8,
                    ExpenseTypeId = 8,
                    UserId = user.Id,
                    Total = 100.00,
                    DateTime = DateTime.Parse("2020-09-14")
                }
                );
            //Create Incomes
            modelBuilder.Entity<Income>().HasData(
                new Income()
                {
                    IncomeId = 1,
                    UserId = user.Id,
                    Total = 1000.00,
                    Description = "Legal Services 9/01/2020-09/15/2020",
                    Payer = "Minutemen Press",
                    DateTime = DateTime.Parse("2020-09-30")
                },
                new Income()
                {
                    IncomeId = 2,
                    UserId = user.Id,
                    Total = 263.50,
                    Description = "Administrative Services in August",
                    Payer = "Tommy Vance",
                    DateTime = DateTime.Parse("2020-8-15")
                }
                );
            modelBuilder.Entity<Mileage>().HasData(
                new Mileage()
                {
                    MileageId = 1,
                    UserId = user.Id,
                    Total = 143,
                    Description = "Traveled to Ripley for Court",
                    DateTime = DateTime.Parse("2020-08-15"),
                    Paid = true,
                    AmountPerMile = 0.42
                },
                new Mileage()
                {
                    MileageId = 2,
                    UserId = user.Id,
                    Total = 256,
                    Description = "Traveled to Parkersburg and back for consulting",
                    DateTime = DateTime.Parse("2020-09-13"),
                    Paid = false
                }
                );
        }

        }
    }
