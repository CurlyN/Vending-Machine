namespace Vending_Machine
{
    partial class Service_mode
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
            this.button2 = new System.Windows.Forms.Button();
            this.listOfItems = new System.Windows.Forms.TextBox();
            this.listOfChange = new System.Windows.Forms.TextBox();
            this.getInfo = new System.Windows.Forms.Button();
            this.Mountain = new System.Windows.Forms.Button();
            this.Pepsi = new System.Windows.Forms.Button();
            this.Schweppes = new System.Windows.Forms.Button();
            this.Mirinda = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.Button();
            this.Coke = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.showItem = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listOfItems
            // 
            this.listOfItems.Location = new System.Drawing.Point(183, 69);
            this.listOfItems.Multiline = true;
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(159, 199);
            this.listOfItems.TabIndex = 2;
            // 
            // listOfChange
            // 
            this.listOfChange.Location = new System.Drawing.Point(12, 69);
            this.listOfChange.Multiline = true;
            this.listOfChange.Name = "listOfChange";
            this.listOfChange.Size = new System.Drawing.Size(165, 199);
            this.listOfChange.TabIndex = 3;
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(198, 275);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(127, 57);
            this.getInfo.TabIndex = 4;
            this.getInfo.Text = "Get information ";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.getInfo_Click);
            // 
            // Mountain
            // 
            this.Mountain.Image = global::Vending_Machine.Properties.Resources.Mountine;
            this.Mountain.Location = new System.Drawing.Point(528, 214);
            this.Mountain.Name = "Mountain";
            this.Mountain.Size = new System.Drawing.Size(131, 131);
            this.Mountain.TabIndex = 11;
            this.Mountain.UseVisualStyleBackColor = true;
            this.Mountain.Click += new System.EventHandler(this.Mountain_Click);
            // 
            // Pepsi
            // 
            this.Pepsi.Image = global::Vending_Machine.Properties.Resources.Pepsi;
            this.Pepsi.Location = new System.Drawing.Point(528, 69);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(131, 139);
            this.Pepsi.TabIndex = 10;
            this.Pepsi.UseVisualStyleBackColor = true;
            this.Pepsi.Click += new System.EventHandler(this.Pepsi_Click);
            // 
            // Schweppes
            // 
            this.Schweppes.Image = global::Vending_Machine.Properties.Resources.Schweppes;
            this.Schweppes.Location = new System.Drawing.Point(665, 214);
            this.Schweppes.Name = "Schweppes";
            this.Schweppes.Size = new System.Drawing.Size(136, 130);
            this.Schweppes.TabIndex = 9;
            this.Schweppes.UseVisualStyleBackColor = true;
            this.Schweppes.Click += new System.EventHandler(this.Schweppes_Click);
            // 
            // Mirinda
            // 
            this.Mirinda.Image = global::Vending_Machine.Properties.Resources.Mirinda;
            this.Mirinda.Location = new System.Drawing.Point(386, 214);
            this.Mirinda.Name = "Mirinda";
            this.Mirinda.Size = new System.Drawing.Size(136, 131);
            this.Mirinda.TabIndex = 8;
            this.Mirinda.UseVisualStyleBackColor = true;
            this.Mirinda.Click += new System.EventHandler(this.Mirinda_Click);
            // 
            // Sprite
            // 
            this.Sprite.Image = global::Vending_Machine.Properties.Resources.Sprite;
            this.Sprite.Location = new System.Drawing.Point(665, 69);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(136, 139);
            this.Sprite.TabIndex = 7;
            this.Sprite.UseVisualStyleBackColor = true;
            this.Sprite.Click += new System.EventHandler(this.Sprite_Click);
            // 
            // Coke
            // 
            this.Coke.Image = global::Vending_Machine.Properties.Resources.COCA_COLA;
            this.Coke.Location = new System.Drawing.Point(386, 69);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(136, 137);
            this.Coke.TabIndex = 6;
            this.Coke.UseVisualStyleBackColor = true;
            this.Coke.Click += new System.EventHandler(this.Coke_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(598, 20);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 30);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add item";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(702, 20);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 30);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete item";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // showItem
            // 
            this.showItem.Location = new System.Drawing.Point(386, 26);
            this.showItem.Name = "showItem";
            this.showItem.Size = new System.Drawing.Size(193, 20);
            this.showItem.TabIndex = 14;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(12, 15);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 39);
            this.close.TabIndex = 15;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Service_mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 371);
            this.Controls.Add(this.close);
            this.Controls.Add(this.showItem);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Mountain);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.Schweppes);
            this.Controls.Add(this.Mirinda);
            this.Controls.Add(this.Sprite);
            this.Controls.Add(this.Coke);
            this.Controls.Add(this.getInfo);
            this.Controls.Add(this.listOfChange);
            this.Controls.Add(this.listOfItems);
            this.Controls.Add(this.button2);
            this.Name = "Service_mode";
            this.Text = "Service_mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox listOfItems;
        private System.Windows.Forms.TextBox listOfChange;
        private System.Windows.Forms.Button getInfo;
        private System.Windows.Forms.Button Mountain;
        private System.Windows.Forms.Button Pepsi;
        private System.Windows.Forms.Button Schweppes;
        private System.Windows.Forms.Button Mirinda;
        private System.Windows.Forms.Button Sprite;
        private System.Windows.Forms.Button Coke;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox showItem;
        private System.Windows.Forms.Button close;
    }
}