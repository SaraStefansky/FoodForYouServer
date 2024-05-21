using FoodForYouBL;
using FoodForYouDL;
using FoodForYouDL.Models;
using FoodForYouDTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUSERSBL, USERSBL>();
builder.Services.AddScoped<IUSERSDL, USERSDL>();
builder.Services.AddScoped<ILookUpBL, LookUpBL>();
builder.Services.AddScoped<ILookupDL, LookupDL>();
builder.Services.AddScoped<IInstructionBL, InstructionBL>();
builder.Services.AddScoped<IINSTRUCTIONSDL, INSTRUCTIONSDL>();
builder.Services.AddScoped<IProductsBL, ProductsBL>();
builder.Services.AddScoped<IPRODUCTSDL, PRODUCTSDL>();
builder.Services.AddScoped<IAskthechefBL, AskthechefBL>();
builder.Services.AddScoped<IASKTHECHEFDL, ASKTHECHEFDL>();
builder.Services.AddScoped<IChefPicsBL, ChefPicsBL>();
builder.Services.AddScoped<ICHEF_PICSDL, CHEF_PICSDL>();
builder.Services.AddScoped<IRecipesLikeBL, RecipesLikeBL>();
builder.Services.AddScoped<IRECIPES_LIKEDL, RECIPES_LIKEDL>();
builder.Services.AddScoped<ICommentsBL, CommentsBL>();
builder.Services.AddScoped<ICOMMENTSDL, COMMENTSDL>();
builder.Services.AddScoped<IRecipeBL, RecipeBL>();
builder.Services.AddScoped<IRECIPESDL, RECIPESDL>();
builder.Services.AddScoped<ICHEFSDL, CHEFSDL>();
builder.Services.AddScoped<IChefBL, ChefBL>();


builder.Services.AddAutoMapper(typeof(AutoMapping));

var app = builder.Build();

app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
