using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransferObjects
{
    public class Book
    {
        public Guid Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }
    }
}
