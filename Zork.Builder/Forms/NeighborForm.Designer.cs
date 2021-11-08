
namespace Zork.Builder
{
    partial class NeighborForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NeighborFormLabel = new System.Windows.Forms.Label();
            this.Neighbor_Dropdown = new System.Windows.Forms.ComboBox();
            this.NeighborForm_OK = new System.Windows.Forms.Button();
            this.Cancel_Button_NeighborForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeighborFormLabel
            // 
            this.NeighborFormLabel.AutoSize = true;
            this.NeighborFormLabel.Location = new System.Drawing.Point(75, 11);
            this.NeighborFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NeighborFormLabel.Name = "NeighborFormLabel";
            this.NeighborFormLabel.Size = new System.Drawing.Size(197, 17);
            this.NeighborFormLabel.TabIndex = 0;
            this.NeighborFormLabel.Text = "Assign Neighbor For Direction";
            // 
            // Neighbor_Dropdown
            // 
            this.Neighbor_Dropdown.FormattingEnabled = true;
            this.Neighbor_Dropdown.Location = new System.Drawing.Point(95, 31);
            this.Neighbor_Dropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Neighbor_Dropdown.Name = "Neighbor_Dropdown";
            this.Neighbor_Dropdown.Size = new System.Drawing.Size(160, 24);
            this.Neighbor_Dropdown.TabIndex = 1;
            // 
            // NeighborForm_OK
            // 
            this.NeighborForm_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NeighborForm_OK.Location = new System.Drawing.Point(78, 63);
            this.NeighborForm_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NeighborForm_OK.Name = "NeighborForm_OK";
            this.NeighborForm_OK.Size = new System.Drawing.Size(100, 28);
            this.NeighborForm_OK.TabIndex = 2;
            this.NeighborForm_OK.Text = "OK";
            this.NeighborForm_OK.UseVisualStyleBackColor = true;
            this.NeighborForm_OK.Click += new System.EventHandler(this.NeighborForm_OK_Click);
            // 
            // Cancel_Button_NeighborForm
            // 
            this.Cancel_Button_NeighborForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button_NeighborForm.Location = new System.Drawing.Point(186, 63);
            this.Cancel_Button_NeighborForm.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Button_NeighborForm.Name = "Cancel_Button_NeighborForm";
            this.Cancel_Button_NeighborForm.Size = new System.Drawing.Size(100, 28);
            this.Cancel_Button_NeighborForm.TabIndex = 3;
            this.Cancel_Button_NeighborForm.Text = "Cancel";
            this.Cancel_Button_NeighborForm.UseVisualStyleBackColor = true;
            // 
            // NeighborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 98);
            this.Controls.Add(this.Cancel_Button_NeighborForm);
            this.Controls.Add(this.NeighborForm_OK);
            this.Controls.Add(this.Neighbor_Dropdown);
            this.Controls.Add(this.NeighborFormLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NeighborForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeighborForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NeighborFormLabel;
        private System.Windows.Forms.ComboBox Neighbor_Dropdown;
        private System.Windows.Forms.Button NeighborForm_OK;
        private System.Windows.Forms.Button Cancel_Button_NeighborForm;
    }
}