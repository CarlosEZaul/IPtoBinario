namespace IPtoBinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtocteto1 = new System.Windows.Forms.TextBox();
            this.txtocteto2 = new System.Windows.Forms.TextBox();
            this.txtocteto3 = new System.Windows.Forms.TextBox();
            this.txtocteto4 = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um IP";
            // 
            // txtocteto1
            // 
            this.txtocteto1.Location = new System.Drawing.Point(74, 130);
            this.txtocteto1.Name = "txtocteto1";
            this.txtocteto1.Size = new System.Drawing.Size(201, 26);
            this.txtocteto1.TabIndex = 1;
            this.txtocteto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtocteto2
            // 
            this.txtocteto2.Location = new System.Drawing.Point(315, 126);
            this.txtocteto2.Name = "txtocteto2";
            this.txtocteto2.Size = new System.Drawing.Size(201, 26);
            this.txtocteto2.TabIndex = 2;
            this.txtocteto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtocteto3
            // 
            this.txtocteto3.Location = new System.Drawing.Point(543, 130);
            this.txtocteto3.Name = "txtocteto3";
            this.txtocteto3.Size = new System.Drawing.Size(201, 26);
            this.txtocteto3.TabIndex = 3;
            this.txtocteto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtocteto4
            // 
            this.txtocteto4.Location = new System.Drawing.Point(770, 130);
            this.txtocteto4.Name = "txtocteto4";
            this.txtocteto4.Size = new System.Drawing.Size(201, 26);
            this.txtocteto4.TabIndex = 4;
            this.txtocteto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(1004, 121);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(98, 44);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1134, 121);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 44);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1272, 261);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtocteto4);
            this.Controls.Add(this.txtocteto3);
            this.Controls.Add(this.txtocteto2);
            this.Controls.Add(this.txtocteto1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP para Binário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLimpar;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtocteto1;
        private System.Windows.Forms.TextBox txtocteto2;
        private System.Windows.Forms.TextBox txtocteto3;
        private System.Windows.Forms.TextBox txtocteto4;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}