using Application;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiUnitTestBug.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private DummyClass _dummyClass;

    public MainPageViewModel()
    {

    }
}
