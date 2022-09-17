using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

builder.Services.AddSingleton<IAboutService, AboutManager>();
builder.Services.AddSingleton<IAboutDal, EfAboutDal>();

builder.Services.AddSingleton<IBlogDal, EfBlogDal>();
builder.Services.AddSingleton<IBlogService, BlogManager>();

builder.Services.AddSingleton<IWriterDal, EfWriterDal>();
builder.Services.AddSingleton<IWriterService, WriterManager>();

builder.Services.AddSingleton<ICommentDal, EfCommentDal>();
builder.Services.AddSingleton<ICommentService, CommentManager>();

builder.Services.AddSingleton<INewsLetterService, NewsLetterManager>();
builder.Services.AddSingleton<INewsLetterDal, EfNewsLetterDal>();

builder.Services.AddSingleton<IContactService, ContactManager>();
builder.Services.AddSingleton<IContactDal, EfContactDal>();

builder.Services.AddSingleton<INotificationService, NotificationManager>();
builder.Services.AddSingleton<INotificationDal, EfNotificationDal>();

builder.Services.AddSingleton<IMessageWithWriterService, MessageWithWriterManager>();
builder.Services.AddSingleton<IMessageWithWriterDal, EfMessageWithWriterDal>();

builder.Services.AddSingleton<IMessageService, MessageManager>();
builder.Services.AddSingleton<IMessageDal, EfMessageDal>();

builder.Services.AddMvcCore(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvcCore();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
       .AddCookie(x => { x.LoginPath = "/Login/Index"; });

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Index}/{id?}");

app.Run();
