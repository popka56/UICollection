using BlazorUICollection.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace BlazorUICollection.Pages
{
    public partial class MyGamesList : ComponentBase
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public List<GameModel> Games { get; set; } = new();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var json = await JSRuntime.InvokeAsync<string>("getGameData");
                var games = JsonSerializer.Deserialize<List<GameModel>>(json);

                if (games != null)
                {
                    for (int i = 0; i < games.Count; i++)
                    {
                        games[i].Id = i;
                    }

                    Games = games.OrderBy(g => g.Title).ToList();
                }

                StateHasChanged();
            }
        }
    }
}
