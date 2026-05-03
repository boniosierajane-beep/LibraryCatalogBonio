using LibraryCatalog.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryCatalog.Models
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();

            books.Add(new Book("978-0131103627", "The C Programming Language", "Brian Kernighan", 1978, 5));
            books.Add(new Book("978-0201633610", "Design Patterns", "Erich Gamma", 1994, 3));
            books.Add(new Book("978-0132350884", "Clean Code", "Robert C. Martin", 2008, 4));
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ISBN.Text) ||
                string.IsNullOrWhiteSpace(TITLE.Text) ||
                string.IsNullOrWhiteSpace(AUTHOR.Text))
            {
                MessageBox.Show("Please fill in ISBN, Title, and Author.");
                return;
            }

            Book newBook;

            if (string.IsNullOrWhiteSpace(PUBLISHED.Text) &&
                string.IsNullOrWhiteSpace(COPIES.Text))
            {
                newBook = new Book(ISBN.Text, TITLE.Text, AUTHOR.Text);
            }
            else
            {
                if (int.TryParse(PUBLISHED.Text, out int year) &&
                    int.TryParse(COPIES.Text, out int copies))
                {
                    newBook = new Book(ISBN.Text, TITLE.Text, AUTHOR.Text, year, copies);
                }
                else
                {
                    MessageBox.Show("Invalid Year or Copies format.");
                    return;
                }
            }

            books.Add(newBook);
            RefreshList();
            ClearInputs();
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Removed txtDetails display
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Book selectedBook = books[listBox1.SelectedIndex];

                if (!selectedBook.BorrowCopy())
                {
                    MessageBox.Show("No copies available!");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                books[listBox1.SelectedIndex].ReturnCopy();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                books.RemoveAt(listBox1.SelectedIndex);
                RefreshList();
            }
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (var b in books)
            {
                listBox1.Items.Add($"{b.Title} [{b.ISBN}]");
            }
        }

        private void ClearInputs()
        {
            ISBN.Clear();
            TITLE.Clear();
            AUTHOR.Clear();
            PUBLISHED.Clear();
            COPIES.Clear();
            ISBN.Focus();
        }
    }
}