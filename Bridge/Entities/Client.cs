namespace Bridge.Entities
{
    internal class Client
    {
        public int Id { get; set; } 
        
        public string? Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Client {Name}, Age : {Age}";
        }
    }
}
