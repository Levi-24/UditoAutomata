namespace Udito
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
            this.btnToltes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbAtmero = new System.Windows.Forms.TextBox();
            this.txbSebesseg = new System.Windows.Forms.TextBox();
            this.txbIdo = new System.Windows.Forms.TextBox();
            this.txbKitoltott = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToltes
            // 
            this.btnToltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToltes.Location = new System.Drawing.Point(491, 257);
            this.btnToltes.Name = "btnToltes";
            this.btnToltes.Size = new System.Drawing.Size(297, 105);
            this.btnToltes.TabIndex = 0;
            this.btnToltes.Text = "Töltés";
            this.btnToltes.UseVisualStyleBackColor = true;
            this.btnToltes.Click += new System.EventHandler(this.btnToltes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Udito.Properties.Resources.istockphoto_1428260936_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txbAtmero
            // 
            this.txbAtmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbAtmero.Location = new System.Drawing.Point(507, 56);
            this.txbAtmero.Name = "txbAtmero";
            this.txbAtmero.Size = new System.Drawing.Size(118, 26);
            this.txbAtmero.TabIndex = 2;
            // 
            // txbSebesseg
            // 
            this.txbSebesseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbSebesseg.Location = new System.Drawing.Point(507, 139);
            this.txbSebesseg.Name = "txbSebesseg";
            this.txbSebesseg.Size = new System.Drawing.Size(118, 26);
            this.txbSebesseg.TabIndex = 3;
            // 
            // txbIdo
            // 
            this.txbIdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbIdo.Location = new System.Drawing.Point(507, 213);
            this.txbIdo.Name = "txbIdo";
            this.txbIdo.Size = new System.Drawing.Size(118, 26);
            this.txbIdo.TabIndex = 4;
            // 
            // txbKitoltott
            // 
            this.txbKitoltott.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbKitoltott.Location = new System.Drawing.Point(491, 412);
            this.txbKitoltott.Name = "txbKitoltott";
            this.txbKitoltott.Size = new System.Drawing.Size(297, 26);
            this.txbKitoltott.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(502, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cső átmérője";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(507, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Áramlás sebessége";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(507, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kitöltés ideje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(491, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kitöltött mennyiség:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKitoltott);
            this.Controls.Add(this.txbIdo);
            this.Controls.Add(this.txbSebesseg);
            this.Controls.Add(this.txbAtmero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToltes);
            this.Name = "Form1";
            this.Text = "Üditő";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToltes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbAtmero;
        private System.Windows.Forms.TextBox txbSebesseg;
        private System.Windows.Forms.TextBox txbIdo;
        private System.Windows.Forms.TextBox txbKitoltott;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

