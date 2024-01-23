#if IOS || MACCATALYST
using PlatformView = MovieRatingApp.Platforms.MaciOS.NativeRatingView;
#elif ANDROID
using PlatformView = MovieRatingApp.Platforms.Android.NativeRatingView;
#elif WINDOWS
using PlatformView = MovieRatingApp.Platforms.Windows.NativeRatingView;
#elif (NETSTANDARD || !PLATFORM) || (NET8_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

using Microsoft.Maui.Handlers;
using MovieRatingApp.Controls;

namespace MovieRatingApp.Handlers
{
    public partial class RatingHandler
    {
        public static IPropertyMapper<RatingView, RatingHandler> PropertyMapper = new PropertyMapper<RatingView, RatingHandler>(ViewHandler.ViewMapper)
        {
            [nameof(RatingView.Value)] = MapValue,
            [nameof(RatingView.Color)] = MapColor,
        };

        public static CommandMapper<RatingView, RatingHandler> CommandMapper = new(ViewCommandMapper)
        {
            //[nameof(Video.UpdateStatus)] = MapUpdateStatus,
            //[nameof(Video.PlayRequested)] = MapPlayRequested,
            //[nameof(Video.PauseRequested)] = MapPauseRequested,
            //[nameof(Video.StopRequested)] = MapStopRequested
        };

        public RatingHandler() : base(PropertyMapper, CommandMapper)
        {
        }
    }
}
