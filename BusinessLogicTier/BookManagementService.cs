using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicTier
{
    public class BookManagementService : System.EnterpriseServices.ServicedComponent, IBookManagementService
    {
        private string _loginUser = null;

        public void Authorize(string user, string password) 
        {
            Demo3TiersDataContext ctx = new Demo3TiersDataContext();

            var u = from lu in ctx.LoginUsers where lu.LoginName == user && lu.LoginPassword == password select lu;

            if (u.Count<LoginUser>() != 1)
            {
                _loginUser = null;
                throw new UserNotFoundException();
            }

            _loginUser = user;
        }

        public IList<DataTransferObjects.Book> FindBooks(string title)
        {
            //unauthorized users can not search
            if (_loginUser == null)
                throw new NotAuthorizedException();

            Demo3TiersDataContext ctx = new Demo3TiersDataContext();

            var books = from b in ctx.Books where b.Title.Contains(title) select new DataTransferObjects.Book() { Id = b.BookId, Title = b.Title, Author = b.Author, Price = b.Price };

            return books.ToList<DataTransferObjects.Book>();
        }

        public Guid AddBook(string title, string author, double price)
        {
            //unauthorized users can not search
            if (_loginUser == null)
                throw new NotAuthorizedException();

            //only admin user can add new book
            if (_loginUser != "admin")
                throw new NotAuthorizedException();

            Demo3TiersDataContext ctx = new Demo3TiersDataContext();
            Guid id = Guid.NewGuid();
            Book newBook = new Book() { BookId = id, Title = title, Author = author, Price = price };
            ctx.Books.InsertOnSubmit(newBook);
            ctx.SubmitChanges();

            return id;
        }
    }
}
