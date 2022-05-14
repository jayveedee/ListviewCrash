using System.Collections.ObjectModel;

namespace ListviewCrash;

internal class MainPageViewModel
{

    public ObservableCollection<MainPageModel> ModelsValue { get; set; }

    public MainPageViewModel()
    {
        ModelsValue = new ObservableCollection<MainPageModel>();

        for (int i = 0; i < 30; i++)
        {
            ModelsValue.Add(new MainPageModel() { Name = "Test", Description = i.ToString() });
        }
    }
}
