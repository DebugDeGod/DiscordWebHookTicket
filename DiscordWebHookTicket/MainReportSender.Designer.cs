namespace DiscordWebHookTicket
{
    partial class MainReportSender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReportSender));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.TextReport = new System.Windows.Forms.TextBox();
            this.ReportType = new System.Windows.Forms.ComboBox();
            this.ReportMessageText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.ButtonSendTicket = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Report:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(58, 8);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(243, 20);
            this.TextName.TabIndex = 4;
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(58, 34);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(243, 20);
            this.TextEmail.TabIndex = 5;
            // 
            // TextReport
            // 
            this.TextReport.Location = new System.Drawing.Point(58, 60);
            this.TextReport.Name = "TextReport";
            this.TextReport.Size = new System.Drawing.Size(243, 20);
            this.TextReport.TabIndex = 6;
            // 
            // ReportType
            // 
            this.ReportType.AutoCompleteCustomSource.AddRange(new string[] {
            "VAC",
            "HWID",
            "IP BAN"});
            this.ReportType.FormattingEnabled = true;
            this.ReportType.Items.AddRange(new object[] {
            "HWIDBan",
            "ProdBan",
            "VACBan",
            "AccountBan"});
            this.ReportType.Location = new System.Drawing.Point(57, 86);
            this.ReportType.Name = "ReportType";
            this.ReportType.Size = new System.Drawing.Size(244, 21);
            this.ReportType.TabIndex = 7;
            // 
            // ReportMessageText
            // 
            // 
            // 
            // 
            this.ReportMessageText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.ReportMessageText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReportMessageText.Location = new System.Drawing.Point(58, 113);
            this.ReportMessageText.Name = "ReportMessageText";
            this.ReportMessageText.Rtf = resources.GetString("ReportMessageText.Rtf");
            this.ReportMessageText.Size = new System.Drawing.Size(244, 249);
            this.ReportMessageText.TabIndex = 8;
            this.ReportMessageText.Text = "Type Your Report Here";
            // 
            // ButtonSendTicket
            // 
            this.ButtonSendTicket.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSendTicket.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSendTicket.Location = new System.Drawing.Point(32, 372);
            this.ButtonSendTicket.Margin = new System.Windows.Forms.Padding(9);
            this.ButtonSendTicket.Name = "ButtonSendTicket";
            this.ButtonSendTicket.Padding = new System.Windows.Forms.Padding(9);
            this.ButtonSendTicket.Size = new System.Drawing.Size(243, 23);
            this.ButtonSendTicket.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSendTicket.Symbol = "58707";
            this.ButtonSendTicket.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSendTicket.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonSendTicket.SymbolSize = 13F;
            this.ButtonSendTicket.TabIndex = 9;
            this.ButtonSendTicket.Text = " Send Ticket";
            this.ButtonSendTicket.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainReportSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BottomLeftCornerSize = 0;
            this.BottomRightCornerSize = 0;
            this.ClientSize = new System.Drawing.Size(307, 402);
            this.Controls.Add(this.ButtonSendTicket);
            this.Controls.Add(this.ReportMessageText);
            this.Controls.Add(this.ReportType);
            this.Controls.Add(this.TextReport);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainReportSender";
            this.Text = "Discord | Ticket Tool | By IDA Pro | V2";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.TextBox TextReport;
        private System.Windows.Forms.ComboBox ReportType;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx ReportMessageText;
        private DevComponents.DotNetBar.ButtonX ButtonSendTicket;
        private System.Windows.Forms.Timer timer1;
    }
}

