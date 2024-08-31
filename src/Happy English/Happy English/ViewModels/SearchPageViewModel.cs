using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Happy_English.ViewModels;

public partial class SearchPageViewModel : ObservableObject
{
    public SearchPageViewModel()
    {
        ListWords = new ObservableCollection<string>();
        FilteredWords = new ObservableCollection<string>();
        Load();
    }

    [ObservableProperty]
    ObservableCollection<string> listWords;

    [ObservableProperty]
    ObservableCollection<string> filteredWords;
    IEnumerable<string> res = "Contrary to popular belief, Lorem Ipsum is not simply random text It has roots in a piece of classical Latin literature from BC making it over years old Richard McClintock a Latin professor at Hampden-Sydney College in Virginia looked up one of the more obscure Latin words consectetur from a Lorem Ipsum passage, and going through the cites of the word in classical literature discovered the undoubtable source Lorem Ipsum comes from sections and of de Finibus Bonorum et Malorum The Extremes of Good and Evil by Cicero written in BC This book is a treatise on the theory of ethics very popular during the Renaissance The first line of Lorem Ipsum Lorem ipsum dolor sit amet comes from a line in section The standard chunk of Lorem Ipsum used since the is reproduced below for those interested Sections and from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form accompanied by English versions from the translation by H.Rackham".Split(' ').OrderBy(x => x);

    void Load()
    {
        ListWords.Clear();
        foreach(var word in res)
        {
            ListWords.Add(word);
            FilteredWords.Add(word);
        }
    }

    public void Search(string search)
    {
        if (string.IsNullOrWhiteSpace(search))
        {
            // If the search term is empty, reset to the full list
            FilteredWords.Clear();
            foreach (var item in ListWords)
            {
                FilteredWords.Add(item);
            }
        }
        else
        {
            // Otherwise, filter the list
            var result = ListWords
                .Where(x => x.Contains(search, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Update the filtered collection
            FilteredWords.Clear();
            foreach (var item in result)
            {
                FilteredWords.Add(item);
            }
        }

    }
}
