using SoftPlan;
using TesteComAPIs.Interfaces;

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

app.MapGet("/taxaJuros", (decimal valor) =>
{
    IFabrica fabrica = new Fabrica();

    Financa financa = fabrica.CriarObjeto();

    return financa.RetornarTaxaDeJuros(valor);
    
})
.WithName("taxaJuros");

app.MapGet("/calculajuros", (decimal valor, int meses) =>
{
    IFabrica fabrica = new Fabrica();

    Financa financa = fabrica.CriarObjeto();

    decimal juros = financa.RetornarTaxaDeJuros(valor);

    decimal valorFinal = financa.CalcularJuros(valor, juros, meses);

    return decimal.Parse(string.Format("{0:0.##}",  valorFinal ));
})
.WithName("calculajuros");

app.MapGet("/showmethecode", () =>
{      
    return "Link do GitHub: https://github.com/RicardoZitelli/TesteComAPIs";
})
.WithName("showmethecode");

app.Run();