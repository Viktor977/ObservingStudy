using System.Windows.Forms;

namespace ObservingStudy.Selectors {
    partial class FRadioSelector {
        /// <summary>
        ///Требуется переменная конструктора.
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
            this.panelSelection = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSelection);
            this.panelMain.Size = new System.Drawing.Size(251, 221);
            // 
            // panelSelection
            // 
            this.panelSelection.AutoScroll = true;
            this.panelSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelection.Location = new System.Drawing.Point(0, 0);
            this.panelSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(247, 217);
            this.panelSelection.TabIndex = 0;
            // 
            // FRadioSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FRadioSelector";
            this.Text = "FRadioSelector";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.StartPosition = FormStartPosition.Manual;

        }

        #endregion

        private System.Windows.Forms.Panel panelSelection;
    }
}
