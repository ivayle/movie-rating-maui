using MovieRatingApp.Controls;
using Grid = Microsoft.UI.Xaml.Controls.Grid;

namespace MovieRatingApp.Platforms.Windows
{
    public class NativeRatingView : Grid, IDisposable
    {
        public int Value { get; set; }
        public Color Color { get; set; }

        public NativeRatingView(RatingView virtualView)
        {
        }

        public void Dispose()
        {
        }
    }
}
