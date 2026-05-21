namespace impicat
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
            titolbl = new Label();
            btnCit = new Button();
            btnSer = new Button();
            btnCor = new Button();
            lblP = new Label();
            txtParolaIntera = new TextBox();
            btnPar = new Button();
            lblErr = new Label();
            lblMess = new Label();
            btnLett = new Button();
            txtLett = new TextBox();
            SuspendLayout();
            // 
            // titolbl
            // 
            titolbl.AutoSize = true;
            titolbl.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titolbl.Location = new Point(371, 12);
            titolbl.Name = "titolbl";
            titolbl.Size = new Size(357, 74);
            titolbl.TabIndex = 0;
            titolbl.Text = "IMPICCATO";
            // 
            // btnCit
            // 
            btnCit.Location = new Point(109, 185);
            btnCit.Margin = new Padding(3, 4, 3, 4);
            btnCit.Name = "btnCit";
            btnCit.Size = new Size(86, 31);
            btnCit.TabIndex = 28;
            btnCit.Text = "città";
            btnCit.UseVisualStyleBackColor = true;
            btnCit.Click += btnCit_Click;
            // 
            // btnSer
            // 
            btnSer.Location = new Point(109, 123);
            btnSer.Margin = new Padding(3, 4, 3, 4);
            btnSer.Name = "btnSer";
            btnSer.Size = new Size(86, 31);
            btnSer.TabIndex = 29;
            btnSer.Text = "serie tv";
            btnSer.UseVisualStyleBackColor = true;
            btnSer.Click += btnSer_Click;
            // 
            // btnCor
            // 
            btnCor.Location = new Point(109, 61);
            btnCor.Margin = new Padding(3, 4, 3, 4);
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(86, 31);
            btnCor.TabIndex = 33;
            btnCor.Text = "corpo";
            btnCor.UseVisualStyleBackColor = true;
            btnCor.Click += btnCor_Click;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP.Location = new Point(297, 233);
            lblP.Name = "lblP";
            lblP.Size = new Size(137, 37);
            lblP.TabIndex = 34;
            lblP.Text = "label1";
            // 
            // txtParolaIntera
            // 
            txtParolaIntera.Location = new Point(743, 491);
            txtParolaIntera.Margin = new Padding(3, 4, 3, 4);
            txtParolaIntera.Name = "txtParolaIntera";
            txtParolaIntera.Size = new Size(114, 27);
            txtParolaIntera.TabIndex = 37;
            // 
            // btnPar
            // 
            btnPar.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPar.Location = new Point(550, 440);
            btnPar.Margin = new Padding(3, 4, 3, 4);
            btnPar.Name = "btnPar";
            btnPar.Size = new Size(161, 116);
            btnPar.TabIndex = 38;
            btnPar.Text = "inserisci parola";
            btnPar.UseVisualStyleBackColor = true;

            // 
            // lblErr
            // 
            lblErr.AutoSize = true;
            lblErr.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErr.Location = new Point(33, 253);
            lblErr.Name = "lblErr";
            lblErr.Size = new Size(137, 37);
            lblErr.TabIndex = 39;
            lblErr.Text = "label1";
            // 
            // lblMess
            // 
            lblMess.AutoSize = true;
            lblMess.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMess.Location = new Point(33, 315);
            lblMess.Name = "lblMess";
            lblMess.Size = new Size(137, 37);
            lblMess.TabIndex = 40;
            lblMess.Text = "label1";
            // 
            // btnLett
            // 
            btnLett.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLett.Location = new Point(46, 440);
            btnLett.Margin = new Padding(3, 4, 3, 4);
            btnLett.Name = "btnLett";
            btnLett.Size = new Size(162, 116);
            btnLett.TabIndex = 41;
            btnLett.Text = "inserisci";
            btnLett.UseVisualStyleBackColor = true;

            // 
            // txtLett
            // 
            txtLett.Location = new Point(249, 491);
            txtLett.Margin = new Padding(3, 4, 3, 4);
            txtLett.Name = "txtLett";
            txtLett.Size = new Size(114, 27);
            txtLett.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtLett);
            Controls.Add(btnLett);
            Controls.Add(lblMess);
            Controls.Add(lblErr);
            Controls.Add(btnPar);
            Controls.Add(txtParolaIntera);
            Controls.Add(lblP);
            Controls.Add(btnCor);
            Controls.Add(btnSer);
            Controls.Add(btnCit);
            Controls.Add(titolbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titolbl;

        private Button btnCit;
        private Button btnSer;
        private Button btnCor;
        private Label lblP;
        private Button txtLettera;
       
        private TextBox txtParolaIntera;
        private Button btnPar;
        private Label lblErr;
        private Label lblMess;
        private Button btnLett;
        private TextBox txtLett;
    }
}
