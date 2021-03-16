namespace ObservingStudy {
    partial class FManager {
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
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(16, 137);
            this.buttonSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(88, 21);
            this.buttonSelection.TabIndex = 1;
            this.buttonSelection.Text = "Вибір";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(16, 85);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 21);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "Перегляд";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonEditing
            // 
            this.buttonEditing.Location = new System.Drawing.Point(16, 111);
            this.buttonEditing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(88, 21);
            this.buttonEditing.TabIndex = 1;
            this.buttonEditing.Text = "Редагування";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLog.Location = new System.Drawing.Point(16, 187);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(88, 23);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Журнал";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 14);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(91, 58);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "labelHeader";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 226);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonEditing);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(136, 10000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 265);
            this.Name = "FManager";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FManaging_FormClosed);
            this.Resize += new System.EventHandler(this.FManaging_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonEditing;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelHeader;
    }
}