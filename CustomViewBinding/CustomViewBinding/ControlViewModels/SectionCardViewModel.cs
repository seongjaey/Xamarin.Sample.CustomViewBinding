using CustomViewBinding.ViewModels;

namespace CustomViewBinding.ControlViewModels
{
    public class SectionCardViewModel : BindableBase
    {
        private string _sectionTitle;
        private string _sectionContent;

        /// <summary>
        /// 타이틀
        /// </summary>
        public string SectionTitle
        {
            get => _sectionTitle;
            set => SetProperty(ref _sectionTitle, value);
        }

        /// <summary>
        /// 내용
        /// </summary>
        public string SectionContent
        {
            get => _sectionContent;
            set => SetProperty(ref _sectionContent, value);
        }
    }
}