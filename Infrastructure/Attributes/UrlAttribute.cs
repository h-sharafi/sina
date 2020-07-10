using System;

namespace Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

    public class UrlAttribute : Attribute
    {
        public UrlAttribute(string Title)
        {
            this.DisplayTitle = Title;
        }
        public string DisplayTitle { get; set; }
    }
}