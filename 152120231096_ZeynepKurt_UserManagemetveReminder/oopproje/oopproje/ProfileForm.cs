using System;
using System.Windows.Forms;

namespace oopproje
{
    public partial class ProfileForm : Form
    {
        private User currentUser;

        public ProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = $"Ho� geldin, {user.Username}";
        }
    }
}
