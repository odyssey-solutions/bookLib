using BookLibrary.Data;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary.Services
{
    public class BookReviewRepository : IBookReviewRepository
    {
        private readonly BookLibraryContext _dbContext;

        public BookReviewRepository(BookLibraryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BookReview> All => _dbContext.BookReviews;
        public IEnumerable<BookReview> ByTitle(string title) => _dbContext.BookReviews.Where(r => r.Title == title);
    }
}
