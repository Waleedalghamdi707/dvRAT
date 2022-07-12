
namespace dvrat.modules
{
    partial class rename_dialog
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
            this.rname_fl_button = new System.Windows.Forms.Button();
            this.textBox_fr_fl_nm_chng = new System.Windows.Forms.TextBox();
            this.old_name_fl_label = new System.Windows.Forms.Label();
            this.new_name_fl_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rname_fl_button
            // 
            this.rname_fl_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rname_fl_button.Location = new System.Drawing.Point(12, 86);
            this.rname_fl_button.Name = "rname_fl_button";
            this.rname_fl_button.Size = new System.Drawing.Size(369, 23);
            this.rname_fl_button.TabIndex = 0;
            this.rname_fl_button.Text = "rename";
            this.rname_fl_button.UseVisualStyleBackColor = true;
            this.rname_fl_button.Click += new System.EventHandler(this.rname_fl_button_Click);
            // 
            // textBox_fr_fl_nm_chng
            // 
            this.textBox_fr_fl_nm_chng.BackColor = System.Drawing.Color.Black;
            this.textBox_fr_fl_nm_chng.ForeColor = System.Drawing.Color.White;
            this.textBox_fr_fl_nm_chng.Location = new System.Drawing.Point(12, 60);
            this.textBox_fr_fl_nm_chng.Name = "textBox_fr_fl_nm_chng";
            this.textBox_fr_fl_nm_chng.Size = new System.Drawing.Size(369, 20);
            this.textBox_fr_fl_nm_chng.TabIndex = 1;
            // 
            // old_name_fl_label
            // 
            this.old_name_fl_label.AutoSize = true;
            this.old_name_fl_label.Location = new System.Drawing.Point(13, 13);
            this.old_name_fl_label.Name = "old_name_fl_label";
            this.old_name_fl_label.Size = new System.Drawing.Size(0, 13);
            this.old_name_fl_label.TabIndex = 2;
            // 
            // new_name_fl_label
            // 
            this.new_name_fl_label.AutoSize = true;
            this.new_name_fl_label.Location = new System.Drawing.Point(12, 30);
            this.new_name_fl_label.Name = "new_name_fl_label";
            this.new_name_fl_label.Size = new System.Drawing.Size(10, 13);
            this.new_name_fl_label.TabIndex = 3;
            this.new_name_fl_label.Text = " ";
            // 
            // rename_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 117);
            this.Controls.Add(this.new_name_fl_label);
            this.Controls.Add(this.old_name_fl_label);
            this.Controls.Add(this.textBox_fr_fl_nm_chng);
            this.Controls.Add(this.rname_fl_button);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "rename_dialog";
            this.Text = "rename dialog";
            this.Load += new System.EventHandler(this.rename_dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rname_fl_button;
        private System.Windows.Forms.TextBox textBox_fr_fl_nm_chng;
        private System.Windows.Forms.Label old_name_fl_label;
        private System.Windows.Forms.Label new_name_fl_label;
    }
}