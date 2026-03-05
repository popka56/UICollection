using BlazorUICollection.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace BlazorUICollection.Pages
{
    public partial class MyGamesListSingle : ComponentBase
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public int Id { get; set; }

        public GameModel Game { get; set; } = new();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var json = await JSRuntime.InvokeAsync<string>("getGameData");
                var games = JsonSerializer.Deserialize<List<GameModel>>(json);

                if (games != null)
                    Game = games[Id];

                StateHasChanged();
            }
        }
    }
}
