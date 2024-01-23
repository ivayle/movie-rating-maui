using CommunityToolkit.Mvvm.ComponentModel;
using MovieRatingApp.Models;
using System.Collections.ObjectModel;

namespace MovieRatingApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Movie> items =
        [
            new() { Title = "The Shawshank Redemption" },
            new() { Title = "12th Fail" },
            new() { Title = "The Godfather" },
            new() { Title = "The Dark Knight"},
            new() { Title = "Schindler's List" },
            new() { Title = "The Lord of the Rings: The Return of the King" },
            new() { Title = "The Godfather Part II" },
            new() { Title = "12 Angry Men" },
            new() { Title = "The Lord of the Rings: The Fellowship of the Ring" },
            new() { Title = "Pulp Fiction" },
            new() { Title = "Inception" },
            new() { Title = "Fight Club" },
            new() { Title = "Forrest Gump" },
            new() { Title = "The Lord of the Rings: The Two Towers" },
            new() { Title = "The Good, the Bad and the Ugly" },
        ];

        public MainViewModel()
        {
        }
    }
}
