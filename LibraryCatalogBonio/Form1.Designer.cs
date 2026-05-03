namespace LibraryCatalog.Models
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.TextBox();
            this.AUTHOR = new System.Windows.Forms.TextBox();
            this.PUBLISHED = new System.Windows.Forms.TextBox();
            this.COPIES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.RETURN = new System.Windows.Forms.Button();
            this.REMOVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(357, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 303);
            this.listBox1.TabIndex = 0;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(142, 23);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(194, 20);
            this.ISBN.TabIndex = 1;
            // 
            // TITLE
            // 
            this.TITLE.Location = new System.Drawing.Point(142, 72);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(194, 20);
            this.TITLE.TabIndex = 2;
            // 
            // AUTHOR
            // 
            this.AUTHOR.Location = new System.Drawing.Point(142, 125);
            this.AUTHOR.Name = "AUTHOR";
            this.AUTHOR.Size = new System.Drawing.Size(194, 20);
            this.AUTHOR.TabIndex = 3;
            // 
            // PUBLISHED
            // 
            this.PUBLISHED.Location = new System.Drawing.Point(142, 174);
            this.PUBLISHED.Name = "PUBLISHED";
            this.PUBLISHED.Size = new System.Drawing.Size(194, 20);
            this.PUBLISHED.TabIndex = 4;
            // 
            // COPIES
            // 
            this.COPIES.Location = new System.Drawing.Point(142, 229);
            this.COPIES.Name = "COPIES";
            this.COPIES.Size = new System.Drawing.Size(194, 20);
            this.COPIES.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TITLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "AUTHOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "YEAR PUBLISHED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "COPIES AVAILABLE";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(16, 267);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(73, 59);
            this.ADD.TabIndex = 11;
            this.ADD.Text = "Add Book";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(142, 267);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 59);
            this.CLEAR.TabIndex = 12;
            this.CLEAR.Text = "Clear fields";
            this.CLEAR.UseVisualStyleBackColor = true;
            // 
            // RETURN
            // 
            this.RETURN.Location = new System.Drawing.Point(261, 267);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(75, 59);
            this.RETURN.TabIndex = 13;
            this.RETURN.Text = "Return Book";
            this.RETURN.UseVisualStyleBackColor = true;
            // 
            // REMOVE
            // 
            this.REMOVE.Location = new System.Drawing.Point(16, 355);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(320, 59);
            this.REMOVE.TabIndex = 14;
            this.REMOVE.Text = "Remove Book";
            this.REMOVE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COPIES);
            this.Controls.Add(this.PUBLISHED);
            this.Controls.Add(this.AUTHOR);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox TITLE;
        private System.Windows.Forms.TextBox AUTHOR;
        private System.Windows.Forms.TextBox PUBLISHED;
        private System.Windows.Forms.TextBox COPIES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button RETURN;
        private System.Windows.Forms.Button REMOVE;
    }
}

