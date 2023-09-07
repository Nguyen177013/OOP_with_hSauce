namespace SauceStorage.Sauces
{
    internal abstract class Sauce
    {
        protected int id;
        protected string name;
        protected string author;
        public Sauce()
        {

        }

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Author { get { return author; } set { author = value; } }

        public virtual string generateSauce()
        {
            return $"Id: {id}\nSauce: {name}\nAuthor: {author}";
        }
    }
}
