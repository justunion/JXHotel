﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXHotel.Domain.Repository
{
    /// <summary>
    /// 排序方式
    /// </summary>
    public enum SortOrder
    {
        /// <summary>
        /// Indicates that the sorting style is not specified.
        /// </summary>
        Unspecified = -1,
        /// <summary>
        /// Indicates an ascending sorting.
        /// </summary>
        Ascending = 0,
        /// <summary>
        /// Indicates a descending sorting.
        /// </summary>
        Descending = 1
    }
}
