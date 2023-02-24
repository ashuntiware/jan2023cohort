var builder = WebApplication.CreateBuilder(args);  

builder.Services.AddControllersWithViews(); //Adding the ability to use controller files
var app = builder.Build();

app.UseStaticFiles(); //enabling user of css/js/imgs
app.UseRouting(); // enables us to have more than one route/ page/ view
app.UseAuthorization(); // used with db for auth / log in

// is for error templtes
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //This helps us set up the pattern for our routes and tells the programs to look for the routes in the controller files
    
// app.MapGet("/", () => "Hello World!");

app.Run();
