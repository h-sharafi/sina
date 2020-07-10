
using System;

namespace Infrastructure.Attributes
{

    
    public class TitleAttribute : System.Attribute
    {
        public TitleAttribute(string Title)
        {
            this.DisplayTitle = Title;
        }

        public string DisplayTitle { get; }
    }
    public class KeyAttribute : Attribute
    {
        public KeyAttribute(string Title)
        {
            this.DisplayTitle = Title;
        }

        public string DisplayTitle { get; }
    }
  

    public class ChildActionOnlyAttribute : System.Attribute
    {
        public ChildActionOnlyAttribute()
        {

        }
    }
    public class actionNameAttribute : System.Attribute
    {
      public actionNameAttribute(string actionName)
      {
             this.DisplayTitle = actionName;
      }
      public string DisplayTitle { get; }
    }

}