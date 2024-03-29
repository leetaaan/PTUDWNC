﻿namespace TatBlog.Core.Constraints
{
    public interface IPagedList
    {
        int PageCount { get; }
        int TotalItemCount { get; }
        int PageIndex { get; }
        int PageNumber { get; }
        int PageSize { get; }
        int HasPreviousPage { get; }
        int HasNextPage { get; }
        bool IsFirstPage { get; }
        bool IsLastPage { get; }
        int FirstItemIndex { get; }
        int LastItemIndex { get; }


    }
    public interface IPagedList<out T> : IPagedList, IEnumerable<T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
}