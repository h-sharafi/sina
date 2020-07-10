using System.Collections.Generic;

namespace Domain
{
    public class NavbarViewModel
    {
        public int CommrntCount
        {
            get
            {
                return Comments.Count;
            }
        }
        public List<NavbarCommentViewModel> Comments { get; set; }
    }
    public class NavbarCommentViewModel
    {
        public short Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string DateTime { get; set; }

    }

}