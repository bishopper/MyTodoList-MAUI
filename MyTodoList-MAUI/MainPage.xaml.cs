using MyTodoList_MAUI.ViewModel;

namespace MyTodoList_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

