﻿namespace Mt5trade
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewQuotes = new System.Windows.Forms.ListView();
            this.colSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAsk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btbBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxOrderSymbol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericOrderVolume = new System.Windows.Forms.NumericUpDown();
            this.listBoxEventLog = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.textBoxSellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxFollowPrice = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrderVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.textBoxServerName);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(41, 71);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(70, 19);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(156, 20);
            this.textBoxServerName.TabIndex = 0;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(70, 45);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(156, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "8228";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(122, 71);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewQuotes);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 300);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connected Quotes:";
            // 
            // listViewQuotes
            // 
            this.listViewQuotes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSymbol,
            this.colBid,
            this.colAsk,
            this.colFeedCount});
            this.listViewQuotes.FullRowSelect = true;
            this.listViewQuotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewQuotes.Location = new System.Drawing.Point(6, 19);
            this.listViewQuotes.Name = "listViewQuotes";
            this.listViewQuotes.Size = new System.Drawing.Size(275, 275);
            this.listViewQuotes.TabIndex = 15;
            this.listViewQuotes.UseCompatibleStateImageBehavior = false;
            this.listViewQuotes.View = System.Windows.Forms.View.Details;
            this.listViewQuotes.SelectedIndexChanged += new System.EventHandler(this.listViewQuotes_SelectedIndexChanged);
            // 
            // colSymbol
            // 
            this.colSymbol.Text = "Symbol";
            // 
            // colBid
            // 
            this.colBid.Text = "Bid";
            // 
            // colAsk
            // 
            this.colAsk.Text = "Ask";
            // 
            // colFeedCount
            // 
            this.colFeedCount.Text = "Feeds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Order Volume:";
            // 
            // btbBuy
            // 
            this.btbBuy.Location = new System.Drawing.Point(8, 267);
            this.btbBuy.Name = "btbBuy";
            this.btbBuy.Size = new System.Drawing.Size(116, 32);
            this.btbBuy.TabIndex = 19;
            this.btbBuy.Text = "Buy";
            this.btbBuy.UseVisualStyleBackColor = true;
            this.btbBuy.Click += new System.EventHandler(this.btbBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(130, 267);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(116, 32);
            this.btnSell.TabIndex = 20;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusConnection
            // 
            this.toolStripStatusConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusConnection.Name = "toolStripStatusConnection";
            this.toolStripStatusConnection.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusConnection.Text = "Disconnected";
            // 
            // textBoxOrderSymbol
            // 
            this.textBoxOrderSymbol.Location = new System.Drawing.Point(91, 130);
            this.textBoxOrderSymbol.Name = "textBoxOrderSymbol";
            this.textBoxOrderSymbol.Size = new System.Drawing.Size(149, 20);
            this.textBoxOrderSymbol.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Order Symbol:";
            // 
            // numericOrderVolume
            // 
            this.numericOrderVolume.DecimalPlaces = 1;
            this.numericOrderVolume.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericOrderVolume.Location = new System.Drawing.Point(92, 156);
            this.numericOrderVolume.Name = "numericOrderVolume";
            this.numericOrderVolume.Size = new System.Drawing.Size(146, 20);
            this.numericOrderVolume.TabIndex = 22;
            this.numericOrderVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // listBoxEventLog
            // 
            this.listBoxEventLog.FormattingEnabled = true;
            this.listBoxEventLog.Location = new System.Drawing.Point(12, 318);
            this.listBoxEventLog.Name = "listBoxEventLog";
            this.listBoxEventLog.Size = new System.Drawing.Size(531, 82);
            this.listBoxEventLog.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Order Buy Price:";
            // 
            // textBoxBuyPrice
            // 
            this.textBoxBuyPrice.Location = new System.Drawing.Point(12, 241);
            this.textBoxBuyPrice.Name = "textBoxBuyPrice";
            this.textBoxBuyPrice.Size = new System.Drawing.Size(113, 20);
            this.textBoxBuyPrice.TabIndex = 27;
            // 
            // textBoxSellPrice
            // 
            this.textBoxSellPrice.Location = new System.Drawing.Point(130, 241);
            this.textBoxSellPrice.Name = "textBoxSellPrice";
            this.textBoxSellPrice.Size = new System.Drawing.Size(113, 20);
            this.textBoxSellPrice.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Order Sell Price:";
            // 
            // checkBoxFollowPrice
            // 
            this.checkBoxFollowPrice.AutoSize = true;
            this.checkBoxFollowPrice.Checked = true;
            this.checkBoxFollowPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFollowPrice.Location = new System.Drawing.Point(16, 194);
            this.checkBoxFollowPrice.Name = "checkBoxFollowPrice";
            this.checkBoxFollowPrice.Size = new System.Drawing.Size(100, 17);
            this.checkBoxFollowPrice.TabIndex = 30;
            this.checkBoxFollowPrice.Text = "Follow the price";
            this.checkBoxFollowPrice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 425);
            this.Controls.Add(this.checkBoxFollowPrice);
            this.Controls.Add(this.textBoxSellPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuyPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEventLog);
            this.Controls.Add(this.textBoxOrderSymbol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericOrderVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btbBuy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrderVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewQuotes;
        private System.Windows.Forms.ColumnHeader colSymbol;
        private System.Windows.Forms.ColumnHeader colBid;
        private System.Windows.Forms.ColumnHeader colAsk;
        private System.Windows.Forms.ColumnHeader colFeedCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btbBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnection;
        private System.Windows.Forms.TextBox textBoxOrderSymbol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericOrderVolume;
        private System.Windows.Forms.ListBox listBoxEventLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuyPrice;
        private System.Windows.Forms.TextBox textBoxSellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxFollowPrice;
    }
}
