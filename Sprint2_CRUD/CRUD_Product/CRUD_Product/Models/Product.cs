namespace CRUD_Product.Models
{
    public class Product 
    {
        private string name;
        private string category;
        private float price;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public float Price { get => price; set => price = value; }
    }
}
