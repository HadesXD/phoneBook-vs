namespace Imenik
{
    partial class IzbrisiOsebo
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
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.imenikLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.priimekLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(35, 56);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(49, 17);
            this.selectLabel.TabIndex = 54;
            this.selectLabel.Text = "select:";
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(108, 53);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(243, 24);
            this.selectComboBox.TabIndex = 53;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.selectComboBox_SelectedIndexChanged);
            // 
            // imenikLabel
            // 
            this.imenikLabel.AutoSize = true;
            this.imenikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imenikLabel.Location = new System.Drawing.Point(34, 18);
            this.imenikLabel.Name = "imenikLabel";
            this.imenikLabel.Size = new System.Drawing.Size(57, 20);
            this.imenikLabel.TabIndex = 52;
            this.imenikLabel.Text = "Imenik";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(36, 297);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 26);
            this.deleteButton.TabIndex = 51;
            this.deleteButton.Text = "Izbrisi";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.Location = new System.Drawing.Point(106, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(245, 24);
            this.emailTextBox.TabIndex = 50;
            // 
            // telTextBox
            // 
            this.telTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telTextBox.Location = new System.Drawing.Point(106, 211);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(245, 24);
            this.telTextBox.TabIndex = 49;
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslovTextBox.Location = new System.Drawing.Point(106, 170);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(245, 24);
            this.naslovTextBox.TabIndex = 48;
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priimekTextBox.Location = new System.Drawing.Point(106, 131);
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.Size = new System.Drawing.Size(245, 24);
            this.priimekTextBox.TabIndex = 47;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTextBox.Location = new System.Drawing.Point(106, 92);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(245, 24);
            this.imeTextBox.TabIndex = 46;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(33, 253);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 45;
            this.emailLabel.Text = "Email:";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(33, 216);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(51, 17);
            this.telLabel.TabIndex = 44;
            this.telLabel.Text = "Tel. št:";
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Location = new System.Drawing.Point(33, 175);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(55, 17);
            this.naslovLabel.TabIndex = 43;
            this.naslovLabel.Text = "Naslov:";
            // 
            // priimekLabel
            // 
            this.priimekLabel.AutoSize = true;
            this.priimekLabel.Location = new System.Drawing.Point(33, 136);
            this.priimekLabel.Name = "priimekLabel";
            this.priimekLabel.Size = new System.Drawing.Size(58, 17);
            this.priimekLabel.TabIndex = 42;
            this.priimekLabel.Text = "Priimek:";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(33, 97);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(34, 17);
            this.imeLabel.TabIndex = 41;
            this.imeLabel.Text = "Ime:";
            // 
            // IzbrisiOsebo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 345);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.imenikLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(this.priimekTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.priimekLabel);
            this.Controls.Add(this.imeLabel);
            this.Name = "IzbrisiOsebo";
            this.Text = "IzbrisiOsebo";
            this.Load += new System.EventHandler(this.IzbrisiOsebo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label imenikLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label priimekLabel;
        private System.Windows.Forms.Label imeLabel;
    }
}