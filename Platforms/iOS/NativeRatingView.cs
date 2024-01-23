using MovieRatingApp.Controls;
using UIKit;

namespace MovieRatingApp.Platforms.MaciOS
{
    public class NativeRatingView : UIView
    {
        public int Value { get; set; }
        public Color Color { get; set; }

        public NativeRatingView(RatingView virtualView)
        {
        }
    }
}
