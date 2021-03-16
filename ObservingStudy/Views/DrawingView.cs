using ObservingStudy.Interfaces;
using ObservingStudy.Models;
using System.Drawing;
using System.Windows.Forms;

namespace ObservingStudy.Views {
    public class DrawingView : Form, IView {

        private InfoList infoList;

        public DrawingView(InfoList infoList) {
            //
            this.infoList = infoList;
            InitializeComponent();
            this.Paint += DrawingView_Paint;

        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // DrawingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Name = "DrawingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дані";
            this.ResumeLayout(false);

        }

        private void DrawingView_Paint(object sender, PaintEventArgs e) {
            e.Graphics.Clear(Color.FromArgb(unchecked((int)0xFFF0F3FF)));

            Graphics g = e.Graphics;
            Font headerFont = new Font("Courfier New", 12, FontStyle.Bold);
            Brush headerBrush = new SolidBrush(Color.FromArgb(unchecked((int)0xFF0030A0)));
            e.Graphics.DrawString(infoList.Header, headerFont, headerBrush, 30, 20);

            Font textFont = new Font("Courfier New", 10, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.FromArgb(unchecked((int)0xFF002070)));
            for(int i = 0; i < infoList.List.Count; i++) {
                e.Graphics.DrawString(infoList.List[i], textFont, textBrush, 40, 50 + i * 20);
            }
        }

        public void UpdateInfo() {
            this.Invalidate();
        }
    }
}
