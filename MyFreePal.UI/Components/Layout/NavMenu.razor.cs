using Microsoft.AspNetCore.Components;

namespace MyFreePal.UI.Components.Layout
{
    public partial class NavMenu : ComponentBase
    {
        [Inject]
        private NavigationManager NavManager { get; set; }

        private void GoToDashboard()
        {
            NavManager.NavigateTo($"/");
        }

        private void GoToDiary()
        {
            NavManager.NavigateTo($"/diary");
        }

        private void GoToMore()
        {
            NavManager.NavigateTo($"/more");
        }

    }
}
