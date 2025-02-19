namespace ApplicationCore.Entities
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Product : Prototype
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }
}