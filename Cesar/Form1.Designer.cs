namespace Cesar
{
    partial class Form1
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
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.panCifrar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panCifrado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtDesplazamiento = new System.Windows.Forms.NumericUpDown();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panCifrar.SuspendLayout();
            this.panCifrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesplazamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlano
            // 
            this.txtPlano.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlano.Location = new System.Drawing.Point(6, 135);
            this.txtPlano.Multiline = true;
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(310, 293);
            this.txtPlano.TabIndex = 0;
            this.txtPlano.TextChanged += new System.EventHandler(this.txtPlano_TextChanged);
            this.txtPlano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlano_KeyPress);
            // 
            // panCifrar
            // 
            this.panCifrar.Controls.Add(this.label1);
            this.panCifrar.Controls.Add(this.txtPlano);
            this.panCifrar.Location = new System.Drawing.Point(4, 12);
            this.panCifrar.Name = "panCifrar";
            this.panCifrar.Size = new System.Drawing.Size(321, 433);
            this.panCifrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tù texto a cifrar";
            // 
            // panCifrado
            // 
            this.panCifrado.Controls.Add(this.label2);
            this.panCifrado.Controls.Add(this.txtCifrado);
            this.panCifrado.Location = new System.Drawing.Point(471, 12);
            this.panCifrado.Name = "panCifrado";
            this.panCifrado.Size = new System.Drawing.Size(321, 433);
            this.panCifrado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto cifrado";
            // 
            // txtCifrado
            // 
            this.txtCifrado.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCifrado.Location = new System.Drawing.Point(4, 140);
            this.txtCifrado.Multiline = true;
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(315, 293);
            this.txtCifrado.TabIndex = 0;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComenzar.Location = new System.Drawing.Point(350, 280);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(100, 38);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtDesplazamiento
            // 
            this.txtDesplazamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesplazamiento.Location = new System.Drawing.Point(338, 222);
            this.txtDesplazamiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDesplazamiento.Name = "txtDesplazamiento";
            this.txtDesplazamiento.Size = new System.Drawing.Size(119, 22);
            this.txtDesplazamiento.TabIndex = 4;
            this.txtDesplazamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesplazamiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(334, 167);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(135, 19);
            this.lblDes.TabIndex = 5;
            this.lblDes.Text = "Desplazamiento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(350, 351);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtDesplazamiento);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.panCifrado);
            this.Controls.Add(this.panCifrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panCifrar.ResumeLayout(false);
            this.panCifrar.PerformLayout();
            this.panCifrado.ResumeLayout(false);
            this.panCifrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesplazamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.Panel panCifrar;
        private System.Windows.Forms.Panel panCifrado;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.NumericUpDown txtDesplazamiento;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

