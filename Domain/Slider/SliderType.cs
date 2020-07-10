using System.Collections.Generic;

namespace Domain
{
    public class SliderType :AuditableEntity<short>
    {
        public ICollection<Slider> Sliders { get; set; }
        public string Name { get; set; }
        public string SampleHtml { get; set; }
        public short Interval { get; set; }
        public bool Keyboard { get; set; }
        public SliderCarouselType SliderCarouselType { get; set; }
    }
    public enum SliderCarouselType{
        SlidesOnly, 
        PreviousAndNext,
        Indicator, 
        Caption


    }
}