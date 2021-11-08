using System;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class Add_Room : Form
    {
        public string RoomName
        {
            get => Name_Text_Box.Text;
            set => Name_Text_Box.Text = value;
        }

        public string RoomDescription
        {
            get => Description_Text_Box.Text;
            set => Description_Text_Box.Text = value;
        }

        public Add_Room()
        {
            InitializeComponent();
        }

        private void Name_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Add_Button.Enabled = ( !string.IsNullOrEmpty(RoomName) && !string.IsNullOrEmpty(RoomDescription) );
        }

        private void Description_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Add_Button.Enabled = (!string.IsNullOrEmpty(RoomName) && !string.IsNullOrEmpty(RoomDescription));
        }
    }
}
