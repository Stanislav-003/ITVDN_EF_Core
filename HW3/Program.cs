namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDatabaseContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var user1 = new User { Id = Guid.NewGuid(), Name = "Name1", Email = "name1@ex.com" };
                var user2 = new User { Id = Guid.NewGuid(), Name = "Name2", Email = "name2@ex.com" };

                context.Users.AddRange(user1, user2);

                var category1 = new Category { Id = Guid.NewGuid(), Name = "Електроніка" };
                var category2 = new Category { Id = Guid.NewGuid(), Name = "Одяг" };
                var category3 = new Category { Id = Guid.NewGuid(), Name = "Книги" };

                context.Categories.AddRange(category1, category2, category3);

                var product1 = new Product { Id = Guid.NewGuid(), Name = "Смартфон", Price = 500, Description = "Опис смартфону", Category = category1 };
                var product2 = new Product { Id = Guid.NewGuid(), Name = "Футболка", Price = 20, Description = "Опис футболки", Category = category2 };
                var product3 = new Product { Id = Guid.NewGuid(), Name = "Роман", Price = 10, Description = "Опис роману", Category = category3 };

                var keyword1 = new Word { Id = Guid.NewGuid(), Header = "Технології", KeyWord = "Екран, Камера, Процесор" };
                var keyword2 = new Word { Id = Guid.NewGuid(), Header = "Мода", KeyWord = "Матеріал, Розмір, Кольори" };
                var keyword3 = new Word { Id = Guid.NewGuid(), Header = "Література", KeyWord = "Жанр, Автор, Сюжет" };

                context.Products.AddRange(product1, product2, product3);
                context.Words.AddRange(keyword1, keyword2, keyword3);

                context.SaveChanges();
            }

            using (var context = new MyDatabaseContext())
            {
                Console.WriteLine("Користувачі:");
                foreach (var user in context.Users)
                {
                    Console.WriteLine($"Користувач {user.Name}, Email: {user.Email}");
                }

                Console.WriteLine("\nКатегорії:");
                foreach (var category in context.Categories)
                {
                    Console.WriteLine($"Категорія: {category.Name}");
                }

                Console.WriteLine("\nПродукти:");
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"Продукт: {product.Name} - {product.Description}");
                    Console.WriteLine($"Ключові слова: {string.Join(", ", product.KeyWords.Select(k => k.KeyWords))}");
                }
            }
        }
    }
}
