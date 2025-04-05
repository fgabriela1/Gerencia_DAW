using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace Administracion.Models
{
    public class RestauranteDBProyectoAContext : DbContext
    {
        public RestauranteDBProyectoAContext(DbContextOptions<RestauranteDBProyectoAContext> options) : base(options)
        {
        }

        // Tablas principales
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Promocion> Promociones { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Mesa> Mesas { get; set; }

        // Tablas de relación
        public DbSet<PlatoCombo> PlatosCombos { get; set; }
        public DbSet<PromocionItem> PromocionesItems { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }

        // Pedidos y facturación
        public DbSet<EstadoPedido> EstadoPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallesPedido { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<MetodosPago> MetodosPago { get; set; }
        public DbSet<EstadoPedido> EstadoPedido { get; set; }
        public DbSet<TipoPago> TipoPago { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones de relaciones y claves
            modelBuilder.Entity<PlatoCombo>()
                .HasKey(pc => new { pc.ComboID, pc.PlatoID });

            modelBuilder.Entity<PromocionItem>()
                .HasKey(pi => new { pi.PromocionID, pi.PlatoID, pi.ComboID });

            modelBuilder.Entity<MenuItems>()
                .HasKey(mi => mi.MenuItemId);

            //modelBuilder.Entity<DetallePedido>()
            //    .HasKey(dp => new { dp.Id_pedido, dp.MenuItemId });
        }
    }
}

