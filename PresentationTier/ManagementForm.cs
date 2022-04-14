using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicTier;

namespace PresentationTier
{
    public partial class ManagementForm : Form
    {
        private BookManagementService _bookService = null;

        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _bookService = new BookManagementService();
                    _bookService.Authorize(lf.UserName, lf.Password);
                }
                catch (UserNotFoundException)
                {
                    MessageBox.Show("User name or password is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IList<DataTransferObjects.Book> books = _bookService.FindBooks(txtSearchTerm.Text);

                dgvBookList.DataSource = books;
                sslStatus.Text = books.Count + " book(s) found";
            }
            catch (NotAuthorizedException)
            {
                MessageBox.Show("You are not allowed to do that", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void tsbNewBook_Click(object sender, EventArgs e)
        {
            try
            {
                EditBookForm ebf = new EditBookForm();

                if (ebf.ShowDialog() == DialogResult.OK)
                {
                    _bookService.AddBook(ebf.Title, ebf.Author, ebf.Price);

                    sslStatus.Text = "New book added";
                }
            }
            catch (NotAuthorizedException)
            {
                MessageBox.Show("You are not allowed to do that", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }
    }
}
