namespace Unicus.Acad.Apresentacao.WinForm2.Alunos
{
    partial class AlunoFormEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label label1;
            this.confirmarButton = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.turmaComboBox = new System.Windows.Forms.ComboBox();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(56, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(56, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "Nome:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(56, 85);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 17);
            sexoLabel.TabIndex = 7;
            sexoLabel.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 10;
            label1.Text = "Turma";
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(111, 208);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(94, 33);
            this.confirmarButton.TabIndex = 3;
            this.confirmarButton.Text = "&Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunoBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.idNumericUpDown.Location = new System.Drawing.Point(111, 26);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.idNumericUpDown.TabIndex = 4;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(Unicus.Acad.Dominio.Aluno);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeTextBox.Location = new System.Drawing.Point(111, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 22);
            this.nomeTextBox.TabIndex = 6;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(111, 82);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(121, 24);
            this.sexoComboBox.TabIndex = 8;
            // 
            // turmaComboBox
            // 
            this.turmaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Sexo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.turmaComboBox.DisplayMember = "Nome";
            this.turmaComboBox.FormattingEnabled = true;
            this.turmaComboBox.Location = new System.Drawing.Point(111, 112);
            this.turmaComboBox.Name = "turmaComboBox";
            this.turmaComboBox.Size = new System.Drawing.Size(121, 24);
            this.turmaComboBox.TabIndex = 9;
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataSource = typeof(Unicus.Acad.Dominio.Turmas.Turma);
            // 
            // AlunoFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 271);
            this.Controls.Add(label1);
            this.Controls.Add(this.turmaComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idNumericUpDown);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(this.confirmarButton);
            this.KeyPreview = true;
            this.Name = "AlunoFormEdit";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox turmaComboBox;
    }
}

