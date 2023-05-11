using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyTodoList_MAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        String text;

        [ObservableProperty]
        ObservableCollection<string> items;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            items.Add(text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string text)
        {
            if (Items.Contains(text))
            {
                items.Remove(text);
            }
        }
    }
}
