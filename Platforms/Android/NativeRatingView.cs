using Android.Content;
using Android.Widget;
using AndroidX.CoordinatorLayout.Widget;
using MovieRatingApp.Controls;
using Color = Android.Graphics.Color;

namespace MovieRatingApp.Platforms.Android
{
    public class NativeRatingView : CoordinatorLayout
    {
        private const int Size = 5;
        private List<TextView> _labels;

        public int Value { get; set; }
        public Color Color { get; set; }

        public NativeRatingView(Context context, RatingView virtualView) : base(context)
        {
            _labels = [];

            for (int i = 0; i < Size; i++)
            {
                var label = new TextView(context) { Tag = i };
                label.SetX(i * 40);
                label.SetBackgroundColor(Color);

                label.Text = i <= Value ? "\u2605" : "\u2606";

                _labels.Add(label);

                label.Click += Label_Click;

                AddView(label);
            }
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            TextView? label = sender as TextView;
            int value = (int)label.Tag;

            for (int i = 0; i < _labels.Count; i++)
            {
                _labels[i].Text = i <= value ? "\u2605" : "\u2606";
            }

            Value = value;
        }
    }
}
