namespace qlthuchi
{
    partial class floaichi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floaichi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaloaichi = new System.Windows.Forms.TextBox();
            this.txttenlaoichi = new System.Windows.Forms.TextBox();
            this.dtgvloaichi = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaichi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại chi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại chi:";
            // 
            // txtmaloaichi
            // 
            this.txtmaloaichi.Location = new System.Drawing.Point(135, 58);
            this.txtmaloaichi.Multiline = true;
            this.txtmaloaichi.Name = "txtmaloaichi";
            this.txtmaloaichi.ReadOnly = true;
            this.txtmaloaichi.Size = new System.Drawing.Size(285, 38);
            this.txtmaloaichi.TabIndex = 6;
            // 
            // txttenlaoichi
            // 
            this.txttenlaoichi.Location = new System.Drawing.Point(135, 111);
            this.txttenlaoichi.Multiline = true;
            this.txttenlaoichi.Name = "txttenlaoichi";
            this.txttenlaoichi.Size = new System.Drawing.Size(285, 38);
            this.txttenlaoichi.TabIndex = 7;
            // 
            // dtgvloaichi
            // 
            this.dtgvloaichi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvloaichi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvloaichi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvloaichi.Location = new System.Drawing.Point(25, 208);
            this.dtgvloaichi.Name = "dtgvloaichi";
            this.dtgvloaichi.RowHeadersWidth = 51;
            this.dtgvloaichi.RowTemplate.Height = 24;
            this.dtgvloaichi.Size = new System.Drawing.Size(409, 239);
            this.dtgvloaichi.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Image = global::qlthuchi.Properties.Resources.go_back256_24856;
            this.button4.Location = new System.Drawing.Point(350, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 47);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = global::qlthuchi.Properties.Resources._1486505375_edit_pen_change_option_pencil_write_81422;
            this.button2.Location = new System.Drawing.Point(197, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 47);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::qlthuchi.Properties.Resources.add_icon_icons_com_74429;
            this.button1.Location = new System.Drawing.Point(38, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 47);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // floaichi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 459);
            this.Controls.Add(this.dtgvloaichi);
            this.Controls.Add(this.txttenlaoichi);
            this.Controls.Add(this.txtmaloaichi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "floaichi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại chi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvloaichi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmaloaichi;
        private System.Windows.Forms.TextBox txttenlaoichi;
        private System.Windows.Forms.DataGridView dtgvloaichi;
    }
}