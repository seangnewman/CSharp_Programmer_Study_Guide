using System;
using System.Windows;
using System.Windows.Controls;

namespace Chap9_Validation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool allFieldsPopulated()
        {
            return ((txtEmail.Text.Length > 0) &&
                  (txtPhone.Text.Length > 0) &&
                  (txtDOB.Text.Length > 0) &&
                  (txtZip.Text.Length > 0) &&
                  (txtWebsite.Text.Length > 0)) ;
        }

        public void resetForm( TextBox txtBox)
        {
            txtBox.Text = string.Empty;
            frmButton.IsEnabled = false;
        }

        public MainWindow()
        {
            InitializeComponent();

            frmButton.IsEnabled = false;
        }

        private void frmButton_Click(object sender, RoutedEventArgs e)
        {
           

            // Your application must validate their information by using regular expression and must handle
            // exception in case the user enters invalid values.

            // Validate email information
            if(!TextValidation.TestEmail.IsEmail(txtEmail.Text))
            {
                resetForm(txtEmail);
                return;
            }

            if (!TextValidation.TestPhoneNumber.IsUsPhoneNumber(txtPhone.Text))
            {
                resetForm(txtPhone);
                return;
            }

            if (!DateTime.TryParse(txtDOB.Text, out var dt))
            {
                resetForm(txtDOB);
                return;
            }

            if (!TextValidation.TestZipCode.IsZipCode(txtZip.Text))
            {
                resetForm(txtZip);
                return;
            }

            if(!Uri.IsWellFormedUriString(txtWebsite.Text, UriKind.RelativeOrAbsolute))
            {
                resetForm(txtWebsite);
                return;
            }

            MessageBox.Show("Success");

        }

        private void txtEmail_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (allFieldsPopulated())
                frmButton.IsEnabled = true;
        }

        private void txtPhone_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (allFieldsPopulated())
                frmButton.IsEnabled = true;
        }

        private void txtDOB_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (allFieldsPopulated())
                frmButton.IsEnabled = true;
        }

        private void txtZip_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (allFieldsPopulated())
                frmButton.IsEnabled = true;
        }

        private void txtWebsite_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (allFieldsPopulated())
                frmButton.IsEnabled = true;
        }
    }
}
