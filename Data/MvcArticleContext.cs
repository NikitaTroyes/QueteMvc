using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using questCRUD.Models;


namespace questCRUD.Data
{
    public class MvcArticleContext :DbContext
    {
        public MvcArticleContext (DbContextOptions<MvcArticleContext> options) : base(options)
        {

        }

        public DbSet<Articles> Article { get; set; }
    }
}
