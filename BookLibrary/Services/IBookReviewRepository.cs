using BookLibrary.Data;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IBookReviewRepository
    {
        IEnumerable<BookReview> All { get; }
        IEnumerable<BookReview> ByTitle(string title);
    }
}
