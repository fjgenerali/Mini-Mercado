using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Data;

namespace Modelo.Modelo
{
    public class AngelesContext : DbContext


    {
        public System.Data.Entity.DbSet<Modelo.Modelo.Boleta> Boletas { get; set; }
    }
}
