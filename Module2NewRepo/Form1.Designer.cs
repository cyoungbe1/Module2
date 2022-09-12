namespace Module2NewRepo
{
    partial class frmTown
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
            this.btnDeliverBaskets = new System.Windows.Forms.Button();
            this.btnHouse1 = new System.Windows.Forms.Button();
            this.btnHouse2 = new System.Windows.Forms.Button();
            this.btnHouse3 = new System.Windows.Forms.Button();
            this.btnHouse4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStack = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeliverBaskets
            // 
            this.btnDeliverBaskets.Location = new System.Drawing.Point(72, 59);
            this.btnDeliverBaskets.Name = "btnDeliverBaskets";
            this.btnDeliverBaskets.Size = new System.Drawing.Size(122, 23);
            this.btnDeliverBaskets.TabIndex = 0;
            this.btnDeliverBaskets.Text = "Deliver Baskets";
            this.btnDeliverBaskets.UseVisualStyleBackColor = true;
            // 
            // btnHouse1
            // 
            this.btnHouse1.Location = new System.Drawing.Point(60, 114);
            this.btnHouse1.Name = "btnHouse1";
            this.btnHouse1.Size = new System.Drawing.Size(122, 75);
            this.btnHouse1.TabIndex = 1;
            this.btnHouse1.Text = "House1";
            this.btnHouse1.UseVisualStyleBackColor = true;
            this.btnHouse1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHouse2
            // 
            this.btnHouse2.Location = new System.Drawing.Point(60, 195);
            this.btnHouse2.Name = "btnHouse2";
            this.btnHouse2.Size = new System.Drawing.Size(108, 77);
            this.btnHouse2.TabIndex = 2;
            this.btnHouse2.Text = "House2";
            this.btnHouse2.UseVisualStyleBackColor = true;
            // 
            // btnHouse3
            // 
            this.btnHouse3.Location = new System.Drawing.Point(205, 114);
            this.btnHouse3.Name = "btnHouse3";
            this.btnHouse3.Size = new System.Drawing.Size(108, 75);
            this.btnHouse3.TabIndex = 3;
            this.btnHouse3.Text = "House3";
            this.btnHouse3.UseVisualStyleBackColor = true;
            // 
            // btnHouse4
            // 
            this.btnHouse4.Location = new System.Drawing.Point(205, 195);
            this.btnHouse4.Name = "btnHouse4";
            this.btnHouse4.Size = new System.Drawing.Size(122, 77);
            this.btnHouse4.TabIndex = 4;
            this.btnHouse4.Text = "House4";
            this.btnHouse4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Queue List";
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(568, 133);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(55, 16);
            this.lblStack.TabIndex = 6;
            this.lblStack.Text = "lblStack";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(501, 133);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(61, 16);
            this.lblQueue.TabIndex = 7;
            this.lblQueue.Text = "lblQueue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stack List";
            // 
            // frmTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHouse4);
            this.Controls.Add(this.btnHouse3);
            this.Controls.Add(this.btnHouse2);
            this.Controls.Add(this.btnHouse1);
            this.Controls.Add(this.btnDeliverBaskets);
            this.Name = "frmTown";
            this.Text = "Town";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeliverBaskets;
        private System.Windows.Forms.Button btnHouse1;
        private System.Windows.Forms.Button btnHouse2;
        private System.Windows.Forms.Button btnHouse3;
        private System.Windows.Forms.Button btnHouse4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label4;
    }
}

