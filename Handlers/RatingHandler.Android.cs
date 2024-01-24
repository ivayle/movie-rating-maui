using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
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
        }

        protected override void DisconnectHandler(NativeRatingView platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }

        public static void MapValue(RatingHandler handler, RatingView virtualView)
        {
            handler.PlatformView.Value = virtualView.Value;
        }

        public static void MapColor(RatingHandler handler, RatingView virtualView)
        {
            handler.PlatformView.Color = virtualView.Color.ToPlatform();
        }
    }
}
