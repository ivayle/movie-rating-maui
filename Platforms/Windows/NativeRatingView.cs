using MovieRatingApp.Controls;
using Grid = Microsoft.UI.Xaml.Controls.Grid;

namespace MovieRatingApp.Platforms.Windows
{
    public class NativeRatingView : Grid, IDisposable
    {
        public NativeRatingView(RatingView virtualView)
        {
        }

        public void Dispose()
        {
        }
    }
}
