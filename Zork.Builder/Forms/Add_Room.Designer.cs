
namespace Zork.Builder.Forms
{
    partial class Add_Room
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
            System.Windows.Forms.Label Name_Label;
            System.Windows.Forms.Label label1;
            this.Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Description_Text_Box = new System.Windows.Forms.TextBox();
            Name_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Location = new System.Drawing.Point(13, 3);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new System.Drawing.Size(45, 17);
            Name_Label.TabIndex = 3;
            Name_Label.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 17);
            label1.TabIndex = 5;
            label1.Text = "Description";
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.Location = new System.Drawing.Point(12, 26);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.Size = new System.Drawing.Size(413, 22);
            this.Name_Text_Box.TabIndex = 0;
            this.Name_Text_Box.TextChanged += new System.EventHandler(this.Name_Text_Box_TextChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_Button.Enabled = false;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(139, 158);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(82, 32);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(227, 158);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(82, 32);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Description_Text_Box
            // 
            this.Description_Text_Box.Location = new System.Drawing.Point(12, 83);
            this.Description_Text_Box.Multiline = true;
            this.Description_Text_Box.Name = "Description_Text_Box";
            this.Description_Text_Box.Size = new System.Drawing.Size(413, 69);
            this.Description_Text_Box.TabIndex = 4;
            this.Description_Text_Box.TextChanged += new System.EventHandler(this.Description_Text_Box_TextChanged);
            // 
            // Add_Room
            // 
            this.AcceptButton = this.Add_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 200);
            this.Controls.Add(label1);
            this.Controls.Add(this.Description_Text_Box);
            this.Controls.Add(Name_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Name_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Text_Box;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox Description_Text_Box;
    }
}