using CommunityToolkit.Mvvm.Input;
using BAMFHL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMFHL.ViewModels
{
    public partial class WelcomeViewModel : BaseViewModel
    {
        AuthenticationService _authenticationService;

        public WelcomeViewModel(AuthenticationService authenticationService)
        {
            Title = "Welcome";

            _authenticationService = authenticationService;
        }

        [RelayCommand]
        async Task SignUpOrInAsync()
        {
            if (IsBusy)
                return;

            // here you'd call out to MSAL and Azure AD / B2C
            _authenticationService.SignUpOrIn();

            await Task.CompletedTask;
        }
    }
}
