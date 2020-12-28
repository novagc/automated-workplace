namespace AW.GUI
{
    partial class UpdateWorkerInfoForm
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
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MidNameTextBox = new System.Windows.Forms.TextBox();
            this.NewPassowrdTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordAgainTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MidNameLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordAgainLabel = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(189, 13);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(426, 27);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(189, 48);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(426, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // MidNameTextBox
            // 
            this.MidNameTextBox.Location = new System.Drawing.Point(189, 83);
            this.MidNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MidNameTextBox.Name = "MidNameTextBox";
            this.MidNameTextBox.Size = new System.Drawing.Size(426, 27);
            this.MidNameTextBox.TabIndex = 2;
            // 
            // NewPassowrdTextBox
            // 
            this.NewPassowrdTextBox.Location = new System.Drawing.Point(189, 118);
            this.NewPassowrdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPassowrdTextBox.Name = "NewPassowrdTextBox";
            this.NewPassowrdTextBox.PasswordChar = '*';
            this.NewPassowrdTextBox.Size = new System.Drawing.Size(426, 27);
            this.NewPassowrdTextBox.TabIndex = 3;
            // 
            // NewPasswordAgainTextBox
            // 
            this.NewPasswordAgainTextBox.Location = new System.Drawing.Point(189, 153);
            this.NewPasswordAgainTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPasswordAgainTextBox.Name = "NewPasswordAgainTextBox";
            this.NewPasswordAgainTextBox.PasswordChar = '*';
            this.NewPasswordAgainTextBox.Size = new System.Drawing.Size(426, 27);
            this.NewPasswordAgainTextBox.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 15);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(73, 20);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 20);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            // 
            // MidNameLabel
            // 
            this.MidNameLabel.AutoSize = true;
            this.MidNameLabel.Location = new System.Drawing.Point(12, 86);
            this.MidNameLabel.Name = "MidNameLabel";
            this.MidNameLabel.Size = new System.Drawing.Size(72, 20);
            this.MidNameLabel.TabIndex = 8;
            this.MidNameLabel.Text = "Отчество";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(12, 121);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(112, 20);
            this.NewPasswordLabel.TabIndex = 9;
            this.NewPasswordLabel.Text = "Новый пароль";
            // 
            // NewPasswordAgainLabel
            // 
            this.NewPasswordAgainLabel.AutoSize = true;
            this.NewPasswordAgainLabel.Location = new System.Drawing.Point(12, 156);
            this.NewPasswordAgainLabel.Name = "NewPasswordAgainLabel";
            this.NewPasswordAgainLabel.Size = new System.Drawing.Size(139, 20);
            this.NewPasswordAgainLabel.TabIndex = 10;
            this.NewPasswordAgainLabel.Text = "Повторите пароль";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(12, 206);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(193, 52);
            this.ButtonSubmit.TabIndex = 11;
            this.ButtonSubmit.Text = "Сохранить";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(422, 206);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(193, 52);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // UpdateWorkerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 269);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.NewPasswordAgainLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.MidNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NewPasswordAgainTextBox);
            this.Controls.Add(this.NewPassowrdTextBox);
            this.Controls.Add(this.MidNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateWorkerInfoForm";
            this.Text = "UpdateWorkerInfoForm";
            this.VisibleChanged += new System.EventHandler(this.UpdateWorkerInfoForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MidNameTextBox;
        private System.Windows.Forms.TextBox NewPassowrdTextBox;
        private System.Windows.Forms.TextBox NewPasswordAgainTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MidNameLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label NewPasswordAgainLabel;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button ButtonCancel;
    }
}