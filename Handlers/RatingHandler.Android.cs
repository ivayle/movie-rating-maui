#nullable enable
using Microsoft.Maui.Handlers;
using MovieRatingApp.Controls;
using MovieRatingApp.Platforms.Android;

namespace MovieRatingApp.Handlers
{
    public partial class RatingHandler : ViewHandler<RatingView, NativeRatingView>
    {
        protected override NativeRatingView CreatePlatformView() => new NativeRatingView(Context, VirtualView);

        protected override void ConnectHandler(NativeRatingView platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(NativeRatingView platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }
    }
}
