using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<IAboutDal, EfAboutDal>();
builder.Services.AddSingleton<IBlogDal, EfBlogDal>();
builder.Services.AddSingleton<IBlogService, BlogManager>();
builder.Services.AddSingleton<IWriterDal, EfWriterDal>();
builder.Services.AddSingleton<IWriterService, WriterManager>();
builder.Services.AddSingleton<ICommentDal, EfCommentDal>();
builder.Services.AddSingleton<ICommentService, CommentManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();
