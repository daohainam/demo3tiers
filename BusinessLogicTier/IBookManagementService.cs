using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicTier
{
    interface IBookManagementService
    {
        void Authorize(string user, string password);
        IList<DataTransferObjects.Book> FindBooks(string title);
        Guid AddBook(string title, string author, double price);
    }
}
