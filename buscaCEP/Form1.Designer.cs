namespace buscaCEP
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
            label1 = new Label();
            txtCEP = new TextBox();
            lblResultado = new Label();
            btnGerar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Insira seu CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(177, 36);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(91, 199);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Seus dados:";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(141, 173);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 3;
            btnGerar.Text = "OK";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(91, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "XML";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(91, 109);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(53, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "JSON";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(91, 134);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "PIPED";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnGerar);
            Controls.Add(lblResultado);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCEP;
        private Label lblResultado;
        private Button btnGerar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
