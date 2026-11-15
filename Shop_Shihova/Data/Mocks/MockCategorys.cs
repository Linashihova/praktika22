using Shop_Shihova.Data.Interfaces;
using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.Mocks
{
    public class MockCategorys : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                return new List<Categorys>()
                {
                    new Categorys() {
                        Id = 0,
                        Name = "Смартфоны",
                        Description = "Мобильные телефоны нового поколения, которые по своим вычислительным возможностям приближаются к полноценным карманным компьютерам.",
                    },
                    new Categorys() {
                        Id = 1,
                        Name = "Сканеры",
                        Description = "Периферийные устройства ввода, которые анализируют физический объект и преобразуют его в цифровой вид для сохранения или обработки на компьютере.",
                    }
                };
            }
        }
    }
}
