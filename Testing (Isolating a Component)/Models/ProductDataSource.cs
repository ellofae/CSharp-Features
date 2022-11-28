namespace SimpleApp.Models
{
    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products => new Product[]
        {
            new Product { Name = "Kayak", Price = 275M },
            new Product { Name = "Lifejacket", Price = 48.95M }
        };
    }
}
