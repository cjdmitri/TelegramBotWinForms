
namespace TelegramBotWinForms
{
    partial class Frm_General
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_BotName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_ApiKey = new System.Windows.Forms.TextBox();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_MessageList = new System.Windows.Forms.DataGridView();
            this.TextMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MessageList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_BotName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "Бот:";
            // 
            // lbl_BotName
            // 
            this.lbl_BotName.Name = "lbl_BotName";
            this.lbl_BotName.Size = new System.Drawing.Size(42, 17);
            this.lbl_BotName.Text = "no bot";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_SaveSettings);
            this.tabPage2.Controls.Add(this.tb_ApiKey);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_ApiKey
            // 
            this.tb_ApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ApiKey.Location = new System.Drawing.Point(8, 43);
            this.tb_ApiKey.Name = "tb_ApiKey";
            this.tb_ApiKey.Size = new System.Drawing.Size(876, 23);
            this.tb_ApiKey.TabIndex = 0;
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveSettings.Location = new System.Drawing.Point(890, 43);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(75, 24);
            this.btn_SaveSettings.TabIndex = 1;
            this.btn_SaveSettings.Text = "Сохранить";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telegram Bot API Key:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_MessageList);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сообщения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_MessageList
            // 
            this.dataGridView_MessageList.AllowUserToAddRows = false;
            this.dataGridView_MessageList.AllowUserToDeleteRows = false;
            this.dataGridView_MessageList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_MessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MessageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.TypeMsg,
            this.ChatId,
            this.FirstName,
            this.LastName,
            this.Username,
            this.TextMessage});
            this.dataGridView_MessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MessageList.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_MessageList.Name = "dataGridView_MessageList";
            this.dataGridView_MessageList.RowTemplate.Height = 25;
            this.dataGridView_MessageList.Size = new System.Drawing.Size(1012, 382);
            this.dataGridView_MessageList.TabIndex = 0;
            this.dataGridView_MessageList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TextMessage
            // 
            this.TextMessage.HeaderText = "Text";
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Width = 300;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // ChatId
            // 
            this.ChatId.HeaderText = "Chat.Id";
            this.ChatId.Name = "ChatId";
            // 
            // TypeMsg
            // 
            this.TypeMsg.HeaderText = "Type";
            this.TypeMsg.Name = "TypeMsg";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(78, 32);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // Frm_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_General_FormClosing);
            this.Load += new System.EventHandler(this.Frm_General_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MessageList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_BotName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.TextBox tb_ApiKey;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_MessageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextMessage;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

