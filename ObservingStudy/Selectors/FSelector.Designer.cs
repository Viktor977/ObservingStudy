namespace ObservingStudy.Selectors {
    partial class FSelector {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonEfiting = new System.Windows.Forms.Button();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(382, 37);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(15, 11);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(38, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Дані";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonEfiting);
            this.panelButtons.Controls.Add(this.buttonEditing);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(241, 37);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(141, 221);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonEfiting
            // 
            this.buttonEfiting.Location = new System.Drawing.Point(17, 17);
            this.buttonEfiting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEfiting.Name = "buttonEfiting";
            this.buttonEfiting.Size = new System.Drawing.Size(105, 26);
            this.buttonEfiting.TabIndex = 0;
            this.buttonEfiting.Text = "Редагування";
            this.buttonEfiting.UseVisualStyleBackColor = true;
            this.buttonEfiting.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // buttonEditing
            // 
            this.buttonEditing.Location = new System.Drawing.Point(17, 17);
            this.buttonEditing.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(105, 26);
            this.buttonEditing.TabIndex = 0;
            this.buttonEditing.Text = "Редагування";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 37);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(241, 221);
            this.panelMain.TabIndex = 0;
            // 
            // FSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 258);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FSelector";
            this.Text = "Вибір елемента списку";
            this.Load += new System.EventHandler(this.FSelector_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelButtons;
        protected System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonEditing;
        private System.Windows.Forms.Button buttonEfiting;
    }
}

