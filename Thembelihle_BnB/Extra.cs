
namespace Thembelihle
{
    public class Extra
    {
        private int id;
        private string name;
        private string description;
        private int avaliable;
        private float price;
        public Extra(int id,string name, string description, int avaliable, float price)
        {
            this.name = name;
            this.id = id;
            this.description = description;
            this.avaliable = avaliable;
            this.price = price;
        }
        public int ID
        {
            get { return this.id;}
            set { this.id = value;}
        }
        public int Quantity
        {
            get { return this.avaliable; }
            set { this.avaliable = value; }
        }
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
