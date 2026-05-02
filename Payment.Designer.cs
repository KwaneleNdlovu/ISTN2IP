namespace Shoes
{
    partial class Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sneakerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_due_lbl = new System.Windows.Forms.Label();
            this.amountDueInput = new System.Windows.Forms.TextBox();
            this.change_lbl = new System.Windows.Forms.Label();
            this.receipt_btn = new System.Windows.Forms.Button();
            this.process_payment_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 77);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "URBAN FOOTWEAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sneakerName
            // 
            this.sneakerName.AutoSize = true;
            this.sneakerName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakerName.Location = new System.Drawing.Point(8, 122);
            this.sneakerName.Name = "sneakerName";
            this.sneakerName.Size = new System.Drawing.Size(108, 23);
            this.sneakerName.TabIndex = 4;
            this.sneakerName.Text = "Amount Due:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change:";
            // 
            // amount_due_lbl
            // 
            this.amount_due_lbl.AutoSize = true;
            this.amount_due_lbl.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_due_lbl.Location = new System.Drawing.Point(145, 122);
            this.amount_due_lbl.Name = "amount_due_lbl";
            this.amount_due_lbl.Size = new System.Drawing.Size(30, 23);
            this.amount_due_lbl.TabIndex = 7;
            this.amount_due_lbl.Text = "R0";
            // 
            // amountDueInput
            // 
            this.amountDueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueInput.Location = new System.Drawing.Point(149, 174);
            this.amountDueInput.Multiline = true;
            this.amountDueInput.Name = "amountDueInput";
            this.amountDueInput.Size = new System.Drawing.Size(138, 31);
            this.amountDueInput.TabIndex = 8;
            // 
            // change_lbl
            // 
            this.change_lbl.AutoSize = true;
            this.change_lbl.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_lbl.Location = new System.Drawing.Point(145, 234);
            this.change_lbl.Name = "change_lbl";
            this.change_lbl.Size = new System.Drawing.Size(30, 23);
            this.change_lbl.TabIndex = 9;
            this.change_lbl.Text = "R0";
            // 
            // receipt_btn
            // 
            this.receipt_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.receipt_btn.Enabled = false;
            this.receipt_btn.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_btn.Location = new System.Drawing.Point(149, 327);
            this.receipt_btn.Name = "receipt_btn";
            this.receipt_btn.Size = new System.Drawing.Size(130, 54);
            this.receipt_btn.TabIndex = 24;
            this.receipt_btn.Text = "PRINT RECEIPT";
            this.receipt_btn.UseVisualStyleBackColor = false;
            this.receipt_btn.Click += new System.EventHandler(this.receipt_btn_Click);
            // 
            // process_payment_btn
            // 
            this.process_payment_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.process_payment_btn.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_payment_btn.Location = new System.Drawing.Point(12, 327);
            this.process_payment_btn.Name = "process_payment_btn";
            this.process_payment_btn.Size = new System.Drawing.Size(130, 52);
            this.process_payment_btn.TabIndex = 25;
            this.process_payment_btn.Text = "PROCESS PAYMENT";
            this.process_payment_btn.UseVisualStyleBackColor = false;
            this.process_payment_btn.Click += new System.EventHandler(this.process_payment_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Red;
            this.back_btn.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(285, 329);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(130, 52);
            this.back_btn.TabIndex = 26;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 10);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(3, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 10);
            this.panel3.TabIndex = 28;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 397);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.process_payment_btn);
            this.Controls.Add(this.receipt_btn);
            this.Controls.Add(this.change_lbl);
            this.Controls.Add(this.amountDueInput);
            this.Controls.Add(this.amount_due_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sneakerName);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sneakerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amount_due_lbl;
        private System.Windows.Forms.TextBox amountDueInput;
        private System.Windows.Forms.Label change_lbl;
        private System.Windows.Forms.Button receipt_btn;
        private System.Windows.Forms.Button process_payment_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}