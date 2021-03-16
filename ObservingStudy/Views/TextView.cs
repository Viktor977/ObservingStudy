using ObservingStudy.Interfaces;
using ObservingStudy.Models;
using System.Drawing;
using System.Windows.Forms;

namespace ObservingStudy.Views {
    public class TextView : Form, IView {

        private InfoList infoList;

        public TextView(InfoList infoList) {
            //
            this.infoList = infoList;
            InitializeComponent();

            UpdateInfo();
        }

        RichTextBox richTextBox;

        private void InitializeComponent() {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(4, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(374, 245);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.richTextBox);
            this.Name = "TextView";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дані";
            this.ResumeLayout(false);

        }

        public void UpdateInfo() {
            richTextBox.Clear();
            richTextBox.SelectionFont = new Font("Times New Roman", 14F, FontStyle.Bold);
            richTextBox.SelectionColor = Color.Purple;
            richTextBox.AppendText($"\n{"",4}{infoList.Header}\n");
            richTextBox.SelectionFont = new Font("Times New Roman", 12F, FontStyle.Regular);
            richTextBox.SelectionColor = Color.Navy;
            foreach (var s in infoList.List) {
                richTextBox.AppendText($"\n\t{s}");
            }
        }

        protected override void Dispose(bool disposing) {
            richTextBox.Dispose();
            base.Dispose(disposing);
        }

    }
}
