namespace dataGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.prodId = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(108, 178);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(159, 20);
            this.id.TabIndex = 2;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // prodId
            // 
            this.prodId.AutoSize = true;
            this.prodId.Location = new System.Drawing.Point(21, 185);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(58, 13);
            this.prodId.TabIndex = 3;
            this.prodId.Text = "Product ID";
            // 
            // prodPrice
            // 
            this.prodPrice.AutoSize = true;
            this.prodPrice.Location = new System.Drawing.Point(21, 259);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(71, 13);
            this.prodPrice.TabIndex = 4;
            this.prodPrice.Text = "Product Price";
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.Location = new System.Drawing.Point(21, 223);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(75, 13);
            this.prodName.TabIndex = 5;
            this.prodName.Text = "Product Name";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(108, 252);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(159, 20);
            this.price.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(159, 20);
            this.name.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodId);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label prodId;
        private System.Windows.Forms.Label prodPrice;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
    }
}

