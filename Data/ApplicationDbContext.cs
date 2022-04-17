using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DictionaryWebApp.Models;

namespace DictionaryWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DictionaryWebApp.Models.Word> Word { get; set; }
        public DbSet<DictionaryWebApp.Models.Language> Language { get; set; }
    }
}
