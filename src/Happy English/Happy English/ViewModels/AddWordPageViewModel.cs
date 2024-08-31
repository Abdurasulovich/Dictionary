using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Happy_English.ViewModels;

public partial class AddWordPageViewModel : ObservableObject
{
    public AddWordPageViewModel()
    {
        ListOfSelector = new ObservableCollection<string>
        {
            "noun",
            "verb",
            "adjective",
            "adverb"
        };
    }

    [ObservableProperty]
    ObservableCollection<string> listOfSelector;
}
