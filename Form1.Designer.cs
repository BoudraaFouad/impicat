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
            titolbl.Location = new Point(325, 9);
            titolbl.Name = "titolbl";
            titolbl.Size = new Size(295, 60);
            titolbl.TabIndex = 0;
            titolbl.Text = "IMPICCATO";
            // 
            // btnCit
            // 
            btnCit.Location = new Point(95, 139);
            btnCit.Name = "btnCit";
            btnCit.Size = new Size(75, 23);
            btnCit.TabIndex = 28;
            btnCit.Text = "città";
            btnCit.UseVisualStyleBackColor = true;
            btnCit.Click += btnCit_Click;
            // 
            // btnSer
            // 
            btnSer.Location = new Point(95, 92);
            btnSer.Name = "btnSer";
            btnSer.Size = new Size(75, 23);
            btnSer.TabIndex = 29;
            btnSer.Text = "serie tv";
            btnSer.UseVisualStyleBackColor = true;
            btnSer.Click += btnSer_Click;
            // 
            // btnCor
            // 
            btnCor.Location = new Point(95, 46);
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(75, 23);
            btnCor.TabIndex = 33;
            btnCor.Text = "corpo";
            btnCor.UseVisualStyleBackColor = true;
            btnCor.Click += btnCor_Click;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblP.Location = new Point(260, 175);
            lblP.Name = "lblP";
            lblP.Size = new Size(109, 30);
            lblP.TabIndex = 34;
            lblP.Text = "label1";
            // 
            // txtParolaIntera
            // 
            txtParolaIntera.Location = new Point(650, 368);
            txtParolaIntera.Name = "txtParolaIntera";
            txtParolaIntera.Size = new Size(100, 23);
            txtParolaIntera.TabIndex = 37;
            // 
            // btnPar
            // 
            btnPar.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPar.Location = new Point(481, 330);
            btnPar.Name = "btnPar";
            btnPar.Size = new Size(130, 87);
            btnPar.TabIndex = 38;
            btnPar.Text = "inserisci parola";
            btnPar.UseVisualStyleBackColor = true;
            btnPar.UseWaitCursor = true;
            // 
            // lblErr
            // 
            lblErr.AutoSize = true;
            lblErr.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErr.Location = new Point(29, 190);
            lblErr.Name = "lblErr";
            lblErr.Size = new Size(109, 30);
            lblErr.TabIndex = 39;
            lblErr.Text = "label1";
            // 
            // lblMess
            // 
            lblMess.AutoSize = true;
            lblMess.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMess.Location = new Point(29, 236);
            lblMess.Name = "lblMess";
            lblMess.Size = new Size(109, 30);
            lblMess.TabIndex = 40;
            lblMess.Text = "label1";
            // 
            // btnLett
            // 
            btnLett.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLett.Location = new Point(40, 330);
            btnLett.Name = "btnLett";
            btnLett.Size = new Size(130, 87);
            btnLett.TabIndex = 41;
            btnLett.Text = "inserisci";
            btnLett.UseVisualStyleBackColor = true;
            btnLett.UseWaitCursor = true;
            // 
            // txtLett
            // 
            txtLett.Location = new Point(218, 368);
            txtLett.Name = "txtLett";
            txtLett.Size = new Size(100, 23);
            txtLett.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
