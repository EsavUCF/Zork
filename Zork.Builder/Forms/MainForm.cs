using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        #region Global Variable declarations

        private WorldViewModel _viewModel;

        private WorldViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    roomsBindingSource.DataSource = _viewModel;
                }
            }
        }

        NeighborForm f2 = new NeighborForm();

        #endregion

        private void ShowErrorMessage(string s)
        {
            MessageBox.Show(s, "Zork Builder - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                try
                {
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                    Add.Enabled = true;
                    Remove.Enabled = true;
                    North_Box.Enabled = true;
                    South_Box.Enabled = true;
                    East_Box.Enabled = true;
                    West_box.Enabled = true;
                    Starting_Location_Checkbox.Enabled = true;
                    Room_Name_Box.Enabled = true;                    
                    Room_Desc_Box.Enabled = true;
                    Build_File_Button.Enabled = true;
                }
                catch (Exception exception)
                {
                    ShowErrorMessage($"{exception} occured while attempting to open \"{openFileDialog.FileName}\"");
                }
            }
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            using (Add_Room AddRoom = new Add_Room())
            {
                if (AddRoom.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(AddRoom.RoomName) || string.IsNullOrEmpty(AddRoom.RoomDescription))
                    {
                        ShowErrorMessage("Room name or description is empty.");
                    }

                    Room room = new Room { Name = AddRoom.RoomName, Description = AddRoom.RoomDescription };

                    try
                    {
                        _viewModel.Rooms.Add(room);
                    }
                    catch(Exception exception)
                    {
                        ShowErrorMessage($"{exception} occured when attempting to add a room to the Rooms List.");
                    }
                    
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to quit Zork Builder?";
            const string caption = "The adventure must continue!";

            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                try
                {
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                }
                catch (Exception exception)
                {
                    ShowErrorMessage($"{exception} occured while attempting to open \"{openFileDialog.FileName}\"");
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Build_File_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Remove_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void North_Box_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void West_box_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void South_Box_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void East_Box_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        
    }
}
