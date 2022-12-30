using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prj29bWebCoreMVC.Models;

namespace prj29bWebCoreMVC.Data
{
    public class prj29bWebCoreMVCContext : DbContext
    {
        public prj29bWebCoreMVCContext (DbContextOptions<prj29bWebCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<prj29bWebCoreMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
