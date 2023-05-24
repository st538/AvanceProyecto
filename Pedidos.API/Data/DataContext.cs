using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pedidos.Modelos;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Pedidos.Modelos.Pedido> Pedido { get; set; } = default!;

        public DbSet<Pedidos.Modelos.Clientes>? Clientes { get; set; }
    }
