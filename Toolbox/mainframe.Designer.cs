namespace Toolbox
{
    partial class Mainframe
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2Panel Panel_Top;
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Button_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Button_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            Button_Scanner_IP = new Guna.UI2.WinForms.Guna2Button();
            Panel_Top = new Guna.UI2.WinForms.Guna2Panel();
            Panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Top
            // 
            Panel_Top.BackColor = Color.FromArgb(26, 26, 26);
            Panel_Top.Controls.Add(guna2HtmlLabel1);
            Panel_Top.Controls.Add(Button_Minimize);
            Panel_Top.Controls.Add(Button_Close);
            Panel_Top.CustomizableEdges = customizableEdges5;
            Panel_Top.Location = new Point(3, 3);
            Panel_Top.Name = "Panel_Top";
            Panel_Top.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Panel_Top.Size = new Size(1146, 45);
            Panel_Top.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.Control;
            guna2HtmlLabel1.Location = new Point(515, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 34);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Toolbox";
            // 
            // Button_Minimize
            // 
            Button_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Button_Minimize.CustomizableEdges = customizableEdges1;
            Button_Minimize.FillColor = Color.FromArgb(255, 193, 7);
            Button_Minimize.IconColor = Color.White;
            Button_Minimize.Location = new Point(1047, 9);
            Button_Minimize.Name = "Button_Minimize";
            Button_Minimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Minimize.Size = new Size(45, 29);
            Button_Minimize.TabIndex = 2;
            Button_Minimize.Click += Button_Minimize_Click;
            // 
            // Button_Close
            // 
            Button_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Close.CustomizableEdges = customizableEdges3;
            Button_Close.FillColor = Color.FromArgb(255, 193, 7);
            Button_Close.IconColor = Color.White;
            Button_Close.Location = new Point(1098, 9);
            Button_Close.Name = "Button_Close";
            Button_Close.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_Close.Size = new Size(45, 29);
            Button_Close.TabIndex = 0;
            Button_Close.Click += Button_Close_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = Panel_Top;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            guna2HtmlToolTip1.Draw += guna2HtmlToolTip1_Draw;
            // 
            // Button_Scanner_IP
            // 
            Button_Scanner_IP.CustomizableEdges = customizableEdges7;
            Button_Scanner_IP.DisabledState.BorderColor = Color.DarkGray;
            Button_Scanner_IP.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Scanner_IP.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Scanner_IP.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Scanner_IP.Font = new Font("Segoe UI", 9F);
            Button_Scanner_IP.ForeColor = Color.White;
            Button_Scanner_IP.Location = new Point(938, 130);
            Button_Scanner_IP.Name = "Button_Scanner_IP";
            Button_Scanner_IP.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Button_Scanner_IP.Size = new Size(180, 45);
            Button_Scanner_IP.TabIndex = 4;
            Button_Scanner_IP.Text = "guna2Button1";
            Button_Scanner_IP.Click += Button_Scanner_IP_Click;
            // 
            // Mainframe
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1149, 592);
            ControlBox = false;
            Controls.Add(Button_Scanner_IP);
            Controls.Add(Panel_Top);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mainframe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainframe";
            Panel_Top.ResumeLayout(false);
            Panel_Top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Close;
        private Guna.UI2.WinForms.Guna2ControlBox Button_Minimize;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Button_Scanner_IP;
    }
}
