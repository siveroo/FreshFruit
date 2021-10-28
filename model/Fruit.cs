namespace FreshFruit.model
{
    class Fruit
    {
        public string name { get; set; }

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
