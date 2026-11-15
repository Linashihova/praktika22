using Shop_Shihova.Data.DataBase;
using Shop_Shihova.Data.Interfaces;
using Shop_Shihova.Data.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICategorys, DBCategory>();
builder.Services.AddTransient<IItems, DBItems>();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();

public partial class Program
{
    public static List<ItemsBasket> BasketItem = new List<ItemsBasket>();
}