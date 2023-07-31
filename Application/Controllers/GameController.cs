using System.Collections;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class GameController : ControllerBase
{
    [HttpGet]
    public IEnumerable Get() => CreateDummyGame();

    private static IEnumerable<Game> CreateDummyGame()
    {
        return new List<Game>()
        {
            new()
            {
                Id = 1,
                Title = "The Witcher 3",
                Description =
                    "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by Polish developer CD Projekt Red and is based on The Witcher series of fantasy novels by Andrzej Sapkowski. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third main installment in the The Witcher's video game series, played in an open world with a third-person perspective.",
                Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/292030/capsule_616x353.jpg?t=1592844156",
                Genre = "Role-playing (RPG)",
                Developer = "CD Projekt RED",
                Publisher = "CD Projekt RED",
                ReleaseDate = "May 18, 2015",
                Platform = "PC",
                MinimumRequirements =
                    "OS: 64-bit Windows 7, 64-bit Windows 8 (8.1) or 64-bit Windows 10\nProcessor: Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940\nMemory: 6 GB RAM\nGraphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870\nStorage: 35 GB available space\nDirectX: Version 11\nAdditional Notes: Game requires Internet connection for activation.",
                RecommendedRequirements =
                    "OS: 64-bit Windows 7, 64-bit Windows 8 (8.1) or 64-bit Windows 10\nProcessor: Intel CPU Core i7 3770 3.4 GHz / AMD CPU AMD FX-8350 4 GHz\nMemory: 8 GB RAM\nGraphics: Nvidia GPU GeForce GTX 770 / AMD GPU Radeon R9 290\nStorage: 35 GB available space\nDirectX: Version 11\nAdditional Notes: Game requires Internet connection for activation.",
                Price = "US$ 39.99"
            },
            new()
            {
                Id = 2,
                Title = "Grand Theft Auto V",
                Description =
                    "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the first main entry in the Grand Theft Auto series since 2008's Grand Theft Auto IV. Set within the fictional state of San Andreas",
                Image = "https://cdn.cloudflare.steamstatic.com/steam/apps/271590/capsule_616x353.jpg?t=1592844156",
                Genre = "Action",
                Developer = "Rockstar North",
                Publisher = "Rockstar Games",
                ReleaseDate = "April 14, 2015",
                Platform = "PC",
                MinimumRequirements =
                    "OS: Windows 10 64 Bit, Windows 8.1 64 Bit, Windows 8 64 Bit, Windows 7 64 Bit Service Pack 1",
                RecommendedRequirements =
                    "OS: Windows 10 64 Bit, Windows 8.1 64 Bit, Windows 8 64 Bit, Windows 7 64 Bit Service Pack 1",
                Price = "US$ 29.99"
            },
        };
    }
}