namespace WinFormsApp
{
    partial class formPrincipal
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
            btnPessoa = new Button();
            btnCidades = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnPessoa
            // 
            btnPessoa.Location = new Point(3, 3);
            btnPessoa.Name = "btnPessoa";
            btnPessoa.Size = new Size(159, 32);
            btnPessoa.TabIndex = 0;
            btnPessoa.Text = "Pessoas";
            btnPessoa.UseVisualStyleBackColor = true;
            btnPessoa.Click += btnPessoa_Click;
            // 
            // btnCidades
            // 
            btnCidades.Location = new Point(3, 41);
            btnCidades.Name = "btnCidades";
            btnCidades.Size = new Size(159, 32);
            btnCidades.TabIndex = 1;
            btnCidades.Text = "Cidades";
            btnCidades.UseVisualStyleBackColor = true;
            btnCidades.Click += btnCidades_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 79);
            button3.Name = "button3";
            button3.Size = new Size(159, 32);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 229);
            Controls.Add(button3);
            Controls.Add(btnCidades);
            Controls.Add(btnPessoa);
            Name = "formPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPessoa;
        private Button btnCidades;
        private Button button3;
    }
}