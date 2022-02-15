namespace qlthuchi
{
    partial class floaithu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floaithu));
            this.txtidloaithu = new System.Windows.Forms.TextBox();
            this.txttypethu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvloaithu = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaithu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidloaithu
            // 
            this.txtidloaithu.Location = new System.Drawing.Point(134, 52);
            this.txtidloaithu.Multiline = true;
            this.txtidloaithu.Name = "txtidloaithu";
            this.txtidloaithu.ReadOnly = true;
            this.txtidloaithu.Size = new System.Drawing.Size(285, 38);
            this.txtidloaithu.TabIndex = 0;
            // 
            // txttypethu
            // 
            this.txttypethu.Location = new System.Drawing.Point(134, 111);
            this.txttypethu.Multiline = true;
            this.txttypethu.Name = "txttypethu";
            this.txttypethu.Size = new System.Drawing.Size(285, 38);
            this.txttypethu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại thu:";
            // 
            // dtgvloaithu
            // 
            this.dtgvloaithu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvloaithu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvloaithu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvloaithu.Location = new System.Drawing.Point(30, 208);
            this.dtgvloaithu.Name = "dtgvloaithu";
            this.dtgvloaithu.RowHeadersWidth = 51;
            this.dtgvloaithu.RowTemplate.Height = 24;
            this.dtgvloaithu.Size = new System.Drawing.Size(409, 239);
            this.dtgvloaithu.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.Image = global::qlthuchi.Properties.Resources.go_back256_24856;
            this.btnback.Location = new System.Drawing.Point(359, 155);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(70, 47);
            this.btnback.TabIndex = 8;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnchange
            // 
            this.btnchange.Image = global::qlthuchi.Properties.Resources._1486505375_edit_pen_change_option_pencil_write_81422;
            this.btnchange.Location = new System.Drawing.Point(207, 155);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(70, 47);
            this.btnchange.TabIndex = 5;
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = global::qlthuchi.Properties.Resources.add_icon_icons_com_74429;
            this.btnadd.Location = new System.Drawing.Point(44, 155);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(70, 47);
            this.btnadd.TabIndex = 4;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // floaithu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 459);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dtgvloaithu);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttypethu);
            this.Controls.Add(this.txtidloaithu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "floaithu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại thu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaithu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidloaithu;
        private System.Windows.Forms.TextBox txttypethu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.DataGridView dtgvloaithu;
        private System.Windows.Forms.Button btnback;
    }
}