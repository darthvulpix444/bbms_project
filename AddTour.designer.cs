﻿namespace BMSAdminPanel
{
    partial class AddTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTour));
            this.groupBoxTour = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.cmbboxBusID = new System.Windows.Forms.ComboBox();
            this.cmbboxFrom = new System.Windows.Forms.ComboBox();
            this.cmbboxTo = new System.Windows.Forms.ComboBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxTour.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTour
            // 
            this.groupBoxTour.Controls.Add(this.label4);
            this.groupBoxTour.Controls.Add(this.label3);
            this.groupBoxTour.Controls.Add(this.textBox2);
            this.groupBoxTour.Controls.Add(this.textBox1);
            this.groupBoxTour.Controls.Add(this.button2);
            this.groupBoxTour.Controls.Add(this.label5);
            this.groupBoxTour.Controls.Add(this.label2);
            this.groupBoxTour.Controls.Add(this.label1);
            this.groupBoxTour.Controls.Add(this.button1);
            this.groupBoxTour.Controls.Add(this.dtArrival);
            this.groupBoxTour.Controls.Add(this.dtDeparture);
            this.groupBoxTour.Controls.Add(this.cmbboxBusID);
            this.groupBoxTour.Controls.Add(this.cmbboxFrom);
            this.groupBoxTour.Controls.Add(this.cmbboxTo);
            this.groupBoxTour.Controls.Add(this.lblArrival);
            this.groupBoxTour.Controls.Add(this.lblDeparture);
            this.groupBoxTour.Location = new System.Drawing.Point(12, 80);
            this.groupBoxTour.Name = "groupBoxTour";
            this.groupBoxTour.Size = new System.Drawing.Size(760, 269);
            this.groupBoxTour.TabIndex = 1;
            this.groupBoxTour.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.Location = new System.Drawing.Point(549, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remove Tour";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(512, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bus ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "From:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(549, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Tour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtArrival
            // 
            this.dtArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtArrival.Location = new System.Drawing.Point(247, 230);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(276, 26);
            this.dtArrival.TabIndex = 15;
            // 
            // dtDeparture
            // 
            this.dtDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDeparture.Location = new System.Drawing.Point(247, 184);
            this.dtDeparture.Name = "dtDeparture";
            this.dtDeparture.Size = new System.Drawing.Size(276, 26);
            this.dtDeparture.TabIndex = 14;
            // 
            // cmbboxBusID
            // 
            this.cmbboxBusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxBusID.FormattingEnabled = true;
            this.cmbboxBusID.Location = new System.Drawing.Point(594, 37);
            this.cmbboxBusID.Name = "cmbboxBusID";
            this.cmbboxBusID.Size = new System.Drawing.Size(153, 28);
            this.cmbboxBusID.TabIndex = 13;
            // 
            // cmbboxFrom
            // 
            this.cmbboxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxFrom.FormattingEnabled = true;
            this.cmbboxFrom.Location = new System.Drawing.Point(89, 37);
            this.cmbboxFrom.Name = "cmbboxFrom";
            this.cmbboxFrom.Size = new System.Drawing.Size(153, 28);
            this.cmbboxFrom.TabIndex = 12;
            // 
            // cmbboxTo
            // 
            this.cmbboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbboxTo.FormattingEnabled = true;
            this.cmbboxTo.Location = new System.Drawing.Point(326, 37);
            this.cmbboxTo.Name = "cmbboxTo";
            this.cmbboxTo.Size = new System.Drawing.Size(153, 28);
            this.cmbboxTo.TabIndex = 10;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArrival.ForeColor = System.Drawing.Color.White;
            this.lblArrival.Location = new System.Drawing.Point(81, 230);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(157, 25);
            this.lblArrival.TabIndex = 5;
            this.lblArrival.Text = "Arrival and Date:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDeparture.ForeColor = System.Drawing.Color.White;
            this.lblDeparture.Location = new System.Drawing.Point(50, 184);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(193, 25);
            this.lblDeparture.TabIndex = 4;
            this.lblDeparture.Text = "Departure  and Date:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(96, 39);
            this.btnGoBack.TabIndex = 17;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox1.Location = new System.Drawing.Point(89, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 27);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox2.Location = new System.Drawing.Point(326, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 27);
            this.textBox2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Time";
            // 
            // AddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.groupBoxTour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "AddTour";
            this.Text = "Freedom Tourism";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form12_FormClosing);
            this.groupBoxTour.ResumeLayout(false);
            this.groupBoxTour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTour;
        private System.Windows.Forms.ComboBox cmbboxBusID;
        private System.Windows.Forms.ComboBox cmbboxFrom;
        private System.Windows.Forms.ComboBox cmbboxTo;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}