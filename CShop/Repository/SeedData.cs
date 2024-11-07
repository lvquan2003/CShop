using CShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CShop.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel macbook = new CategoryModel{ Name = "Macbook", Slug = "macbook", Description = "Macbook is Large Product in the world", Status = 1 };
				CategoryModel pc = new CategoryModel { Name = "Pc", Slug = "pc", Description = "Pc is Large Product in the world", Status = 1 };
				BrandModel apple = new BrandModel { Name = "Apple", Slug = "apple", Description = "Apple is Large Brand in the world", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "samsung", Description = "Samsung is Large Brand in the world", Status = 1 };
				_context.Products.AddRange(
					new ProductModel { Name = "Macbook", Slug = "Macbook", Description = "Macbook is the best", Image = "1.jpg", Category = macbook, Brand = apple, Price = 1222 },
					new ProductModel { Name = "Pc", Slug = "Pc", Description = "Pc is the best", Image = "1.jpg", Category = pc, Brand = samsung, Price = 1222 }
				);
				_context.SaveChanges();

			}
		}
	}
}
