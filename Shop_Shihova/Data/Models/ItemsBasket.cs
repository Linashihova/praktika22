namespace Shop_Shihova.Data.Models
{
    public class ItemsBasket : Items
    {
        public int Count { get; set; }
        public ItemsBasket(int Count, Items item) 
        {
            this.Count = Count;
        }
    }
}
