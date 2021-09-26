namespace Module6Assignment
{
    public class Item
    {
        private string name = "";
        private double price = 0;
        private double quantity = 0;

        public Item(string name = null, double quantity = default, double price = default)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}