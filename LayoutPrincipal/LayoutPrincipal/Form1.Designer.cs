namespace LayoutPrincipal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            MenuVertical = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            BarradeTitulo = new Panel();
            IconRestaurar = new PictureBox();
            IconMaximizar = new PictureBox();
            IconMinimizar = new PictureBox();
            IconFechar = new PictureBox();
            PainelConteudo = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarradeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconFechar).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = SystemColors.HotTrack;
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(235, 450);
            MenuVertical.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 79, 139);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 79, 139);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(5, 202);
            button4.Name = "button4";
            button4.Size = new Size(230, 41);
            button4.TabIndex = 4;
            button4.Text = "Configurações";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 79, 139);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 79, 139);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 155);
            button3.Name = "button3";
            button3.Size = new Size(230, 41);
            button3.TabIndex = 3;
            button3.Text = "Projetos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 79, 139);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 79, 139);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(5, 108);
            button2.Name = "button2";
            button2.Size = new Size(230, 41);
            button2.TabIndex = 2;
            button2.Text = "Chamados";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 79, 139);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 79, 139);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 61);
            button1.Name = "button1";
            button1.Size = new Size(230, 41);
            button1.TabIndex = 1;
            button1.Text = "Cadastros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BarradeTitulo
            // 
            BarradeTitulo.Controls.Add(IconRestaurar);
            BarradeTitulo.Controls.Add(IconMaximizar);
            BarradeTitulo.Controls.Add(IconMinimizar);
            BarradeTitulo.Controls.Add(IconFechar);
            BarradeTitulo.Dock = DockStyle.Top;
            BarradeTitulo.Location = new Point(235, 0);
            BarradeTitulo.Name = "BarradeTitulo";
            BarradeTitulo.Size = new Size(565, 50);
            BarradeTitulo.TabIndex = 2;
            BarradeTitulo.MouseDown += BarradeTitulo_MouseDown;
            // 
            // IconRestaurar
            // 
            IconRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconRestaurar.Image = (Image)resources.GetObject("IconRestaurar.Image");
            IconRestaurar.Location = new Point(478, 12);
            IconRestaurar.Name = "IconRestaurar";
            IconRestaurar.Size = new Size(36, 25);
            IconRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            IconRestaurar.TabIndex = 3;
            IconRestaurar.TabStop = false;
            IconRestaurar.Visible = false;
            IconRestaurar.Click += IconRestaurar_Click;
            // 
            // IconMaximizar
            // 
            IconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconMaximizar.Image = (Image)resources.GetObject("IconMaximizar.Image");
            IconMaximizar.Location = new Point(476, 13);
            IconMaximizar.Name = "IconMaximizar";
            IconMaximizar.Size = new Size(36, 25);
            IconMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            IconMaximizar.TabIndex = 2;
            IconMaximizar.TabStop = false;
            IconMaximizar.Click += pictureBox4_Click;
            // 
            // IconMinimizar
            // 
            IconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconMinimizar.Image = (Image)resources.GetObject("IconMinimizar.Image");
            IconMinimizar.Location = new Point(434, 13);
            IconMinimizar.Name = "IconMinimizar";
            IconMinimizar.Size = new Size(36, 25);
            IconMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            IconMinimizar.TabIndex = 1;
            IconMinimizar.TabStop = false;
            IconMinimizar.Click += IconMinimizar_Click;
            // 
            // IconFechar
            // 
            IconFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconFechar.Image = (Image)resources.GetObject("IconFechar.Image");
            IconFechar.Location = new Point(520, 14);
            IconFechar.Name = "IconFechar";
            IconFechar.Size = new Size(30, 24);
            IconFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            IconFechar.TabIndex = 0;
            IconFechar.TabStop = false;
            IconFechar.Click += IconFechar_Click;
            // 
            // PainelConteudo
            // 
            PainelConteudo.Dock = DockStyle.Fill;
            PainelConteudo.Location = new Point(235, 50);
            PainelConteudo.Name = "PainelConteudo";
            PainelConteudo.Size = new Size(565, 400);
            PainelConteudo.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PainelConteudo);
            Controls.Add(BarradeTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPrincipal";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarradeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconFechar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MenuVertical;
        private Panel BarradeTitulo;
        private PictureBox pictureBox1;
        private PictureBox IconMaximizar;
        private PictureBox IconMinimizar;
        private PictureBox IconFechar;
        private PictureBox IconRestaurar;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel PainelConteudo;
    }
}