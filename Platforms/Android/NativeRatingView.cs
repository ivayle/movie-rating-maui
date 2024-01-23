using Android.Content;
using AndroidX.CoordinatorLayout.Widget;
using MovieRatingApp.Controls;
using static Android.Provider.MediaStore;

namespace MovieRatingApp.Platforms.Android
{
    public class NativeRatingView : CoordinatorLayout
    {
        public NativeRatingView(Context context, RatingView virtualView) : base(context)
        {
            
        }
    }
}
