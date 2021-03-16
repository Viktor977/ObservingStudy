namespace ObservingStudy.Editors {
    partial class FEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.labelNew = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(15, 16);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(38, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Дані";
            // 
            // listBoxData
            // 
            this.listBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(16, 36);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(247, 148);
            this.listBoxData.TabIndex = 1;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // labelNew
            // 
            this.labelNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNew.AutoSize = true;
            this.labelNew.Location = new System.Drawing.Point(16, 209);
            this.labelNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(109, 17);
            this.labelNew.TabIndex = 0;
            this.labelNew.Text = "Новий елемент";
            // 
            // textBoxData
            // 
            this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData.Location = new System.Drawing.Point(16, 236);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(246, 22);
            this.textBoxData.TabIndex = 2;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxNew_TextChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(280, 35);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(85, 28);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(280, 230);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 279);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 317);
            this.Name = "FEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редагування даних";
            this.Load += new System.EventHandler(this.FDataEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
    }
}