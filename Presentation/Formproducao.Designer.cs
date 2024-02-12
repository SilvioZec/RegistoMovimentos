namespace RegistoMovimentos.Presentation
{
    partial class Formproducao
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
            txtNomeCliente = new TextBox();
            label1 = new Label();
            txtOutput = new TextBox();
            btnProcurar = new Button();
            SuspendLayout();
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNomeCliente.Location = new Point(321, 63);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(325, 47);
            txtNomeCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(254, 41);
            label1.TabIndex = 1;
            label1.Text = "Nome do cliente: ";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(62, 257);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(584, 47);
            txtOutput.TabIndex = 2;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(458, 147);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(188, 58);
            btnProcurar.TabIndex = 3;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // Formproducao
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 369);
            Controls.Add(btnProcurar);
            Controls.Add(txtOutput);
            Controls.Add(label1);
            Controls.Add(txtNomeCliente);
            Name = "Formproducao";
            Text = "Formproducao";
            Load += Formproducao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCliente;
        private Label label1;
        private TextBox txtOutput;
        private Button btnProcurar;
    }
}