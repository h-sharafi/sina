using System.Collections.Generic;
using Domain;

namespace Domain.ViewModels
{
  public class ReturnFileFilter
    {
        public ICollection<File> Files { get; set; }
        public short TotlaPage { get; set; }
        public int TotalCount { get; set; }
    }
}