namespace Shop_Shihova.Data.Models
{
    public class ItemsBasket : Items
    {
        public int Count { get; set; }
        public ItemsBasket(int Count, Items item) 
        {
            this.Count = Count;
            this.Id = item.Id;
            this.Name = item.Name;
            this.Description = item.Description;
            this.Img = item.Img;
            this.Price = item.Price;
            this.Category = item.Category;
        }
    }
}
