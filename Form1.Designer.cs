namespace Vending_Machine
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showChange = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.moneyInserted = new System.Windows.Forms.TextBox();
            this.Mountain = new System.Windows.Forms.Button();
            this.Pepsi = new System.Windows.Forms.Button();
            this.Schweppes = new System.Windows.Forms.Button();
            this.Mirinda = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.Button();
            this.Coke = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.TextBox();
            this.service = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Nothing is selected";
            // 
            // showChange
            // 
            this.showChange.Location = new System.Drawing.Point(510, 123);
            this.showChange.Multiline = true;
            this.showChange.Name = "showChange";
            this.showChange.Size = new System.Drawing.Size(176, 99);
            this.showChange.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = " Return money";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Insert credits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.Tomato;
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buy.Location = new System.Drawing.Point(510, 237);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(174, 59);
            this.buy.TabIndex = 10;
            this.buy.Text = "Buy now";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // moneyInserted
            // 
            this.moneyInserted.Location = new System.Drawing.Point(510, 97);
            this.moneyInserted.Name = "moneyInserted";
            this.moneyInserted.Size = new System.Drawing.Size(176, 20);
            this.moneyInserted.TabIndex = 12;
            this.moneyInserted.Text = "£ 0";
            // 
            // Mountain
            // 
            this.Mountain.Image = global::Vending_Machine.Properties.Resources.Mountine;
            this.Mountain.Location = new System.Drawing.Point(190, 352);
            this.Mountain.Name = "Mountain";
            this.Mountain.Size = new System.Drawing.Size(131, 131);
            this.Mountain.TabIndex = 5;
            this.Mountain.UseVisualStyleBackColor = true;
            this.Mountain.Click += new System.EventHandler(this.Mountain_Click);
            // 
            // Pepsi
            // 
            this.Pepsi.Image = global::Vending_Machine.Properties.Resources.Pepsi;
            this.Pepsi.Location = new System.Drawing.Point(190, 71);
            this.Pepsi.Name = "Pepsi";
            this.Pepsi.Size = new System.Drawing.Size(131, 139);
            this.Pepsi.TabIndex = 4;
            this.Pepsi.UseVisualStyleBackColor = true;
            this.Pepsi.Click += new System.EventHandler(this.Pepsi_Click);
            // 
            // Schweppes
            // 
            this.Schweppes.Image = global::Vending_Machine.Properties.Resources.Schweppes;
            this.Schweppes.Location = new System.Drawing.Point(190, 216);
            this.Schweppes.Name = "Schweppes";
            this.Schweppes.Size = new System.Drawing.Size(131, 130);
            this.Schweppes.TabIndex = 3;
            this.Schweppes.UseVisualStyleBackColor = true;
            this.Schweppes.Click += new System.EventHandler(this.Schweppes_Click);
            // 
            // Mirinda
            // 
            this.Mirinda.Image = global::Vending_Machine.Properties.Resources.Mirinda;
            this.Mirinda.Location = new System.Drawing.Point(39, 352);
            this.Mirinda.Name = "Mirinda";
            this.Mirinda.Size = new System.Drawing.Size(136, 131);
            this.Mirinda.TabIndex = 2;
            this.Mirinda.UseVisualStyleBackColor = true;
            this.Mirinda.Click += new System.EventHandler(this.Mirinda_Click);
            // 
            // Sprite
            // 
            this.Sprite.Image = global::Vending_Machine.Properties.Resources.Sprite;
            this.Sprite.Location = new System.Drawing.Point(39, 216);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(136, 130);
            this.Sprite.TabIndex = 1;
            this.Sprite.UseVisualStyleBackColor = true;
            this.Sprite.Click += new System.EventHandler(this.Sprite_Click);
            // 
            // Coke
            // 
            this.Coke.Image = global::Vending_Machine.Properties.Resources.COCA_COLA;
            this.Coke.Location = new System.Drawing.Point(39, 71);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(136, 139);
            this.Coke.TabIndex = 0;
            this.Coke.UseVisualStyleBackColor = true;
            this.Coke.Click += new System.EventHandler(this.Coke_Click);
            // 
            // warning
            // 
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(352, 71);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(332, 22);
            this.warning.TabIndex = 23;
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(39, 14);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(103, 34);
            this.service.TabIndex = 24;
            this.service.Text = "Service mode";
            this.service.UseVisualStyleBackColor = true;
            this.service.Click += new System.EventHandler(this.service_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 497);
            this.Controls.Add(this.service);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.moneyInserted);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showChange);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mountain);
            this.Controls.Add(this.Pepsi);
            this.Controls.Add(this.Schweppes);
            this.Controls.Add(this.Mirinda);
            this.Controls.Add(this.Sprite);
            this.Controls.Add(this.Coke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coke;
        private System.Windows.Forms.Button Sprite;
        private System.Windows.Forms.Button Mirinda;
        private System.Windows.Forms.Button Schweppes;
        private System.Windows.Forms.Button Pepsi;
        private System.Windows.Forms.Button Mountain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox showChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.TextBox moneyInserted;
        private System.Windows.Forms.TextBox warning;
        private System.Windows.Forms.Button service;
    }
}

