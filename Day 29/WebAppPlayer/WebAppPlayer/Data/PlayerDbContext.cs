﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPlayer.Models;

namespace WebAppPlayer.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext (DbContextOptions<PlayerDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPlayer.Models.Player> Player { get; set; } = default!;
    }
}
