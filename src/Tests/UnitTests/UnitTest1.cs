using MauiUnitTestBug.ViewModels;

namespace UnitTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var viewModel = new MainPageViewModel();
        Assert.NotNull(viewModel);
    }
}