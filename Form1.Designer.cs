namespace CografiBilgiSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnHarita = new System.Windows.Forms.Button();
            this.labelEnlem = new System.Windows.Forms.Label();
            this.textBoxEnlem = new System.Windows.Forms.TextBox();
            this.labelBoylam = new System.Windows.Forms.Label();
            this.textBoxBoylam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEnlem2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHarita2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBoylam2 = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxVarıs = new System.Windows.Forms.TextBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxKalkıs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(726, 623);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            // 
            // btnHarita
            // 
            this.btnHarita.Location = new System.Drawing.Point(838, 153);
            this.btnHarita.Name = "btnHarita";
            this.btnHarita.Size = new System.Drawing.Size(75, 43);
            this.btnHarita.TabIndex = 1;
            this.btnHarita.Text = "Haritada İşaretle";
            this.btnHarita.UseVisualStyleBackColor = true;
            this.btnHarita.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEnlem
            // 
            this.labelEnlem.AutoSize = true;
            this.labelEnlem.Location = new System.Drawing.Point(769, 62);
            this.labelEnlem.Name = "labelEnlem";
            this.labelEnlem.Size = new System.Drawing.Size(51, 16);
            this.labelEnlem.TabIndex = 2;
            this.labelEnlem.Text = "Enlem: ";
            // 
            // textBoxEnlem
            // 
            this.textBoxEnlem.Location = new System.Drawing.Point(838, 56);
            this.textBoxEnlem.Name = "textBoxEnlem";
            this.textBoxEnlem.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnlem.TabIndex = 3;
            // 
            // labelBoylam
            // 
            this.labelBoylam.AutoSize = true;
            this.labelBoylam.Location = new System.Drawing.Point(769, 97);
            this.labelBoylam.Name = "labelBoylam";
            this.labelBoylam.Size = new System.Drawing.Size(59, 16);
            this.labelBoylam.TabIndex = 4;
            this.labelBoylam.Text = "Boylam: ";
            // 
            // textBoxBoylam
            // 
            this.textBoxBoylam.Location = new System.Drawing.Point(838, 97);
            this.textBoxBoylam.Name = "textBoxBoylam";
            this.textBoxBoylam.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoylam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(769, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Ondalık kısımları virgül ile ayırınız.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(769, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "(Ondalık kısımları virgül ile ayırınız.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Boylam: ";
            // 
            // textBoxEnlem2
            // 
            this.textBoxEnlem2.Location = new System.Drawing.Point(838, 256);
            this.textBoxEnlem2.Name = "textBoxEnlem2";
            this.textBoxEnlem2.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnlem2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enlem: ";
            // 
            // btnHarita2
            // 
            this.btnHarita2.Location = new System.Drawing.Point(838, 353);
            this.btnHarita2.Name = "btnHarita2";
            this.btnHarita2.Size = new System.Drawing.Size(75, 43);
            this.btnHarita2.TabIndex = 7;
            this.btnHarita2.Text = "Haritada İşaretle";
            this.btnHarita2.UseVisualStyleBackColor = true;
            this.btnHarita2.Click += new System.EventHandler(this.btnHarita2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Marker 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marker 2";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(789, 429);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(163, 43);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listedeki Araçları Haritada İşaretle";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Seçilen Araç Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Plaka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Varış";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(786, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Kalkış";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Araç Tipi";
            // 
            // textBoxBoylam2
            // 
            this.textBoxBoylam2.Location = new System.Drawing.Point(838, 297);
            this.textBoxBoylam2.Name = "textBoxBoylam2";
            this.textBoxBoylam2.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoylam2.TabIndex = 11;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Enabled = false;
            this.textBoxTip.Location = new System.Drawing.Point(867, 552);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(100, 22);
            this.textBoxTip.TabIndex = 21;
            // 
            // textBoxVarıs
            // 
            this.textBoxVarıs.Enabled = false;
            this.textBoxVarıs.Location = new System.Drawing.Point(867, 608);
            this.textBoxVarıs.Name = "textBoxVarıs";
            this.textBoxVarıs.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarıs.TabIndex = 22;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Enabled = false;
            this.textBoxPlaka.Location = new System.Drawing.Point(867, 524);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlaka.TabIndex = 23;
            // 
            // textBoxKalkıs
            // 
            this.textBoxKalkıs.Enabled = false;
            this.textBoxKalkıs.Location = new System.Drawing.Point(867, 580);
            this.textBoxKalkıs.Name = "textBoxKalkıs";
            this.textBoxKalkıs.Size = new System.Drawing.Size(100, 22);
            this.textBoxKalkıs.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 647);
            this.Controls.Add(this.textBoxKalkıs);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.textBoxVarıs);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBoylam2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEnlem2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHarita2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBoylam);
            this.Controls.Add(this.labelBoylam);
            this.Controls.Add(this.textBoxEnlem);
            this.Controls.Add(this.labelEnlem);
            this.Controls.Add(this.btnHarita);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnHarita;
        private System.Windows.Forms.Label labelEnlem;
        private System.Windows.Forms.TextBox textBoxEnlem;
        private System.Windows.Forms.Label labelBoylam;
        private System.Windows.Forms.TextBox textBoxBoylam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEnlem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHarita2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBoylam2;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxVarıs;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxKalkıs;
    }
}

