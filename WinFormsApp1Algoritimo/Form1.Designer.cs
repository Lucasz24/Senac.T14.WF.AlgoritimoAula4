namespace WinFormsApp1Algoritimo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(28, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 56);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "Numero da conta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 56);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 1;
            label2.Text = "Titular da conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 262);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 2;
            label3.Text = "Saldo da conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 262);
            label4.Name = "label4";
            label4.Size = new Size(160, 32);
            label4.TabIndex = 3;
            label4.Text = "Tipo da conta";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Location = new Point(18, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 39);
            textBox1.TabIndex = 4;
            textBox1.Text = "123456";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 39);
            textBox2.TabIndex = 5;
            textBox2.Text = "Lucas Viegas de Freitas";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Lime;
            textBox3.Location = new Point(18, 297);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 39);
            textBox3.TabIndex = 6;
            textBox3.Text = "1000";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(408, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 39);
            textBox4.TabIndex = 7;
            textBox4.Text = "Corrente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
