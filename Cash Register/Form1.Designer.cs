namespace Cash_Register
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
            this.burger = new System.Windows.Forms.Label();
            this.salad = new System.Windows.Forms.Label();
            this.recipetoutput = new System.Windows.Forms.Label();
            this.fries = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.taxoutput = new System.Windows.Forms.Label();
            this.subtotaloutput = new System.Windows.Forms.Label();
            this.totaloutput = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.burgertextBox = new System.Windows.Forms.TextBox();
            this.numfriestextBox = new System.Windows.Forms.TextBox();
            this.saladtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calculatetotalbutton = new System.Windows.Forms.Button();
            this.calculatechange = new System.Windows.Forms.Button();
            this.tendred = new System.Windows.Forms.Label();
            this.tenderetextbox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Label();
            this.changeoutput = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.neworder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burger
            // 
            this.burger.AutoSize = true;
            this.burger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burger.Location = new System.Drawing.Point(80, 57);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(80, 25);
            this.burger.TabIndex = 0;
            this.burger.Text = "Burgers";
            // 
            // salad
            // 
            this.salad.AutoSize = true;
            this.salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salad.Location = new System.Drawing.Point(80, 94);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(63, 25);
            this.salad.TabIndex = 1;
            this.salad.Text = "Salad";
            this.salad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recipetoutput
            // 
            this.recipetoutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recipetoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipetoutput.Location = new System.Drawing.Point(288, 57);
            this.recipetoutput.Name = "recipetoutput";
            this.recipetoutput.Size = new System.Drawing.Size(312, 430);
            this.recipetoutput.TabIndex = 2;
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fries.Location = new System.Drawing.Point(80, 127);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(55, 25);
            this.fries.TabIndex = 3;
            this.fries.Text = "Fries";
            this.fries.Click += new System.EventHandler(this.fries_Click);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(82, 228);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(84, 25);
            this.Subtotal.TabIndex = 4;
            this.Subtotal.Text = "Subtotal";
            // 
            // taxoutput
            // 
            this.taxoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxoutput.Location = new System.Drawing.Point(187, 267);
            this.taxoutput.Name = "taxoutput";
            this.taxoutput.Size = new System.Drawing.Size(95, 25);
            this.taxoutput.TabIndex = 5;
            this.taxoutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subtotaloutput
            // 
            this.subtotaloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaloutput.Location = new System.Drawing.Point(187, 228);
            this.subtotaloutput.Name = "subtotaloutput";
            this.subtotaloutput.Size = new System.Drawing.Size(95, 25);
            this.subtotaloutput.TabIndex = 6;
            this.subtotaloutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totaloutput
            // 
            this.totaloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaloutput.Location = new System.Drawing.Point(187, 303);
            this.totaloutput.Name = "totaloutput";
            this.totaloutput.Size = new System.Drawing.Size(95, 25);
            this.totaloutput.TabIndex = 7;
            this.totaloutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(82, 303);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(56, 25);
            this.Total.TabIndex = 8;
            this.Total.Text = "Total";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(82, 267);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(46, 25);
            this.tax.TabIndex = 9;
            this.tax.Text = "Tax";
            // 
            // burgertextBox
            // 
            this.burgertextBox.Location = new System.Drawing.Point(182, 57);
            this.burgertextBox.Name = "burgertextBox";
            this.burgertextBox.Size = new System.Drawing.Size(43, 22);
            this.burgertextBox.TabIndex = 10;
            this.burgertextBox.TextChanged += new System.EventHandler(this.burgertextBox_TextChanged);
            // 
            // numfriestextBox
            // 
            this.numfriestextBox.Location = new System.Drawing.Point(182, 130);
            this.numfriestextBox.Name = "numfriestextBox";
            this.numfriestextBox.Size = new System.Drawing.Size(43, 22);
            this.numfriestextBox.TabIndex = 11;
            // 
            // saladtextBox
            // 
            this.saladtextBox.Location = new System.Drawing.Point(182, 94);
            this.saladtextBox.Name = "saladtextBox";
            this.saladtextBox.Size = new System.Drawing.Size(43, 22);
            this.saladtextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(124, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print Receipet ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculatetotalbutton
            // 
            this.calculatetotalbutton.Location = new System.Drawing.Point(106, 159);
            this.calculatetotalbutton.Name = "calculatetotalbutton";
            this.calculatetotalbutton.Size = new System.Drawing.Size(176, 66);
            this.calculatetotalbutton.TabIndex = 14;
            this.calculatetotalbutton.Text = "Calculate";
            this.calculatetotalbutton.UseVisualStyleBackColor = true;
            this.calculatetotalbutton.Click += new System.EventHandler(this.calculatetotalbutton_Click);
            // 
            // calculatechange
            // 
            this.calculatechange.Enabled = false;
            this.calculatechange.Location = new System.Drawing.Point(106, 379);
            this.calculatechange.Name = "calculatechange";
            this.calculatechange.Size = new System.Drawing.Size(160, 58);
            this.calculatechange.TabIndex = 15;
            this.calculatechange.Text = "Calculate Change";
            this.calculatechange.UseVisualStyleBackColor = true;
            this.calculatechange.Click += new System.EventHandler(this.button3_Click);
            // 
            // tendred
            // 
            this.tendred.AutoSize = true;
            this.tendred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendred.Location = new System.Drawing.Point(80, 347);
            this.tendred.Name = "tendred";
            this.tendred.Size = new System.Drawing.Size(86, 25);
            this.tendred.TabIndex = 16;
            this.tendred.Text = "Tendred";
            // 
            // tenderetextbox
            // 
            this.tenderetextbox.Location = new System.Drawing.Point(182, 351);
            this.tenderetextbox.Name = "tenderetextbox";
            this.tenderetextbox.Size = new System.Drawing.Size(43, 22);
            this.tenderetextbox.TabIndex = 17;
            this.tenderetextbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(82, 440);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(82, 25);
            this.Change.TabIndex = 18;
            this.Change.Text = "Change";
            // 
            // changeoutput
            // 
            this.changeoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeoutput.Location = new System.Drawing.Point(190, 440);
            this.changeoutput.Name = "changeoutput";
            this.changeoutput.Size = new System.Drawing.Size(76, 23);
            this.changeoutput.TabIndex = 19;
            this.changeoutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Red;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-58, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(744, 50);
            this.title.TabIndex = 20;
            this.title.Text = "Burger Clan";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neworder
            // 
            this.neworder.Enabled = false;
            this.neworder.Location = new System.Drawing.Point(330, 490);
            this.neworder.Name = "neworder";
            this.neworder.Size = new System.Drawing.Size(242, 27);
            this.neworder.TabIndex = 21;
            this.neworder.Text = "New Order";
            this.neworder.UseVisualStyleBackColor = true;
            this.neworder.Click += new System.EventHandler(this.neworder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 528);
            this.Controls.Add(this.neworder);
            this.Controls.Add(this.title);
            this.Controls.Add(this.changeoutput);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.tenderetextbox);
            this.Controls.Add(this.tendred);
            this.Controls.Add(this.calculatechange);
            this.Controls.Add(this.calculatetotalbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saladtextBox);
            this.Controls.Add(this.numfriestextBox);
            this.Controls.Add(this.burgertextBox);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.totaloutput);
            this.Controls.Add(this.subtotaloutput);
            this.Controls.Add(this.taxoutput);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.fries);
            this.Controls.Add(this.recipetoutput);
            this.Controls.Add(this.salad);
            this.Controls.Add(this.burger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burger;
        private System.Windows.Forms.Label salad;
        private System.Windows.Forms.Label recipetoutput;
        private System.Windows.Forms.Label fries;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label taxoutput;
        private System.Windows.Forms.Label subtotaloutput;
        private System.Windows.Forms.Label totaloutput;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.TextBox burgertextBox;
        private System.Windows.Forms.TextBox numfriestextBox;
        private System.Windows.Forms.TextBox saladtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculatetotalbutton;
        private System.Windows.Forms.Button calculatechange;
        private System.Windows.Forms.Label tendred;
        private System.Windows.Forms.TextBox tenderetextbox;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.Label changeoutput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button neworder;
    }
}

