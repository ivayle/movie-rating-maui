using Android.Content;
using AndroidX.CoordinatorLayout.Widget;
using MovieRatingApp.Controls;

namespace MovieRatingApp.Platforms.Android
{
    public class NativeRatingView : CoordinatorLayout
    {
        public int Value { get; set; }
        public Color Color { get; set; }

        public NativeRatingView(Context context, RatingView virtualView) : base(context)
        {
        }
    }
}
