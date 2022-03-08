using Limelight6.Database;
using Limelight6.GraphQL.Models;
using Limelight6.GraphQL.Mutations;
using Limelight6.Schema.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddPooledDbContextFactory<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"))
);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<EvaluationType>()
    .AddType<EventType>()
    .AddType<FormType>()
    .AddType<PaymentType>()
    .AddType<RegistrationType>()
    .AddType<SubmissionType>()
    .AddType<SupplementType>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();