namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product>? Products { get; }
        IEnumerable<string>? Name => Products?.Select(p => p.Name);
    }
}
