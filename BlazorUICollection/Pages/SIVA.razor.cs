using Microsoft.AspNetCore.Components;

namespace BlazorUICollection.Pages
{
    public partial class SIVA : ComponentBase
    {
        private bool _isInitializing = true;

        protected override async Task  OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Delay(5000);
                _isInitializing = false;
                StateHasChanged();
            }
        }
    }
}
