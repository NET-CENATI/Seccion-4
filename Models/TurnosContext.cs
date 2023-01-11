using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turnos.Models;

namespace Seccion_4.Models
{
    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> opciones) 
        : base(opciones)
        {

        }

        public DbSet<Especialidad> Especialidad { get; set; }
    }
}