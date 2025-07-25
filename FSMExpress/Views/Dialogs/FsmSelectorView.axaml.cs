using Avalonia.Controls;
using Avalonia.Input;
using FSMExpress.ViewModels.Dialogs;

namespace FSMExpress.Views.Dialogs;
public partial class SceneSelectorView : UserControl
{
    public SceneSelectorView()
    {
        InitializeComponent();
    }

    public void ListBoxItem_DoubleTapped(object? sender, TappedEventArgs e)
    {
        if (DataContext is SceneSelectorViewModel vm)
        {
            vm.ListBoxItem_DoubleTapped();
        }
    }
}
