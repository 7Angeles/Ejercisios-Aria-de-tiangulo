﻿
namespace Ejercisios.Formulario
{
    partial class AreaTiangulo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoBase = new System.Windows.Forms.TextBox();
            this.textoAltura = new System.Windows.Forms.TextBox();
            this.textoResultado = new System.Windows.Forms.TextBox();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // textoBase
            // 
            this.textoBase.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBase.Location = new System.Drawing.Point(177, 50);
            this.textoBase.Multiline = true;
            this.textoBase.Name = "textoBase";
            this.textoBase.Size = new System.Drawing.Size(100, 39);
            this.textoBase.TabIndex = 7;
            this.textoBase.Text = "0";
            // 
            // textoAltura
            // 
            this.textoAltura.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAltura.Location = new System.Drawing.Point(177, 135);
            this.textoAltura.Multiline = true;
            this.textoAltura.Name = "textoAltura";
            this.textoAltura.Size = new System.Drawing.Size(100, 39);
            this.textoAltura.TabIndex = 8;
            this.textoAltura.Text = "0";
            // 
            // textoResultado
            // 
            this.textoResultado.BackColor = System.Drawing.Color.White;
            this.textoResultado.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoResultado.Location = new System.Drawing.Point(194, 227);
            this.textoResultado.Multiline = true;
            this.textoResultado.Name = "textoResultado";
            this.textoResultado.Size = new System.Drawing.Size(100, 39);
            this.textoResultado.TabIndex = 9;
            // 
            // buttonResultado
            // 
            this.buttonResultado.BackColor = System.Drawing.Color.Thistle;
            this.buttonResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResultado.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(386, 240);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(123, 41);
            this.buttonResultado.TabIndex = 10;
            this.buttonResultado.Text = "Calcular";
            this.buttonResultado.UseVisualStyleBackColor = false;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // AreaTiangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(521, 304);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.textoResultado);
            this.Controls.Add(this.textoAltura);
            this.Controls.Add(this.textoBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AreaTiangulo";
            this.Text = "AreaTiangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoBase;
        private System.Windows.Forms.TextBox textoAltura;
        private System.Windows.Forms.TextBox textoResultado;
        private System.Windows.Forms.Button buttonResultado;
    }
}