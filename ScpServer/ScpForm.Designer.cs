﻿namespace ScpServer
{
    partial class ScpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScpForm));
            this.lvDebug = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.btnPair = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHost = new System.Windows.Forms.Label();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.gpPads = new System.Windows.Forms.GroupBox();
            this.pad1_battery = new System.Windows.Forms.Panel();
            this.rbPad_4 = new System.Windows.Forms.RadioButton();
            this.rbPad_3 = new System.Windows.Forms.RadioButton();
            this.rbPad_2 = new System.Windows.Forms.RadioButton();
            this.rbPad_1 = new System.Windows.Forms.RadioButton();
            this.rootHub = new ScpControl.RootHub(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.gpPads.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDebug
            // 
            this.lvDebug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chData});
            this.lvDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDebug.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDebug.FullRowSelect = true;
            this.lvDebug.HideSelection = false;
            this.lvDebug.Location = new System.Drawing.Point(0, 0);
            this.lvDebug.Margin = new System.Windows.Forms.Padding(4);
            this.lvDebug.Name = "lvDebug";
            this.lvDebug.Size = new System.Drawing.Size(1025, 456);
            this.lvDebug.TabIndex = 0;
            this.lvDebug.UseCompatibleStateImageBehavior = false;
            this.lvDebug.View = System.Windows.Forms.View.Details;
            this.lvDebug.Enter += new System.EventHandler(this.lvDebug_Enter);
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 200;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 525;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnSend);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnBoth);
            this.pnlButton.Controls.Add(this.btnPair);
            this.pnlButton.Controls.Add(this.btnOff);
            this.pnlButton.Controls.Add(this.btnRight);
            this.pnlButton.Controls.Add(this.btnLeft);
            this.pnlButton.Controls.Add(this.btnStop);
            this.pnlButton.Controls.Add(this.btnStart);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 586);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1025, 43);
            this.pnlButton.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Brown;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(585, 7);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Reinstall";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnReinstall_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(693, 7);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnBoth
            // 
            this.btnBoth.Enabled = false;
            this.btnBoth.Location = new System.Drawing.Point(16, 7);
            this.btnBoth.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(100, 28);
            this.btnBoth.TabIndex = 3;
            this.btnBoth.Text = "Both";
            this.btnBoth.UseVisualStyleBackColor = true;
            this.btnBoth.Click += new System.EventHandler(this.btnMotor_Click);
            this.btnBoth.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnPair
            // 
            this.btnPair.Enabled = false;
            this.btnPair.Location = new System.Drawing.Point(448, 7);
            this.btnPair.Margin = new System.Windows.Forms.Padding(4);
            this.btnPair.Name = "btnPair";
            this.btnPair.Size = new System.Drawing.Size(100, 28);
            this.btnPair.TabIndex = 7;
            this.btnPair.Text = "Pair";
            this.btnPair.UseVisualStyleBackColor = true;
            this.btnPair.Click += new System.EventHandler(this.btnPair_Click);
            this.btnPair.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnOff
            // 
            this.btnOff.Enabled = false;
            this.btnOff.Location = new System.Drawing.Point(340, 7);
            this.btnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(100, 28);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnMotor_Click);
            this.btnOff.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(232, 7);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 28);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnMotor_Click);
            this.btnRight.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(124, 7);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 28);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnMotor_Click);
            this.btnLeft.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(909, 7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(801, 7);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.Enter += new System.EventHandler(this.Button_Enter);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHost.Location = new System.Drawing.Point(16, 11);
            this.lblHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(148, 17);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host Address :";
            // 
            // pnlDebug
            // 
            this.pnlDebug.Controls.Add(this.lvDebug);
            this.pnlDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDebug.Location = new System.Drawing.Point(0, 130);
            this.pnlDebug.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(1025, 456);
            this.pnlDebug.TabIndex = 11;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pnlStatus.Controls.Add(this.gpPads);
            this.pnlStatus.Controls.Add(this.lblHost);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1025, 130);
            this.pnlStatus.TabIndex = 9;
            // 
            // gpPads
            // 
            this.gpPads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpPads.Controls.Add(this.pad1_battery);
            this.gpPads.Controls.Add(this.rbPad_4);
            this.gpPads.Controls.Add(this.rbPad_3);
            this.gpPads.Controls.Add(this.rbPad_2);
            this.gpPads.Controls.Add(this.rbPad_1);
            this.gpPads.ForeColor = System.Drawing.SystemColors.Control;
            this.gpPads.Location = new System.Drawing.Point(400, -5);
            this.gpPads.Margin = new System.Windows.Forms.Padding(4);
            this.gpPads.Name = "gpPads";
            this.gpPads.Padding = new System.Windows.Forms.Padding(4);
            this.gpPads.Size = new System.Drawing.Size(620, 128);
            this.gpPads.TabIndex = 1;
            this.gpPads.TabStop = false;
            // 
            // pad1_battery
            // 
            this.pad1_battery.BackColor = System.Drawing.Color.Transparent;
            this.pad1_battery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pad1_battery.BackgroundImage")));
            this.pad1_battery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pad1_battery.Location = new System.Drawing.Point(551, 3);
            this.pad1_battery.Name = "pad1_battery";
            this.pad1_battery.Size = new System.Drawing.Size(68, 40);
            this.pad1_battery.TabIndex = 4;
            this.pad1_battery.Visible = false;
            // 
            // rbPad_4
            // 
            this.rbPad_4.AutoSize = true;
            this.rbPad_4.Enabled = false;
            this.rbPad_4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_4.Location = new System.Drawing.Point(8, 97);
            this.rbPad_4.Margin = new System.Windows.Forms.Padding(4);
            this.rbPad_4.Name = "rbPad_4";
            this.rbPad_4.Size = new System.Drawing.Size(229, 21);
            this.rbPad_4.TabIndex = 3;
            this.rbPad_4.TabStop = true;
            this.rbPad_4.Text = "Pad 4 : Disconnected";
            this.rbPad_4.UseVisualStyleBackColor = true;
            // 
            // rbPad_3
            // 
            this.rbPad_3.AutoSize = true;
            this.rbPad_3.Enabled = false;
            this.rbPad_3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_3.Location = new System.Drawing.Point(8, 69);
            this.rbPad_3.Margin = new System.Windows.Forms.Padding(4);
            this.rbPad_3.Name = "rbPad_3";
            this.rbPad_3.Size = new System.Drawing.Size(229, 21);
            this.rbPad_3.TabIndex = 2;
            this.rbPad_3.TabStop = true;
            this.rbPad_3.Text = "Pad 3 : Disconnected";
            this.rbPad_3.UseVisualStyleBackColor = true;
            // 
            // rbPad_2
            // 
            this.rbPad_2.AutoSize = true;
            this.rbPad_2.Enabled = false;
            this.rbPad_2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_2.Location = new System.Drawing.Point(8, 41);
            this.rbPad_2.Margin = new System.Windows.Forms.Padding(4);
            this.rbPad_2.Name = "rbPad_2";
            this.rbPad_2.Size = new System.Drawing.Size(229, 21);
            this.rbPad_2.TabIndex = 1;
            this.rbPad_2.TabStop = true;
            this.rbPad_2.Text = "Pad 2 : Disconnected";
            this.rbPad_2.UseVisualStyleBackColor = true;
            // 
            // rbPad_1
            // 
            this.rbPad_1.AutoSize = true;
            this.rbPad_1.Enabled = false;
            this.rbPad_1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPad_1.ForeColor = System.Drawing.SystemColors.Control;
            this.rbPad_1.Location = new System.Drawing.Point(8, 12);
            this.rbPad_1.Margin = new System.Windows.Forms.Padding(4);
            this.rbPad_1.Name = "rbPad_1";
            this.rbPad_1.Size = new System.Drawing.Size(229, 21);
            this.rbPad_1.TabIndex = 0;
            this.rbPad_1.TabStop = true;
            this.rbPad_1.Text = "Pad 1 : Disconnected";
            this.rbPad_1.UseVisualStyleBackColor = true;
            // 
            // rootHub
            // 
            this.rootHub.Debug += new System.EventHandler<ScpControl.DebugEventArgs>(this.On_Debug);
            // 
            // ScpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 629);
            this.Controls.Add(this.pnlDebug);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlStatus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1041, 666);
            this.Name = "ScpForm";
            this.Text = "SCP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Close);
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlDebug.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.gpPads.ResumeLayout(false);
            this.gpPads.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDebug;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Button btnPair;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.GroupBox gpPads;
        private System.Windows.Forms.RadioButton rbPad_4;
        private System.Windows.Forms.RadioButton rbPad_3;
        private System.Windows.Forms.RadioButton rbPad_2;
        private System.Windows.Forms.RadioButton rbPad_1;
        private System.Windows.Forms.Button btnClear;
        private ScpControl.RootHub rootHub;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pad1_battery;
    }
}

