using Android.Content;
using AndroidX.CoordinatorLayout.Widget;
using MovieRatingApp.Controls;

namespace MovieRatingApp.Platforms.Android
{
    public class NativeRatingView : CoordinatorLayout
    {
        public NativeRatingView(Context context, RatingView virtualView) : base(context)
        {
        }
    }
}
