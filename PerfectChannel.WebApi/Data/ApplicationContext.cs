using System;
using Microsoft.EntityFrameworkCore;
using PerfectChannel.WebApi.Models;

namespace PerfectChannel.WebApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<ApplicationTask> TodoTask { get; set; }
    }
}
