namespace WebShop.Models
{
    public abstract class Entity
    {
        protected Entity() { }

        public virtual int Id { get; private set; }
    }
}
