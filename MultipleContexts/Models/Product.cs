namespace MultipleContexts.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }

        public long Price { get; set; }

        public int Stock { get; set; }
    }
}
