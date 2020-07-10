
using System.Collections.Generic;

namespace Domain.ViewModels

{
    public class SelectFileCategoryViewModel
    {
        // short selectedId , List<FileCategory> fileCategorys
        public short SelectedId { get; set; }
        public List<FileCategory> FileCategorys{ get; set; }
        public string SelectFileCategoryCls { get; set; }
    }
}