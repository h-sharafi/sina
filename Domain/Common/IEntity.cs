using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEntity<T>
    {
        T Id { get; set; }
        /// <summary>
        /// اخرین ویرایش سند
        /// </summary>
        //DateTime LastModificationDate { get; set; }
        bool IsActive { get; set; }
        DateTime CreationTime {get; set;}
         byte DisplaySort  { get; set; }
    }
}
