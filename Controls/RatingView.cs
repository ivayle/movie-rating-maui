namespace MovieRatingApp.Controls
{
    public partial class RatingView : View
    {
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(ValueProperty), typeof(int), typeof(RatingView), default(int));

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly BindableProperty ColorProperty =
            BindableProperty.Create(nameof(ColorProperty), typeof(Color), typeof(RatingView), default(Color));

        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
    }
}
