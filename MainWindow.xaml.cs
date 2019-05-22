using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaFindControl
{
    public class MainWindow : Window
    {
        private readonly SampleUserControl sampleUserControl;
        private readonly TextBlock textBlock;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.textBlock = this.FindControl<TextBlock>("textBlock");
            this.sampleUserControl = this.FindControl<SampleUserControl>("sampleUserControl");

            if (textBlock == null)
            {
                throw new Exception("Textblock was not found");
            }

            if (sampleUserControl == null)
            {
                throw new Exception("SampleUserControl was not found");
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
