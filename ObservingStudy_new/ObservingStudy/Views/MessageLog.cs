using ObservingStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObservingStudy.Views {
    public class MessageLog : Form, IMessageLog {
        RichTextBox richTextBox;

        public MessageLog() {
            InitializeComponent();
        }

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
            this.ClientSize = new System.Drawing.Size(1000, 253);
            this.Controls.Add(this.richTextBox);
            this.Name = "TextView";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дані";
            this.ResumeLayout(false);

        }

        //public void UpdateInfo() {
        //    richTextBox.Clear();
        //    richTextBox.SelectionFont = new Font("Times New Roman", 14F, FontStyle.Bold);
        //    richTextBox.AppendText($"\n{"",4}{infoList.Header}\n");
        //    richTextBox.SelectionFont = new Font("Times New Roman", 12F, FontStyle.Regular);
        //    richTextBox.SelectionColor = Color.Navy;
        //    foreach (var s in infoList.List) {
        //        richTextBox.AppendText($"\n\t{s}");
        //    }
        //}

        protected override void Dispose(bool disposing) {
            richTextBox.Dispose();
            base.Dispose(disposing);
        }

        public void Debug(string message) {
            richTextBox.SelectionColor = Color.Purple;
            AddMessage(message);
        }

        public void Info(string message) {
            richTextBox.SelectionColor = Color.Black;
            AddMessage(message);
        }

        private void AddMessage(string message) {
            richTextBox.AppendText(
                $"{DateTime.Now.ToString("yy.MM.ss HH:mm:ss.ff")} - {message}");
        }
    }
}
