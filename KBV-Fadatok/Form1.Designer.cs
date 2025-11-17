namespace KBV_Fadatok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNeve = new System.Windows.Forms.Label();
            this.lblFovaros = new System.Windows.Forms.Label();
            this.lblTerulet = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAu = new System.Windows.Forms.Button();
            this.btnFr = new System.Windows.Forms.Button();
            this.btnBri = new System.Windows.Forms.Button();
            this.btnHu = new System.Windows.Forms.Button();
            this.btnUsa = new System.Windows.Forms.Button();
            this.lblNepesseg = new System.Windows.Forms.Label();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.lblNev2 = new System.Windows.Forms.Label();
            this.lblFovaros2 = new System.Windows.Forms.Label();
            this.lblTerulet2 = new System.Windows.Forms.Label();
            this.lblNepesseg2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNeve
            // 
            this.lblNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeve.Location = new System.Drawing.Point(27, 191);
            this.lblNeve.Name = "lblNeve";
            this.lblNeve.Size = new System.Drawing.Size(124, 22);
            this.lblNeve.TabIndex = 2;
            this.lblNeve.Text = "Az ország neve:";
            // 
            // lblFovaros
            // 
            this.lblFovaros.AutoSize = true;
            this.lblFovaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFovaros.Location = new System.Drawing.Point(27, 230);
            this.lblFovaros.Name = "lblFovaros";
            this.lblFovaros.Size = new System.Drawing.Size(75, 18);
            this.lblFovaros.TabIndex = 3;
            this.lblFovaros.Text = "Fővárosa:";
            // 
            // lblTerulet
            // 
            this.lblTerulet.AutoSize = true;
            this.lblTerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTerulet.Location = new System.Drawing.Point(27, 268);
            this.lblTerulet.Name = "lblTerulet";
            this.lblTerulet.Size = new System.Drawing.Size(65, 18);
            this.lblTerulet.TabIndex = 4;
            this.lblTerulet.Text = "Területe:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAu);
            this.flowLayoutPanel1.Controls.Add(this.btnFr);
            this.flowLayoutPanel1.Controls.Add(this.btnBri);
            this.flowLayoutPanel1.Controls.Add(this.btnHu);
            this.flowLayoutPanel1.Controls.Add(this.btnUsa);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(938, 144);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnAu
            // 
            this.btnAu.Image = ((System.Drawing.Image)(resources.GetObject("btnAu.Image")));
            this.btnAu.Location = new System.Drawing.Point(3, 3);
            this.btnAu.Name = "btnAu";
            this.btnAu.Size = new System.Drawing.Size(180, 120);
            this.btnAu.TabIndex = 0;
            this.btnAu.Tag = "btnAu";
            this.btnAu.Text = "Ausztria";
            this.btnAu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAu.UseVisualStyleBackColor = true;
            // 
            // btnFr
            // 
            this.btnFr.Image = ((System.Drawing.Image)(resources.GetObject("btnFr.Image")));
            this.btnFr.Location = new System.Drawing.Point(189, 3);
            this.btnFr.Name = "btnFr";
            this.btnFr.Size = new System.Drawing.Size(180, 120);
            this.btnFr.TabIndex = 1;
            this.btnFr.Tag = "btnFr";
            this.btnFr.Text = "Franciaország";
            this.btnFr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFr.UseVisualStyleBackColor = true;
            // 
            // btnBri
            // 
            this.btnBri.Image = ((System.Drawing.Image)(resources.GetObject("btnBri.Image")));
            this.btnBri.Location = new System.Drawing.Point(375, 3);
            this.btnBri.Name = "btnBri";
            this.btnBri.Size = new System.Drawing.Size(180, 120);
            this.btnBri.TabIndex = 2;
            this.btnBri.Tag = "btnBri";
            this.btnBri.Text = "Nagy-Britannia";
            this.btnBri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBri.UseVisualStyleBackColor = true;
            // 
            // btnHu
            // 
            this.btnHu.Image = ((System.Drawing.Image)(resources.GetObject("btnHu.Image")));
            this.btnHu.Location = new System.Drawing.Point(561, 3);
            this.btnHu.Name = "btnHu";
            this.btnHu.Size = new System.Drawing.Size(180, 120);
            this.btnHu.TabIndex = 3;
            this.btnHu.Tag = "btnHu";
            this.btnHu.Text = "Magyarország";
            this.btnHu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHu.UseVisualStyleBackColor = true;
            // 
            // btnUsa
            // 
            this.btnUsa.Image = ((System.Drawing.Image)(resources.GetObject("btnUsa.Image")));
            this.btnUsa.Location = new System.Drawing.Point(747, 3);
            this.btnUsa.Name = "btnUsa";
            this.btnUsa.Size = new System.Drawing.Size(180, 120);
            this.btnUsa.TabIndex = 4;
            this.btnUsa.Tag = "btnUsa";
            this.btnUsa.Text = "USA";
            this.btnUsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsa.UseVisualStyleBackColor = true;
            // 
            // lblNepesseg
            // 
            this.lblNepesseg.AutoSize = true;
            this.lblNepesseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNepesseg.Location = new System.Drawing.Point(27, 307);
            this.lblNepesseg.Name = "lblNepesseg";
            this.lblNepesseg.Size = new System.Drawing.Size(87, 18);
            this.lblNepesseg.TabIndex = 6;
            this.lblNepesseg.Text = "Népessége:";
            // 
            // btnKilepes
            // 
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(704, 338);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(236, 50);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "KILÉPÉS";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // lblNev2
            // 
            this.lblNev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev2.Location = new System.Drawing.Point(188, 191);
            this.lblNev2.Name = "lblNev2";
            this.lblNev2.Size = new System.Drawing.Size(150, 23);
            this.lblNev2.TabIndex = 8;
            // 
            // lblFovaros2
            // 
            this.lblFovaros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFovaros2.Location = new System.Drawing.Point(188, 230);
            this.lblFovaros2.Name = "lblFovaros2";
            this.lblFovaros2.Size = new System.Drawing.Size(150, 23);
            this.lblFovaros2.TabIndex = 12;
            // 
            // lblTerulet2
            // 
            this.lblTerulet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTerulet2.Location = new System.Drawing.Point(188, 268);
            this.lblTerulet2.Name = "lblTerulet2";
            this.lblTerulet2.Size = new System.Drawing.Size(150, 23);
            this.lblTerulet2.TabIndex = 10;
            // 
            // lblNepesseg2
            // 
            this.lblNepesseg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNepesseg2.Location = new System.Drawing.Point(188, 307);
            this.lblNepesseg2.Name = "lblNepesseg2";
            this.lblNepesseg2.Size = new System.Drawing.Size(150, 23);
            this.lblNepesseg2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Földrajzi adatok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNepesseg2);
            this.Controls.Add(this.lblTerulet2);
            this.Controls.Add(this.lblFovaros2);
            this.Controls.Add(this.lblNev2);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.lblNepesseg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTerulet);
            this.Controls.Add(this.lblFovaros);
            this.Controls.Add(this.lblNeve);
            this.Name = "Form1";
            this.Text = "Országok adatai";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNeve;
        private System.Windows.Forms.Label lblFovaros;
        private System.Windows.Forms.Label lblTerulet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAu;
        private System.Windows.Forms.Button btnFr;
        private System.Windows.Forms.Button btnBri;
        private System.Windows.Forms.Button btnHu;
        private System.Windows.Forms.Button btnUsa;
        private System.Windows.Forms.Label lblNepesseg;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label lblNev2;
        private System.Windows.Forms.Label lblFovaros2;
        private System.Windows.Forms.Label lblTerulet2;
        private System.Windows.Forms.Label lblNepesseg2;
        private System.Windows.Forms.Label label1;
    }
}

