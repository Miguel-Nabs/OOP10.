using System;
using System.Globalization;
using System.Windows.Forms;

namespace Artorius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Allow only whole numbers in the Amount textbox
            txtAmount.KeyPress += txtAmount_KeyPress;

            // Enable right-click row deletion
            dataGridView1.CellMouseDown +=
                dataGridView1_CellMouseDown;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Allow digits only in txtAmount
        private void txtAmount_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(
            object sender,
            EventArgs e)
        {
            // Requirement 1: Validate all input fields

            if (string.IsNullOrWhiteSpace(txtWishlistName.Text))
            {
                MessageBox.Show(
                    "Please enter a Wishlist Name!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtWishlistName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItem1.Text))
            {
                MessageBox.Show(
                    "Please enter Item 1!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtItem1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItem2.Text))
            {
                MessageBox.Show(
                    "Please enter Item 2!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtItem2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show(
                    "Please enter the Amount Range!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmount.Focus();
                return;
            }

            // Validate that the amount is a positive whole number
            decimal amount;

            if (!decimal.TryParse(
                    txtAmount.Text,
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out amount)
                || amount <= 0)
            {
                MessageBox.Show(
                    "Please enter a positive whole number only!",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmount.Focus();
                return;
            }

            // Requirement 2: Format amount as US currency
            string formattedAmount = amount.ToString(
                "C2",
                CultureInfo.GetCultureInfo("en-US"));

            // Requirement 4: Add a new independent row
            dataGridView1.Rows.Add(
                txtWishlistName.Text.Trim(),
                txtItem1.Text.Trim(),
                txtItem2.Text.Trim(),
                formattedAmount);

            // Requirement 3: Clear all textboxes after submission
            txtWishlistName.Clear();
            txtItem1.Clear();
            txtItem2.Clear();
            txtAmount.Clear();

            // Return focus to the Wishlist Name textbox
            txtWishlistName.Focus();
        }

        // Requirement 5: Right-click a row to delete it
        private void dataGridView1_CellMouseDown(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            // Ignore headers and non-right-click events
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
                return;

            // Ignore the empty new-record row
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
                return;

            // Select the row that was right-clicked
            dataGridView1.ClearSelection();

            dataGridView1.Rows[e.RowIndex].Selected = true;

            // Create a context menu
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem deleteItem =
                new ToolStripMenuItem("Delete Row");

            deleteItem.Click += (s, ev) =>
            {
                // Confirm before deleting the selected record
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item " +
                    "from your wishlist?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the targeted row
                    if (e.RowIndex < dataGridView1.Rows.Count &&
                        !dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }

                menu.Dispose();
            };

            menu.Items.Add(deleteItem);

            // Display the menu at the mouse cursor
            menu.Show(Cursor.Position);
        }
    }
}