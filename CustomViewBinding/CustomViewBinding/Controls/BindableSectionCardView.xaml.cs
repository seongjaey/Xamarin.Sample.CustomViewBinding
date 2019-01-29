using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomViewBinding.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindableSectionCardView : ContentView
    {

        /// <summary>
        /// Section title bindable property
        /// </summary>
        public static readonly BindableProperty SectionTitleProperty = BindableProperty.Create(nameof(SectionTitle),
            typeof(string), typeof(BindableSectionCardView), "Section title place holder");



        /// <summary>
        /// section title
        /// </summary>
        public string SectionTitle
        {
            get => (string) GetValue(SectionTitleProperty);
            set => SetValue(SectionTitleProperty, value);
        }


        /// <summary>
        /// Section content bindable property
        /// </summary>
        public static readonly BindableProperty SectionContentProperty = BindableProperty.Create(nameof(SectionContent),
            typeof(string), typeof(BindableSectionCardView), "content place holder");



        /// <summary>
        /// section content
        /// </summary>
        public string SectionContent
        {
            get => (string)GetValue(SectionContentProperty);
            set => SetValue(SectionContentProperty, value);
        }




        public BindableSectionCardView()
        {
            InitializeComponent();
        }
    }
}