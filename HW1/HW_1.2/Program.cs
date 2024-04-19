using HW_1._1;

namespace HW_1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                bool databaseIsEmpty = !context.products.Any();

                // Создание подуктов только если бд пустая!
                if (databaseIsEmpty)
                {
                    Random random = new Random();

                    for (int i = 0; i < 10; i++)
                    {
                        Product newProduct = new Product()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Продук {i}",
                            Cost = random.Next(1, 1000),
                            Description = $"Опис {i}",
                            Quantity = random.Next(100, 500),
                        };

                        context.products.Add(newProduct);
                    }

                    context.SaveChanges();
                }

                #region 1й способ

                string[] namesToFind = { "Продук 1", "Продук 5", "Продук 0", "Продук 7" };

                foreach (var name in namesToFind)
                {
                    // Поиск ВСЕХ продуктов из БД по имени
                    var products = context.products.Where(p => p.Name == name).ToList();

                    if (products.Any())
                    {
                        Console.WriteLine($"\nПродукты с именем '{name}':");

                        // Вывожу результат
                        foreach (var product in products)
                        {
                            Console.WriteLine($"Id: {product.Id}, Название: {product.Name}, Цена: {product.Cost}, Описание: {product.Description}, Кол-во: {product.Quantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Продукт с именем '{name}' не найден.");
                    }
                }
                #endregion

                #region 2й способ
                //// Массив имен дя поиска
                //string[] namesToFind = { "Продук 1", "Продук 5", "Продук 0", "Продук 7" };

                //// Поиск всех продуктов из БД по имени
                //var products = context.products.Where(p => namesToFind.Contains(p.Name)).ToList();

                //// Вывод рез.
                //foreach (var product in products)
                //{
                //    Console.WriteLine($"\nПродукт с именем '{product.Name}' найден:");
                //    Console.WriteLine($"Id: {product.Id}, Название: {product.Name}, Цена: {product.Cost}, Описание: {product.Description}, Кол-во: {product.Quantity}");
                //}

                //// Проверка, были ли все имена найдены
                //var foundNames = products.Select(p => p.Name).Distinct().ToList();
                //foreach (var name in namesToFind)
                //{
                //    if (!foundNames.Contains(name))
                //    {
                //        Console.WriteLine($"Продукт с именем '{name}' не найден.");
                //    }
                //}
                #endregion

                #region 3й способ
                //string[] namesToFind = { "Продук 1", "Продук 5", "Продук 0", "Продук 7" };

                //foreach (string name in namesToFind)
                //{
                //    var product = context.products.FirstOrDefault(p => p.Name == name);

                //    if (product != null)
                //    {
                //        Console.WriteLine($"\nПродукт з іменем '{name}' знайдено:");
                //        Console.WriteLine($"Id: {product.Id}, Назва: {product.Name}, Ціна: {product.Cost}, Опис: {product.Description}, Кількість: {product.Quantity}");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"Продукт з іменем '{name}' не знайдено.");
                //    }
                //}
                #endregion
            }
        }
    }
}
