using System.Collections.Generic;
using System.Drawing;
using CustomViewBinding.ControlViewModels;

namespace CustomViewBinding.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private SectionCardViewModel _section1;
        private SectionCardViewModel _section2;
        private string _bindingTitle;
        private string _bindingContent;
        private KeyValuePair<string, string> _randomObject1;
        private Point _randomObject2;

        /// <summary>
        /// Viewmodel of Section1. for SectionCardView
        /// </summary>
        public SectionCardViewModel Section1
        {
            get => _section1;
            set => SetProperty(ref _section1,  value);
        }

        /// <summary>
        ///  Viewmodel of Section2. for SectionCardView.
        /// </summary>
        public SectionCardViewModel Section2
        {
            get => _section2;
            set => SetProperty(ref _section2, value);
        }


        /// <summary>
        /// Section title for BindableSectionCardView.
        /// </summary>
        public string BindingTitle
        {
            get => _bindingTitle;
            set => SetProperty(ref _bindingTitle, value);
        }

        /// <summary>
        /// Section content for BindableSectionCardView.
        /// </summary>
        public string BindingContent
        {
            get => _bindingContent;
            set => SetProperty(ref _bindingContent, value);
        }

        /// <summary>
        /// First sample object to show how to bind with random object with path.
        /// </summary>
        public KeyValuePair<string, string> RandomObject1
        {
            get => _randomObject1;
            set => SetProperty(ref _randomObject1, value);
        }

        /// <summary>
        /// Second sample object to show how to bind with random object with path.
        /// </summary>
        public Point RandomObject2
        {
            get => _randomObject2;
            set => SetProperty(ref _randomObject2, value);
        }


        public MainPageViewModel()
        {
            Section1 = new SectionCardViewModel()
                {SectionTitle = "Section 1", SectionContent = "Section content. blahblah"};
            Section2 = new SectionCardViewModel() {SectionTitle = "Section 2", SectionContent = "BlahBlah section 2"};


            BindingTitle = "Bound title.";
            BindingContent = "Bound content.";

            RandomObject1 = new KeyValuePair<string, string>("Rand1 Title.", "Rand1 Content.");
            RandomObject2 = new Point(100, 10000);

        }
    }
}