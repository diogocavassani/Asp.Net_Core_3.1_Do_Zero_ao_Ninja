using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooperchip.ITDeveloper.Data.ORM._Object_Relacional_Mapping
{
    public class ITDeveloperDbContext : DbContext 
    {
        public ITDeveloperDbContext(DbContextOptions<ITDeveloperDbContext> options) : base(options)
        {

        }

        public DbSet<Mural> Mural { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<EstadoPaciente> EstadoPaciente { get; set; }
    }
}
