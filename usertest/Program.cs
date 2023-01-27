using Microsoft.AspNetCore.Mvc;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

//app.UseHttpsRedirection();





app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseCors("CorsPolicy");

app.UseCors(options => options.WithOrigins("http://127.0.0.1:5500")
.AllowAnyMethod().AllowAnyHeader());



// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Users}/{action=GetData}/{id?}");

// app.MapControllerRoute(
//     name: "delete",
//     pattern: "{controller=Users}/{action=DeleteUser}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Users}/{action=GetData}/{id?}");
    endpoints.MapControllerRoute(
        name: "DeleteUser",
        pattern: "{controller=Users}/{action=DeleteUser}/{id}");
    endpoints.MapControllerRoute(
        name: "UpdateUser",
        pattern: "{controller=Users}/{action=UpdateUser}/{id}");
});



app.Run();
