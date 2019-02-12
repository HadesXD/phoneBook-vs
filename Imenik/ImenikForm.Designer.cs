namespace Imenik
{
    partial class ImenikForm
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
            this.novImenikTextBox = new System.Windows.Forms.TextBox();
            this.imenikButton = new System.Windows.Forms.Button();
            this.novImenikLabel = new System.Windows.Forms.Label();
            this.izberiImenikLabel = new System.Windows.Forms.Label();
            this.izberiImenikComboBox = new System.Windows.Forms.ComboBox();
            this.imenikGroupBox = new System.Windows.Forms.GroupBox();
            this.izbrisiOseboButton = new System.Windows.Forms.Button();
            this.urdiOseboButton = new System.Windows.Forms.Button();
            this.dodajOseboButton = new System.Windows.Forms.Button();
            this.imenikRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imeSortButton = new System.Windows.Forms.Button();
            this.priimenkSortButton = new System.Windows.Forms.Button();
            this.imenikGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // novImenikTextBox
            // 
            this.novImenikTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.novImenikTextBox.Location = new System.Drawing.Point(393, 32);
            this.novImenikTextBox.Name = "novImenikTextBox";
            this.novImenikTextBox.Size = new System.Drawing.Size(158, 24);
            this.novImenikTextBox.TabIndex = 12;
            // 
            // imenikButton
            // 
            this.imenikButton.Location = new System.Drawing.Point(618, 30);
            this.imenikButton.Name = "imenikButton";
            this.imenikButton.Size = new System.Drawing.Size(188, 26);
            this.imenikButton.TabIndex = 11;
            this.imenikButton.Text = "Dodaj Imenik";
            this.imenikButton.UseVisualStyleBackColor = true;
            this.imenikButton.Click += new System.EventHandler(this.imenikButton_Click);
            // 
            // novImenikLabel
            // 
            this.novImenikLabel.AutoSize = true;
            this.novImenikLabel.Location = new System.Drawing.Point(297, 35);
            this.novImenikLabel.Name = "novImenikLabel";
            this.novImenikLabel.Size = new System.Drawing.Size(81, 17);
            this.novImenikLabel.TabIndex = 10;
            this.novImenikLabel.Text = "Nov imenik:";
            // 
            // izberiImenikLabel
            // 
            this.izberiImenikLabel.AutoSize = true;
            this.izberiImenikLabel.Location = new System.Drawing.Point(23, 35);
            this.izberiImenikLabel.Name = "izberiImenikLabel";
            this.izberiImenikLabel.Size = new System.Drawing.Size(90, 17);
            this.izberiImenikLabel.TabIndex = 9;
            this.izberiImenikLabel.Text = "Izberi imenik:";
            // 
            // izberiImenikComboBox
            // 
            this.izberiImenikComboBox.FormattingEnabled = true;
            this.izberiImenikComboBox.Location = new System.Drawing.Point(119, 32);
            this.izberiImenikComboBox.Name = "izberiImenikComboBox";
            this.izberiImenikComboBox.Size = new System.Drawing.Size(158, 24);
            this.izberiImenikComboBox.TabIndex = 8;
            this.izberiImenikComboBox.SelectedIndexChanged += new System.EventHandler(this.izberiImenikComboBox_SelectedIndexChanged);
            // 
            // imenikGroupBox
            // 
            this.imenikGroupBox.Controls.Add(this.priimenkSortButton);
            this.imenikGroupBox.Controls.Add(this.imeSortButton);
            this.imenikGroupBox.Controls.Add(this.izbrisiOseboButton);
            this.imenikGroupBox.Controls.Add(this.urdiOseboButton);
            this.imenikGroupBox.Controls.Add(this.dodajOseboButton);
            this.imenikGroupBox.Controls.Add(this.imenikRichTextBox);
            this.imenikGroupBox.Location = new System.Drawing.Point(17, 83);
            this.imenikGroupBox.Name = "imenikGroupBox";
            this.imenikGroupBox.Size = new System.Drawing.Size(795, 423);
            this.imenikGroupBox.TabIndex = 7;
            this.imenikGroupBox.TabStop = false;
            this.imenikGroupBox.Text = "Imenik";
            // 
            // izbrisiOseboButton
            // 
            this.izbrisiOseboButton.Location = new System.Drawing.Point(366, 391);
            this.izbrisiOseboButton.Name = "izbrisiOseboButton";
            this.izbrisiOseboButton.Size = new System.Drawing.Size(154, 26);
            this.izbrisiOseboButton.TabIndex = 8;
            this.izbrisiOseboButton.Text = "Izbriši osebo";
            this.izbrisiOseboButton.UseVisualStyleBackColor = true;
            this.izbrisiOseboButton.Click += new System.EventHandler(this.izbrisiOseboButton_Click);
            // 
            // urdiOseboButton
            // 
            this.urdiOseboButton.Location = new System.Drawing.Point(185, 391);
            this.urdiOseboButton.Name = "urdiOseboButton";
            this.urdiOseboButton.Size = new System.Drawing.Size(154, 26);
            this.urdiOseboButton.TabIndex = 7;
            this.urdiOseboButton.Text = "Uredi osebo";
            this.urdiOseboButton.UseVisualStyleBackColor = true;
            this.urdiOseboButton.Click += new System.EventHandler(this.urdiOseboButton_Click);
            // 
            // dodajOseboButton
            // 
            this.dodajOseboButton.Location = new System.Drawing.Point(9, 391);
            this.dodajOseboButton.Name = "dodajOseboButton";
            this.dodajOseboButton.Size = new System.Drawing.Size(154, 26);
            this.dodajOseboButton.TabIndex = 6;
            this.dodajOseboButton.Text = "Dodaj osebo";
            this.dodajOseboButton.UseVisualStyleBackColor = true;
            this.dodajOseboButton.Click += new System.EventHandler(this.dodajOseboButton_Click);
            // 
            // imenikRichTextBox
            // 
            this.imenikRichTextBox.Location = new System.Drawing.Point(6, 21);
            this.imenikRichTextBox.Name = "imenikRichTextBox";
            this.imenikRichTextBox.Size = new System.Drawing.Size(783, 344);
            this.imenikRichTextBox.TabIndex = 1;
            this.imenikRichTextBox.Text = "";
            // 
            // imeSortButton
            // 
            this.imeSortButton.Location = new System.Drawing.Point(556, 371);
            this.imeSortButton.Name = "imeSortButton";
            this.imeSortButton.Size = new System.Drawing.Size(105, 26);
            this.imeSortButton.TabIndex = 9;
            this.imeSortButton.Text = "Po imenu";
            this.imeSortButton.UseVisualStyleBackColor = true;
            this.imeSortButton.Click += new System.EventHandler(this.imeSortButton_Click);
            // 
            // priimenkSortButton
            // 
            this.priimenkSortButton.Location = new System.Drawing.Point(667, 371);
            this.priimenkSortButton.Name = "priimenkSortButton";
            this.priimenkSortButton.Size = new System.Drawing.Size(105, 26);
            this.priimenkSortButton.TabIndex = 10;
            this.priimenkSortButton.Text = "Po priimku";
            this.priimenkSortButton.UseVisualStyleBackColor = true;
            this.priimenkSortButton.Click += new System.EventHandler(this.priimenkSortButton_Click);
            // 
            // ImenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 520);
            this.Controls.Add(this.novImenikTextBox);
            this.Controls.Add(this.imenikButton);
            this.Controls.Add(this.novImenikLabel);
            this.Controls.Add(this.izberiImenikLabel);
            this.Controls.Add(this.izberiImenikComboBox);
            this.Controls.Add(this.imenikGroupBox);
            this.Name = "ImenikForm";
            this.Text = "Imenik";
            this.Load += new System.EventHandler(this.ImenikForm_Load);
            this.imenikGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox novImenikTextBox;
        private System.Windows.Forms.Button imenikButton;
        private System.Windows.Forms.Label novImenikLabel;
        private System.Windows.Forms.Label izberiImenikLabel;
        private System.Windows.Forms.ComboBox izberiImenikComboBox;
        private System.Windows.Forms.GroupBox imenikGroupBox;
        private System.Windows.Forms.Button izbrisiOseboButton;
        private System.Windows.Forms.Button urdiOseboButton;
        private System.Windows.Forms.Button dodajOseboButton;
        private System.Windows.Forms.RichTextBox imenikRichTextBox;
        private System.Windows.Forms.Button priimenkSortButton;
        private System.Windows.Forms.Button imeSortButton;
    }
}

