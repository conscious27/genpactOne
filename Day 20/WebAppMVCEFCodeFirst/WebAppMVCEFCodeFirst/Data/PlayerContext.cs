using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVCEFCodeFirst.Models;

namespace WebAppMVCEFCodeFirst.Data
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVCEFCodeFirst.Models.Player> Player { get; set; } = default!;
    }
}
