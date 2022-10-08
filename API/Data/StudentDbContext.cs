﻿using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
