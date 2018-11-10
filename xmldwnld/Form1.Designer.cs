namespace xmldwnld
{
    partial class xmldwnld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xmldwnld));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDescargaXML = new System.Windows.Forms.Button();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnIrSat = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.imgConfig = new System.Windows.Forms.PictureBox();
            this.imgIrSat = new System.Windows.Forms.PictureBox();
            this.imgDescargar = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIrSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescargar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1154F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.contentLayout, 1, 1);
            this.mainLayout.Controls.Add(this.headerLayout, 0, 0);
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.mainLayout.Size = new System.Drawing.Size(1154, 476);
            this.mainLayout.TabIndex = 1;
            // 
            // contentLayout
            // 
            this.contentLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentLayout.ColumnCount = 2;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.contentLayout.Controls.Add(this.pbDownload, 1, 1);
            this.contentLayout.Controls.Add(this.webBrowser1, 1, 2);
            this.contentLayout.Controls.Add(this.menuLayout, 0, 1);
            this.contentLayout.Location = new System.Drawing.Point(0, 23);
            this.contentLayout.Margin = new System.Windows.Forms.Padding(0);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowCount = 1;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.contentLayout.Size = new System.Drawing.Size(1154, 453);
            this.contentLayout.TabIndex = 0;
            // 
            // pbDownload
            // 
            this.pbDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDownload.ForeColor = System.Drawing.Color.Lime;
            this.pbDownload.Location = new System.Drawing.Point(176, 3);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(975, 14);
            this.pbDownload.TabIndex = 1;
            this.pbDownload.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(176, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.contentLayout.SetRowSpan(this.webBrowser1, 2);
            this.webBrowser1.Size = new System.Drawing.Size(975, 361);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://portalcfdi.facturaelectronica.sat.gob.mx", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuLayout
            // 
            this.menuLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLayout.ColumnCount = 1;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.menuLayout.Location = new System.Drawing.Point(0, 0);
            this.menuLayout.Margin = new System.Windows.Forms.Padding(0);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.RowCount = 1;
            this.contentLayout.SetRowSpan(this.menuLayout, 4);
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.Size = new System.Drawing.Size(173, 453);
            this.menuLayout.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.imgConfig, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgIrSat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDescargaXML, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIrSat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfig, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgDescargar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDescargaXML
            // 
            this.btnDescargaXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargaXML.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargaXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDescargaXML.FlatAppearance.BorderSize = 0;
            this.btnDescargaXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDescargaXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDescargaXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargaXML.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargaXML.ForeColor = System.Drawing.Color.White;
            this.btnDescargaXML.Location = new System.Drawing.Point(25, 0);
            this.btnDescargaXML.Margin = new System.Windows.Forms.Padding(0);
            this.btnDescargaXML.Name = "btnDescargaXML";
            this.btnDescargaXML.Size = new System.Drawing.Size(148, 50);
            this.btnDescargaXML.TabIndex = 1;
            this.btnDescargaXML.TabStop = false;
            this.btnDescargaXML.Text = "Descargar XML";
            this.btnDescargaXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargaXML.UseVisualStyleBackColor = false;
            this.btnDescargaXML.Click += new System.EventHandler(this.btnDescargaXML_Click);
            // 
            // headerLayout
            // 
            this.headerLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.headerLayout.ColumnCount = 5;
            this.mainLayout.SetColumnSpan(this.headerLayout, 3);
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.headerLayout.Controls.Add(this.btnSalir, 4, 0);
            this.headerLayout.Controls.Add(this.lblTitle, 0, 0);
            this.headerLayout.Location = new System.Drawing.Point(0, 0);
            this.headerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 2;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayout.Size = new System.Drawing.Size(1154, 23);
            this.headerLayout.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1084, 3);
            this.btnSalir.Name = "btnSalir";
            this.headerLayout.SetRowSpan(this.btnSalir, 2);
            this.btnSalir.Size = new System.Drawing.Size(67, 17);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(571, 11);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "V 0.0.01";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIrSat
            // 
            this.btnIrSat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrSat.BackColor = System.Drawing.Color.Transparent;
            this.btnIrSat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIrSat.FlatAppearance.BorderSize = 0;
            this.btnIrSat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIrSat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIrSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrSat.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrSat.ForeColor = System.Drawing.Color.White;
            this.btnIrSat.Location = new System.Drawing.Point(25, 50);
            this.btnIrSat.Margin = new System.Windows.Forms.Padding(0);
            this.btnIrSat.Name = "btnIrSat";
            this.btnIrSat.Size = new System.Drawing.Size(148, 50);
            this.btnIrSat.TabIndex = 2;
            this.btnIrSat.TabStop = false;
            this.btnIrSat.Text = "Ir al SAT";
            this.btnIrSat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrSat.UseVisualStyleBackColor = false;
            this.btnIrSat.Click += new System.EventHandler(this.btnIrSat_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(25, 100);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(148, 50);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.TabStop = false;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // imgConfig
            // 
            this.imgConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgConfig.Image = global::xmldwnld.Properties.Resources.tools;
            this.imgConfig.Location = new System.Drawing.Point(3, 103);
            this.imgConfig.Name = "imgConfig";
            this.imgConfig.Size = new System.Drawing.Size(19, 44);
            this.imgConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfig.TabIndex = 6;
            this.imgConfig.TabStop = false;
            this.imgConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // imgIrSat
            // 
            this.imgIrSat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgIrSat.Image = global::xmldwnld.Properties.Resources.go_to_web;
            this.imgIrSat.Location = new System.Drawing.Point(3, 53);
            this.imgIrSat.Name = "imgIrSat";
            this.imgIrSat.Size = new System.Drawing.Size(19, 44);
            this.imgIrSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIrSat.TabIndex = 5;
            this.imgIrSat.TabStop = false;
            this.imgIrSat.Click += new System.EventHandler(this.btnIrSat_Click);
            // 
            // imgDescargar
            // 
            this.imgDescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgDescargar.Image = global::xmldwnld.Properties.Resources.download__1_;
            this.imgDescargar.Location = new System.Drawing.Point(3, 3);
            this.imgDescargar.Name = "imgDescargar";
            this.imgDescargar.Size = new System.Drawing.Size(19, 44);
            this.imgDescargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDescargar.TabIndex = 4;
            this.imgDescargar.TabStop = false;
            this.imgDescargar.Click += new System.EventHandler(this.btnDescargaXML_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Location = new System.Drawing.Point(28, 150);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(142, 303);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // xmldwnld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1154, 475);
            this.ControlBox = false;
            this.Controls.Add(this.mainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xmldwnld";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xmldwnld";
            this.Load += new System.EventHandler(this.xmldwnld_Load);
            this.mainLayout.ResumeLayout(false);
            this.contentLayout.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIrSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescargar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel contentLayout;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnDescargaXML;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel menuLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnIrSat;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.PictureBox imgDescargar;
        private System.Windows.Forms.PictureBox imgIrSat;
        private System.Windows.Forms.PictureBox imgConfig;
        private System.Windows.Forms.Label lblVersion;
    }
}

