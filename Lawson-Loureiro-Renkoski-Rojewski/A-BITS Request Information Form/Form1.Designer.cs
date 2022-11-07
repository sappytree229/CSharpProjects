namespace A_BITS_Request_Information_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ABITSPhoto = new System.Windows.Forms.PictureBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SponsorBox = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ABITSPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameBox.Location = new System.Drawing.Point(247, 169);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(208, 31);
            this.FirstNameBox.TabIndex = 0;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(134, 171);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(103, 22);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ABITSPhoto
            // 
            this.ABITSPhoto.Image = global::A_BITS_Request_Information_Form.Properties.Resources.USB_Card_Front;
            this.ABITSPhoto.Location = new System.Drawing.Point(163, 4);
            this.ABITSPhoto.Name = "ABITSPhoto";
            this.ABITSPhoto.Size = new System.Drawing.Size(263, 143);
            this.ABITSPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ABITSPhoto.TabIndex = 2;
            this.ABITSPhoto.TabStop = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(130, 212);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 22);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LastNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LastNameBox
            // 
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameBox.Location = new System.Drawing.Point(247, 210);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(208, 31);
            this.LastNameBox.TabIndex = 3;
            this.LastNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(181, 253);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 22);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EmailLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.Location = new System.Drawing.Point(247, 251);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(208, 31);
            this.EmailBox.TabIndex = 5;
            // 
            // SponsorBox
            // 
            this.SponsorBox.AutoSize = true;
            this.SponsorBox.Location = new System.Drawing.Point(85, 301);
            this.SponsorBox.Name = "SponsorBox";
            this.SponsorBox.Size = new System.Drawing.Size(419, 26);
            this.SponsorBox.TabIndex = 7;
            this.SponsorBox.Text = "I am interested in sponsoring A-BITS events!";
            this.SponsorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SponsorBox.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(239, 344);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(110, 37);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 396);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SponsorBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.ABITSPhoto);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "A-BITS Information Request";
            ((System.ComponentModel.ISupportInitialize)(this.ABITSPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstNameBox;
        private Label FirstNameLabel;
        private PictureBox ABITSPhoto;
        private Label LastNameLabel;
        private TextBox LastNameBox;
        private Label EmailLabel;
        private TextBox EmailBox;
        private CheckBox SponsorBox;
        private Button SubmitButton;
    }
}