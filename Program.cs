using System;

namespace HW_1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Random random = new Random();

            for (int i = 0; i < 10; i++) 
            {
                products.Add(new Product()
                {
                    Id = new Guid(),
                    Name = $"Продукт {i}",
                    Cost = random.Next(1, 1000),
                    Description = $"Опис {i}",
                    Quantity = random.Next(100, 500),
                });
            }

            #region 1
            Console.WriteLine("Виведіть на екран значення за індексом > 1, 5, 0, 7");

            int[] indexes = { 1, 5, 0, 7 };
            foreach (int index in indexes)
            {
                if (index < products.Count)
                {
                    Console.WriteLine($"Індекс {index}: {products[index].Name + ", " + products[index].Cost + ", " + products[index].Description + ", " + products[index].Quantity}");
                }
                else
                {
                    Console.WriteLine($"Елемент за індексом {index} не існує у списку.");
                }
            }

            Console.WriteLine("\n" + new string('*', 50));
            #endregion

            #region 2
            Console.WriteLine("\nЗнайдіть та виведіть індекси > 1, 5 за властивістю Id");

            Guid[] idsToFind = { products[1].Id, products[5].Id };

            foreach (Guid id in idsToFind)
            {
                int index = products.FindIndex(p => p.Id == id);
                if (index != -1)
                {
                    Console.WriteLine($"Індекс продукта з Id {id}: {index}");
                }
                else
                {
                    Console.WriteLine($"Продукт з Id {id} не знайдено.");
                }
            }

            Console.WriteLine("\n" + new string('*', 50));
            #endregion

            #region 3
            Console.WriteLine("\nЗнайдіть та виведіть індекси > 0, 7 за властивістю Name:");

            string[] namesToFind = { "Продукт 0", "Продукт 7" };

            foreach (string name in namesToFind)
            {
                var foundProduct = products.FirstOrDefault(p => p.Name == name);
                if (foundProduct != null)
                {
                    Console.WriteLine($"Знайдено продукт з іменем '{name}': {foundProduct.Name + ", " + foundProduct.Cost + ", " + foundProduct.Description + ", " + foundProduct.Quantity}");
                }
                else
                {
                    Console.WriteLine($"Продукт з іменем '{name}' не знайдено.");
                }
            }
            #endregion
        }
    }
}
