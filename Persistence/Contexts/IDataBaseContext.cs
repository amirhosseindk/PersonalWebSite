using Domain.Entities.Cart;
using Domain.Entities.Categorys;
using Domain.Entities.Order;
using Domain.Entities.Products;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<CartItem> CartItems { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        //DbSet<ProductImages> ProductImages { get; set; }
        //DbSet<ProductFeatures> ProductFeatures { get; set; }
    }
}