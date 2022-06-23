namespace Bridge.Entities
{
    internal class Category
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public override string ToString()
        {
            return $"Category {Title}";
        }

    }
}
