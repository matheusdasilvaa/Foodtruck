using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foodtruck.Negocio.Persistencia
{
    public class Banco : DbContext
    {
        public DbSet<Cliente> Clientes;
        public DbSet<Bebida> Bebidas;
        public DbSet<Lanche> Lanches;
        public DbSet<Pedido> Pedidos;


    }
}
