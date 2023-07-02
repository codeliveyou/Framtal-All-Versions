using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FN.Framtal.UserControls
{
    /// <summary>
    /// Interaction logic for Chapter1.xaml
    /// </summary>
    public partial class Chapter1 : UserControl
    {

        public static readonly DependencyProperty ChapterNumberProperty = DependencyProperty.Register(nameof(ChapterNumber), typeof(string), typeof(Chapter1), new PropertyMetadata(OnChapterNumberPropertyChanged));
        public static readonly DependencyProperty ChapterTextProperty = DependencyProperty.Register(nameof(ChapterText), typeof(string), typeof(Chapter1), new PropertyMetadata(OnChapterTextPropertyChanged));
        public static readonly DependencyProperty ChapterBackgroundColorProperty = DependencyProperty.Register(nameof(ChapterBackgroundColor), typeof(Brush), typeof(Chapter1), new PropertyMetadata(OnChapterBackgroundColorPropertyChanged));
        public static readonly DependencyProperty ChapterSymbolBackgroundColorProperty = DependencyProperty.Register(nameof(ChapterSymbolBackgroundColor), typeof(Brush), typeof(Chapter1), new PropertyMetadata(OnChapterSymbolBackgroundColorPropertyChanged));
        public Brush ChapterBackgroundColor
        {
            get => GetValue(ChapterNumberProperty) as Brush;
            set => SetValue(ChapterNumberProperty, value);
        }
        public Brush ChapterSymbolBackgroundColor
        {
            get => GetValue(ChapterNumberProperty) as Brush;
            set => SetValue(ChapterNumberProperty, value);
        }
         public string ChapterNumber
        {
            get => GetValue(ChapterNumberProperty) as string;
            set => SetValue(ChapterNumberProperty, value);
        }

        public string ChapterText
        {
            get => GetValue(ChapterTextProperty) as string;
            set => SetValue(ChapterTextProperty, value);
        }

        public Chapter1()
        {
            InitializeComponent();
            //ChapterBackgroundColor = this.FindResource("MediumBrush") as Brush;
            //ChapterSymbolBackgroundColor = this.FindResource("DarkBrush") as Brush;
        }
        private static void OnChapterBackgroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        //    ((Chapter1)d).ChapterNumberBorder.Background = e.NewValue as Brush;

        }
        private static void OnChapterSymbolBackgroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        //    ((Chapter1)d).ChapterSymbol.Fill = e.NewValue as Brush;

        }
        private static void OnChapterNumberPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter1) d).ChapterNumberTextBlock.Text = e.NewValue as string;
        }

        private static void OnChapterTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Chapter1) d).ChapterTextBlock.Text = e.NewValue as string;
        }
    }
}
