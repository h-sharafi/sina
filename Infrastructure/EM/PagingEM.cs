using Application.Errors;
using Domain.ViewModels.Pagging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.EM
{
    public static class PagingEM
    {
        public static RetungPagingViewModel<T> Paging<T>(this IQueryable<T> PagingQury, int pageIndex, int pageSize) where T : class
        {
            pageSize = pageSize == 0 ? 12 : pageSize;
            var pagingQuryCount = PagingQury.Count();
            if (pagingQuryCount == 0) return new RetungPagingViewModel<T>
            {
                RetunIQueryableModel = PagingQury,
                PageIndex = 1,
                PageSize = pageSize,
                TotalPage = 1
            };
            var totalPage = (int)Math.Ceiling(pagingQuryCount / (double)pageSize);
            // if (pageIndex > totalPage) throw new RestException(System.Net.HttpStatusCode.BadRequest, "شماره صفحه بیش از اندازه مجاز می باشد");
            if (pageIndex > totalPage) pageIndex = totalPage;
            if(pageIndex == 0) pageIndex = 1;
            if (pageIndex < 1) throw new RestException(System.Net.HttpStatusCode.BadRequest, "شماره صفحه باید بیشتر از یک باشد");
            return new RetungPagingViewModel<T>
            {
                RetunIQueryableModel = PagingQury.Skip((pageIndex - 1) * pageSize).Take(pageSize),
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalPage = totalPage
            };
            // return PagingQury.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
