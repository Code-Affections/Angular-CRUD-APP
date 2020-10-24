﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Model
{
    public class StudentDbContext:DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        { 
        }

        public DbSet<Student> students { get; set; }

    }
}
