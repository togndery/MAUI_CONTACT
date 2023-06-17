using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.ViewModel
{
    public partial class  ContactPageViewModel: ObservableObject
    {
        [RelayCommand]
        async Task EditePage()
        {
            await Shell.Current.GoToAsync(nameof(EditContactPage));
        }
    }
}
