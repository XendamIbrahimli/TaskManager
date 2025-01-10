﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL.Context
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
