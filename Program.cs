using SoftPlan;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/taxaJuros", (double valor) =>
{

    ICreate fabrica = new ConcreteCreate();

    Financa financa = fabrica.CriarObjeto();

    return financa.RetornarTaxaDeJuros(valor);
    
})
.WithName("taxaJuros");

app.MapGet("/calculajuros", (decimal valor, int meses) =>
{

    ICreate fabrica = new ConcreteCreate();

    Financa financa = fabrica.CriarObjeto();

    double juros = financa.RetornarTaxaDeJuros(double.Parse(valor.ToString()));

    decimal valorFinal = financa.CalcularJuros(valor, juros, meses);

    return decimal.Parse(string.Format("{0:0.##}",  valorFinal ));
})
.WithName("calculajuros");

app.Run();