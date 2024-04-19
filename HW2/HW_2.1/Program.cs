using HW_1._1;
using HW_1._2;

namespace HW_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDatabaseContext())
            {
                try
                {
                    var product = context.products.Find(-1);
                }
                catch (Exception ex)
                {
                    // Додавання помилки до колекції Error
                    context.errors.Add(new Error(ex.Message, DateTime.Now, "Program/Main", StatusCode.Server));
                    //context.SaveChanges();
                }
            }
        }
    }
}
