
using MediatR;
using MediatRPOC.Entities;
using MediatRPOC.Handlers;
using MediatRPOC.Repositories;
using MediatRPOC.Requests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IPokemonRepository , PokemonRepository>();
builder.Services.RegisterRequestHandlers();

using IHost host = builder.Build();

await PlayWithMediatR(host.Services);

await host.RunAsync();

static async Task PlayWithMediatR(IServiceProvider services)
{
    var mediator = services.GetService<IMediator>();
    var pikachuId= Guid.NewGuid();
    var bulbizarreId = Guid.NewGuid();
    await mediator.Send(new CreatePokemonRequest()
    {
        Pokemon = new()
        {
            PokemonId = pikachuId,
            PokemonName = "Pikachoux",
            PokemonDescription = "ZzZzzzzzZZttt",
            PokemonStrength = 50,
            PokemonHealth = 100
        }
    });
    await mediator.Send(new CreatePokemonRequest()
    {
        Pokemon = new()
        {
            PokemonId = bulbizarreId,
            PokemonName = "Bulle bizarre",
            PokemonDescription = "bloublou",
            PokemonStrength = 50,
            PokemonHealth = 100
        }
    });
    var pokemon = await mediator.Send(new GetPokemonRequest() { PokemonId = pikachuId });
    pokemon = await mediator.Send(new GetPokemonRequest() { PokemonId = bulbizarreId });


}