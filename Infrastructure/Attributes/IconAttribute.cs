using System;

namespace Infrastructure.Attributes
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class IconAttribute : System.Attribute
    {
        public IconAttribute(string Title)
        {
            this.DisplayTitle = Title;
        }
        public string DisplayTitle { get; set; }
    }
}