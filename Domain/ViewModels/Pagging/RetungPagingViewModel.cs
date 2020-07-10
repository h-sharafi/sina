using System.Linq;

namespace Domain.ViewModels.Pagging
{
    public class RetungPagingViewModel<T>
    {
        public IQueryable<T> RetunIQueryableModel { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalPage { get; set; }
    }
}