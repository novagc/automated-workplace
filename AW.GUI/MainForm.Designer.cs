﻿
namespace AW.GUI
{
    partial class MainForm
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
            this.orderList = new System.Windows.Forms.ListBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.workerLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.setStatusInWorkButton = new System.Windows.Forms.Button();
            this.setStatusFinishedButton = new System.Windows.Forms.Button();
            this.setStatusArchivedButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.UpdateWorkerInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 15;
            this.orderList.Location = new System.Drawing.Point(10, 9);
            this.orderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(255, 334);
            this.orderList.TabIndex = 0;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(10, 351);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(255, 38);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Добавить новый заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(270, 86);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(746, 252);
            this.descriptionBox.TabIndex = 2;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(362, 341);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(217, 23);
            this.priceBox.TabIndex = 3;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(270, 34);
            this.titleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(746, 23);
            this.titleBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(611, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(78, 21);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Название";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(270, 338);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(47, 21);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Цена";
            // 
            // workerComboBox
            // 
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(362, 392);
            this.workerComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(217, 23);
            this.workerComboBox.TabIndex = 7;
            this.workerComboBox.SelectedIndexChanged += new System.EventHandler(this.workerComboBox_SelectedIndexChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(607, 63);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(81, 21);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Описание";
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workerLabel.Location = new System.Drawing.Point(270, 388);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(78, 21);
            this.workerLabel.TabIndex = 9;
            this.workerLabel.Text = "Работник";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(270, 363);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 21);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Статус";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(362, 366);
            this.statusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(217, 23);
            this.statusBox.TabIndex = 11;
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(584, 341);
            this.saveOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(82, 73);
            this.saveOrderButton.TabIndex = 12;
            this.saveOrderButton.Text = "Сохранить";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // setStatusInWorkButton
            // 
            this.setStatusInWorkButton.Location = new System.Drawing.Point(671, 341);
            this.setStatusInWorkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setStatusInWorkButton.Name = "setStatusInWorkButton";
            this.setStatusInWorkButton.Size = new System.Drawing.Size(82, 73);
            this.setStatusInWorkButton.TabIndex = 13;
            this.setStatusInWorkButton.Text = "В работу";
            this.setStatusInWorkButton.UseVisualStyleBackColor = true;
            this.setStatusInWorkButton.Click += new System.EventHandler(this.setStatusInWorkButton_Click);
            // 
            // setStatusFinishedButton
            // 
            this.setStatusFinishedButton.Location = new System.Drawing.Point(759, 341);
            this.setStatusFinishedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setStatusFinishedButton.Name = "setStatusFinishedButton";
            this.setStatusFinishedButton.Size = new System.Drawing.Size(82, 73);
            this.setStatusFinishedButton.TabIndex = 14;
            this.setStatusFinishedButton.Text = "Завершить";
            this.setStatusFinishedButton.UseVisualStyleBackColor = true;
            this.setStatusFinishedButton.Click += new System.EventHandler(this.setStatusFinishedButton_Click);
            // 
            // setStatusArchivedButton
            // 
            this.setStatusArchivedButton.Location = new System.Drawing.Point(846, 341);
            this.setStatusArchivedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setStatusArchivedButton.Name = "setStatusArchivedButton";
            this.setStatusArchivedButton.Size = new System.Drawing.Size(82, 73);
            this.setStatusArchivedButton.TabIndex = 15;
            this.setStatusArchivedButton.Text = "В архив";
            this.setStatusArchivedButton.UseVisualStyleBackColor = true;
            this.setStatusArchivedButton.Click += new System.EventHandler(this.setStatusArchivedButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(934, 341);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 73);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateWorkerInfoButton
            // 
            this.UpdateWorkerInfoButton.Location = new System.Drawing.Point(10, 391);
            this.UpdateWorkerInfoButton.Name = "UpdateWorkerInfoButton";
            this.UpdateWorkerInfoButton.Size = new System.Drawing.Size(255, 23);
            this.UpdateWorkerInfoButton.TabIndex = 17;
            this.UpdateWorkerInfoButton.Text = "Параметры сотрудника";
            this.UpdateWorkerInfoButton.UseVisualStyleBackColor = true;
            this.UpdateWorkerInfoButton.Click += new System.EventHandler(this.UpdateWorkerInfoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 423);
            this.Controls.Add(this.UpdateWorkerInfoButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setStatusArchivedButton);
            this.Controls.Add(this.setStatusFinishedButton);
            this.Controls.Add(this.setStatusInWorkButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button setStatusInWorkButton;
        private System.Windows.Forms.Button setStatusFinishedButton;
        private System.Windows.Forms.Button setStatusArchivedButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button UpdateWorkerInfoButton;
    }
}