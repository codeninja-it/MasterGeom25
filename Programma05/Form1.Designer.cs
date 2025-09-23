namespace Programma05
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
            lstNodi = new ListBox();
            btnAggiungi = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtX = new TextBox();
            txtY = new TextBox();
            SuspendLayout();
            // 
            // lstNodi
            // 
            lstNodi.FormattingEnabled = true;
            lstNodi.Location = new Point(12, 12);
            lstNodi.Name = "lstNodi";
            lstNodi.Size = new Size(337, 580);
            lstNodi.TabIndex = 0;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(562, 544);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(150, 46);
            btnAggiungi.TabIndex = 1;
            btnAggiungi.Text = "aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click_1;
            // 
            // txtId
            // 
            txtId.Location = new Point(512, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(512, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 39);
            txtNome.TabIndex = 3;
            // 
            // txtX
            // 
            txtX.Location = new Point(512, 102);
            txtX.Name = "txtX";
            txtX.Size = new Size(200, 39);
            txtX.TabIndex = 4;
            // 
            // txtY
            // 
            txtY.Location = new Point(512, 147);
            txtY.Name = "txtY";
            txtY.Size = new Size(200, 39);
            txtY.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 602);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnAggiungi);
            Controls.Add(lstNodi);
            Name = "Form1";
            Text = "Stradario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNodi;
        private Button btnAggiungi;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtX;
        private TextBox txtY;
    }
}
