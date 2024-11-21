namespace LB1
{
    partial class MainForm
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
            panelTop = new Panel();
            labelUsers = new Label();
            panel2 = new Panel();
            labelInfoAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(684, 70);
            panelTop.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(664, 50);
            labelUsers.TabIndex = 0;
            labelUsers.Text = "Список пользователей";
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInfoAboutUsers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(684, 491);
            panel2.TabIndex = 1;
            // 
            // labelInfoAboutUsers
            // 
            labelInfoAboutUsers.Dock = DockStyle.Fill;
            labelInfoAboutUsers.Location = new Point(10, 10);
            labelInfoAboutUsers.Name = "labelInfoAboutUsers";
            labelInfoAboutUsers.Size = new Size(664, 471);
            labelInfoAboutUsers.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 561);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Name = "MainForm";
            Text = "Пользователи";
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Label labelUsers;
        private Label labelInfoAboutUsers;
    }
}
