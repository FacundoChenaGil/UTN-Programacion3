﻿namespace TP1
{
    partial class ExerciseFormThree
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
            this.gbxGenre = new System.Windows.Forms.GroupBox();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.btnReturnMenu3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.gbxGenre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGenre
            // 
            this.gbxGenre.Controls.Add(this.rbtnOther);
            this.gbxGenre.Controls.Add(this.rbtnFemale);
            this.gbxGenre.Controls.Add(this.rbtnMale);
            this.gbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGenre.Location = new System.Drawing.Point(62, 21);
            this.gbxGenre.Name = "gbxGenre";
            this.gbxGenre.Size = new System.Drawing.Size(145, 109);
            this.gbxGenre.TabIndex = 0;
            this.gbxGenre.TabStop = false;
            this.gbxGenre.Text = "Sexo";
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOther.Location = new System.Drawing.Point(21, 73);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(49, 17);
            this.rbtnOther.TabIndex = 3;
            this.rbtnOther.Text = "Otro";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Checked = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(21, 27);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(79, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Femenino";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(21, 50);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(82, 17);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.Text = "Masculino";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnReturnMenu3
            // 
            this.btnReturnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturnMenu3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu3.Location = new System.Drawing.Point(176, 398);
            this.btnReturnMenu3.Name = "btnReturnMenu3";
            this.btnReturnMenu3.Size = new System.Drawing.Size(156, 30);
            this.btnReturnMenu3.TabIndex = 1;
            this.btnReturnMenu3.Text = "Volver al Menu Principal";
            this.btnReturnMenu3.UseVisualStyleBackColor = true;
            this.btnReturnMenu3.Click += new System.EventHandler(this.btnReturnMenu3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSoltero);
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(277, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(21, 56);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(65, 17);
            this.rbSoltero.TabIndex = 1;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(21, 33);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(67, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Data Entry",
            "Operador PC",
            "Programador",
            "Reparador de Pc",
            "Tester"});
            this.checkedListBox1.Location = new System.Drawing.Point(164, 136);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(181, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeleccionado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionado.Location = new System.Drawing.Point(164, 245);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(181, 23);
            this.btnSeleccionado.TabIndex = 4;
            this.btnSeleccionado.Text = "Ver lo que se seleccionó";
            this.btnSeleccionado.UseVisualStyleBackColor = true;
            // 
            // ExerciseFormThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 440);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturnMenu3);
            this.Controls.Add(this.gbxGenre);
            this.MaximizeBox = false;
            this.Name = "ExerciseFormThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExerciseFormThree";
            this.gbxGenre.ResumeLayout(false);
            this.gbxGenre.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGenre;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.Button btnReturnMenu3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnSeleccionado;
    }
}