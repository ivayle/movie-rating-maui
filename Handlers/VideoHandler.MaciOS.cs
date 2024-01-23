#nullable enable
using Microsoft.Maui.Handlers;
using VideoDemos.Controls;
using VideoDemos.Platforms.MaciOS;

namespace MovieRatingApp.Handlers
{
    public partial class RatingHandler : ViewHandler<Video, MauiVideoPlayer>
    {
        protected override MauiVideoPlayer CreatePlatformView() => new MauiVideoPlayer(VirtualView);

        protected override void ConnectHandler(MauiVideoPlayer platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(MauiVideoPlayer platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }

        public static void MapAreTransportControlsEnabled(RatingHandler handler, Video video)
        {
            handler?.PlatformView.UpdateTransportControlsEnabled();
        }

        public static void MapSource(RatingHandler handler, Video video)
        {
            handler?.PlatformView.UpdateSource();
        }

        public static void MapIsLooping(RatingHandler handler, Video video)
        {
            handler.PlatformView?.UpdateIsLooping();
        }

        public static void MapPosition(RatingHandler handler, Video video)
        {
            handler?.PlatformView.UpdatePosition();
        }

        public static void MapUpdateStatus(RatingHandler handler, Video video, object? args)
        {
            handler.PlatformView?.UpdateStatus();
        }

        public static void MapPlayRequested(RatingHandler handler, Video video, object? args)
        {
            if (args is not VideoPositionEventArgs)
                return;

            TimeSpan position = ((VideoPositionEventArgs)args).Position;
            handler.PlatformView?.PlayRequested(position);
        }

        public static void MapPauseRequested(RatingHandler handler, Video video, object? args)
        {
            if (args is not VideoPositionEventArgs)
                return;

            TimeSpan position = ((VideoPositionEventArgs)args).Position;
            handler.PlatformView?.PauseRequested(position);
        }

        public static void MapStopRequested(RatingHandler handler, Video video, object? args)
        {
            if (args is not VideoPositionEventArgs)
                return;

            TimeSpan position = ((VideoPositionEventArgs)args).Position;
            handler.PlatformView?.StopRequested(position);
        }
    }
}
