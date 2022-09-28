using BookLibrary.Data;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IReviewAggregator
    {
        IEnumerable<BookReview> Summary { get; }
    }
}
