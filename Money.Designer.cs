namespace Vending_Machine
{
    partial class Money
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
            this.moneyInserted = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.two_pounds = new System.Windows.Forms.Button();
            this.one_pound = new System.Windows.Forms.Button();
            this.fifty_p = new System.Windows.Forms.Button();
            this.twenty_p = new System.Windows.Forms.Button();
            this.ten_p = new System.Windows.Forms.Button();
            this.five_p = new System.Windows.Forms.Button();
            this.two_p = new System.Windows.Forms.Button();
            this.one_p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moneyInserted
            // 
            this.moneyInserted.Location = new System.Drawing.Point(204, 53);
            this.moneyInserted.Name = "moneyInserted";
            this.moneyInserted.Size = new System.Drawing.Size(170, 20);
            this.moneyInserted.TabIndex = 33;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(204, 79);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 34;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(299, 79);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Coins to insert: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Inserted:";
            // 
            // two_pounds
            // 
            this.two_pounds.Image = global::Vending_Machine.Properties.Resources._2pounds;
            this.two_pounds.Location = new System.Drawing.Point(100, 267);
            this.two_pounds.Name = "two_pounds";
            this.two_pounds.Size = new System.Drawing.Size(75, 71);
            this.two_pounds.TabIndex = 30;
            this.two_pounds.UseVisualStyleBackColor = true;
            this.two_pounds.Click += new System.EventHandler(this.two_pounds_Click);
            // 
            // one_pound
            // 
            this.one_pound.Image = global::Vending_Machine.Properties.Resources._1_pound;
            this.one_pound.Location = new System.Drawing.Point(100, 196);
            this.one_pound.Name = "one_pound";
            this.one_pound.Size = new System.Drawing.Size(75, 71);
            this.one_pound.TabIndex = 29;
            this.one_pound.UseVisualStyleBackColor = true;
            this.one_pound.Click += new System.EventHandler(this.one_pound_Click);
            // 
            // fifty_p
            // 
            this.fifty_p.Image = global::Vending_Machine.Properties.Resources._50p;
            this.fifty_p.Location = new System.Drawing.Point(102, 122);
            this.fifty_p.Name = "fifty_p";
            this.fifty_p.Size = new System.Drawing.Size(73, 69);
            this.fifty_p.TabIndex = 28;
            this.fifty_p.UseVisualStyleBackColor = true;
            this.fifty_p.Click += new System.EventHandler(this.fifty_p_Click);
            // 
            // twenty_p
            // 
            this.twenty_p.Image = global::Vending_Machine.Properties.Resources._20p;
            this.twenty_p.Location = new System.Drawing.Point(102, 53);
            this.twenty_p.Name = "twenty_p";
            this.twenty_p.Size = new System.Drawing.Size(73, 65);
            this.twenty_p.TabIndex = 27;
            this.twenty_p.UseVisualStyleBackColor = true;
            this.twenty_p.Click += new System.EventHandler(this.twenty_p_Click);
            // 
            // ten_p
            // 
            this.ten_p.Image = global::Vending_Machine.Properties.Resources._10p;
            this.ten_p.Location = new System.Drawing.Point(29, 267);
            this.ten_p.Name = "ten_p";
            this.ten_p.Size = new System.Drawing.Size(67, 71);
            this.ten_p.TabIndex = 26;
            this.ten_p.UseVisualStyleBackColor = true;
            this.ten_p.Click += new System.EventHandler(this.ten_p_Click);
            // 
            // five_p
            // 
            this.five_p.Image = global::Vending_Machine.Properties.Resources._5p;
            this.five_p.Location = new System.Drawing.Point(29, 196);
            this.five_p.Name = "five_p";
            this.five_p.Size = new System.Drawing.Size(67, 71);
            this.five_p.TabIndex = 25;
            this.five_p.UseVisualStyleBackColor = true;
            this.five_p.Click += new System.EventHandler(this.five_p_Click);
            // 
            // two_p
            // 
            this.two_p.Image = global::Vending_Machine.Properties.Resources._2p1;
            this.two_p.Location = new System.Drawing.Point(29, 121);
            this.two_p.Name = "two_p";
            this.two_p.Size = new System.Drawing.Size(67, 70);
            this.two_p.TabIndex = 24;
            this.two_p.UseVisualStyleBackColor = true;
            this.two_p.Click += new System.EventHandler(this.two_p_Click);
            // 
            // one_p
            // 
            this.one_p.Image = global::Vending_Machine.Properties.Resources._1p3;
            this.one_p.Location = new System.Drawing.Point(29, 50);
            this.one_p.Name = "one_p";
            this.one_p.Size = new System.Drawing.Size(67, 68);
            this.one_p.TabIndex = 23;
            this.one_p.UseVisualStyleBackColor = true;
            this.one_p.Click += new System.EventHandler(this.one_p_Click);
            // 
            // Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.moneyInserted);
            this.Controls.Add(this.two_pounds);
            this.Controls.Add(this.one_pound);
            this.Controls.Add(this.fifty_p);
            this.Controls.Add(this.twenty_p);
            this.Controls.Add(this.ten_p);
            this.Controls.Add(this.five_p);
            this.Controls.Add(this.two_p);
            this.Controls.Add(this.one_p);
            this.Name = "Money";
            this.Text = "Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button two_pounds;
        private System.Windows.Forms.Button one_pound;
        private System.Windows.Forms.Button fifty_p;
        private System.Windows.Forms.Button twenty_p;
        private System.Windows.Forms.Button ten_p;
        private System.Windows.Forms.Button five_p;
        private System.Windows.Forms.Button two_p;
        private System.Windows.Forms.Button one_p;
        private System.Windows.Forms.TextBox moneyInserted;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}