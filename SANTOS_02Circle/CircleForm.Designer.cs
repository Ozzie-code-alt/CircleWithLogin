namespace SANTOS_02Circle
{
    partial class CircleForm
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
            this.txtBoxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCircum = new System.Windows.Forms.TextBox();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.btntotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxRadius
            // 
            this.txtBoxRadius.Location = new System.Drawing.Point(337, 139);
            this.txtBoxRadius.Name = "txtBoxRadius";
            this.txtBoxRadius.Size = new System.Drawing.Size(87, 22);
            this.txtBoxRadius.TabIndex = 0;
            this.txtBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Radius of Circle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "CIrcumference";
            // 
            // txtBoxCircum
            // 
            this.txtBoxCircum.Location = new System.Drawing.Point(318, 340);
            this.txtBoxCircum.Name = "txtBoxCircum";
            this.txtBoxCircum.Size = new System.Drawing.Size(139, 22);
            this.txtBoxCircum.TabIndex = 4;
            this.txtBoxCircum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCircum.TextChanged += new System.EventHandler(this.txtBoxCircum_TextChanged);
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.Location = new System.Drawing.Point(318, 264);
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(139, 22);
            this.txtBoxArea.TabIndex = 5;
            this.txtBoxArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxArea.TextChanged += new System.EventHandler(this.txtBoxCircum_TextChanged);
            // 
            // btntotal
            // 
            this.btntotal.Location = new System.Drawing.Point(336, 190);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(88, 23);
            this.btntotal.TabIndex = 6;
            this.btntotal.Text = "calculate";
            this.btntotal.UseVisualStyleBackColor = true;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntotal);
            this.Controls.Add(this.txtBoxArea);
            this.Controls.Add(this.txtBoxCircum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRadius);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCircum;
        private System.Windows.Forms.TextBox txtBoxArea;
        private System.Windows.Forms.Button btntotal;
    }
}