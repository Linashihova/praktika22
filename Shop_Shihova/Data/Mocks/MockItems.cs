using Shop_Shihova.Data.Interfaces;
using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _category = new MockCategorys();
        public IEnumerable<Items> AllItems 
        {
            get 
            {
                return new List<Items>()
                {
                    new Items() {
                        Id = 0,
                        Name = "Apple iPhone 17 Pro 256 ГБ серебристый",
                        Description = "Смартфон iPhone 17 Pro оснащен передовым чипом A19 Pro, который легко справляется с ресурсоемкой графикой и обработкой больших медиафайлов. Стабильную производительность под высокими нагрузками обеспечивает инновационная система охлаждения: разработанная Apple испарительная камера с лазерной сваркой в сочетании с цельным алюминиевым корпусом эффективно отводит тепло от процессора.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/c2f3c159d518c32a053347ce855eebf6/3f07b1ffa9193a775d83d5a74fa818307037b9e0cf34e51a18ac31304fceefb9.jpg.webp",
                        Price = 122499,
                        Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    },
                    new Items() {
                        Id = 1,
                        Name = "Samsung Galaxy S26 Ultra 256 ГБ черный",
                        Description = "Смартфон Samsung Galaxy S26 Ultra 256 ГБ выполнен в корпусе черного цвета. В модель установлена ОС Android. Экран устройства диагональю 6.9 дюйма передает картинку в разрешении Quad HD+ с плотностью пикселей 498 ppi. Благодаря этому текст и изображения будут четкими, а глаза не устанут даже при длительной работе. Частота обновления 120 Гц делает скроллинг и анимацию на экране плавными и комфортными для зрения.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/d6842d684d9e7db8bdce0e16472170fa/eca0fe3ef63e96da64897ce695511ca515c9058b2cd71c93c78ed74079c69b81.jpg.webp",
                        Price = 100999,
                        Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    },
                    new Items() {
                        Id = 2,
                        Name = "Canon CanoScan LiDE 400",
                        Description = "Сканер Canon CanoScan LiDE 400 – функциональное устройство, предназначенное для сканирования документов и изображений и перевода их PDF. Это планшетный сканер, использующий датчик сканирования CIS и поддерживающий максимальный формат А4. Устройство с площадью сканирования 216x297 мм позволяет сканировать в разрешении 4800x4800 dpi.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/8e436a04f73da239b27116f7bd12fb7e/f26f5a9e4476f202163e6f47efb72df00fc63e5ba086746dd83075d1e46beb36.jpg.webp",
                        Price = 11999,
                        Category = _category.AllCategorys.Where(x => x.Id == 1).First()
                    },
                    new Items() {
                        Id = 3,
                        Name = "Epson WorkForce DS-1630",
                        Description = "Сканер Epson WorkForce DS-1630 – компактное устройство планшетного типа, Ваш надежный помощник в работе. Максимальный формат бумаги для сканирования – А4. Причем сканировать можно не только стандартные листы, но и документы в твердом переплете – на качестве изображения это не скажется. Скорость сканирования, как цветного, так и черно-белого, впечатляет – 25 стр/мин.",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/c5c4f2dd23ffe4ed24cefda839f6e0a2/24abcc18ffe1f1e978e9440529f2cd7361fdfdd9bcf86fce9dcc3fe755c107ac.jpg.webp",
                        Price = 27599,
                        Category = _category.AllCategorys.Where(x => x.Id == 1).First()
                    },
                };
            }
        }

        public int Add(Items Item)
        {
            throw new NotImplementedException();
        }

        public void Update(Items Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
