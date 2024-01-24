using Grid = Microsoft.UI.Xaml.Controls.Grid;
using Label = Microsoft.UI.Xaml.Controls.TextBlock;

namespace MovieRatingApp.Platforms.Windows
{
    public class NativeRatingView : Grid, IDisposable
    {
        private const int Size = 5;
        private List<Label> _labels;

        public int Value { get; set; }
        public Color? Color { get; set; }

        public NativeRatingView()
        {
            _labels = [];

            for (int i = 0; i < Size; i++)
            {
                ColumnDefinitions.Add(new Microsoft.UI.Xaml.Controls.ColumnDefinition() { MaxWidth = 30 });
                var label = new Label() { Tag = i, FontSize = 38 };

                label.Text = i <= Value ? "\u2605" : "\u2606";

                _labels.Add(label);

                label.Tapped += Label_Tapped;

                SetColumn(label, i);
                Children.Add(label);
            }
        }

        private void Label_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Label? label = sender as Label;
            int value = (int)label.Tag;

            for (int i = 0; i < _labels.Count; i++)
            {
                _labels[i].Text = i <= value ? "\u2605" : "\u2606";
            }

            Value = value;
        }

        public void Dispose()
        {
            foreach (var label in _labels)
            {
                label.Tapped -= Label_Tapped;
            }
        }
    }
}
