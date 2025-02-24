namespace Lista_de_Exercicios_14_cs_WinForm
{
    partial class FormExercicio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExercicio01));
            BtnAcao = new Button();
            SuspendLayout();
            // 
            // BtnAcao
            // 
            BtnAcao.Anchor = AnchorStyles.Top;
            BtnAcao.AutoSize = true;
            BtnAcao.BackColor = SystemColors.ControlDarkDark;
            BtnAcao.BackgroundImageLayout = ImageLayout.Center;
            BtnAcao.Cursor = Cursors.Hand;
            BtnAcao.FlatStyle = FlatStyle.Flat;
            BtnAcao.Location = new Point(339, 272);
            BtnAcao.Name = "BtnAcao";
            BtnAcao.Size = new Size(249, 96);
            BtnAcao.TabIndex = 0;
            BtnAcao.Text = "entrar";
            BtnAcao.UseVisualStyleBackColor = false;
            BtnAcao.Click += BtnAcao_Click;
            // 
            // Exercicio01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(921, 612);
            Controls.Add(BtnAcao);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Exercicio01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senai";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAcao;
    }
}
