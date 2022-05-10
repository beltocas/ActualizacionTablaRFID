namespace ActualizarTabla
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
            this.components = new System.ComponentModel.Container();
            this.tabla_1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANTENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_1
            // 
            this.tabla_1.AllowUserToAddRows = false;
            this.tabla_1.AllowUserToDeleteRows = false;
            this.tabla_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATERIAL,
            this.DESC_MATERIAL,
            this.EPC_ID,
            this.TAG_COUNT,
            this.ANTENA,
            this.HORA_REGISTRO});
            this.tabla_1.Location = new System.Drawing.Point(16, 15);
            this.tabla_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabla_1.Name = "tabla_1";
            this.tabla_1.ReadOnly = true;
            this.tabla_1.RowHeadersWidth = 51;
            this.tabla_1.Size = new System.Drawing.Size(908, 544);
            this.tabla_1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.MinimumWidth = 6;
            this.MATERIAL.Name = "MATERIAL";
            this.MATERIAL.ReadOnly = true;
            // 
            // DESC_MATERIAL
            // 
            this.DESC_MATERIAL.HeaderText = "DESC_MATERIAL";
            this.DESC_MATERIAL.MinimumWidth = 6;
            this.DESC_MATERIAL.Name = "DESC_MATERIAL";
            this.DESC_MATERIAL.ReadOnly = true;
            // 
            // EPC_ID
            // 
            this.EPC_ID.HeaderText = "EPC_ID";
            this.EPC_ID.MinimumWidth = 6;
            this.EPC_ID.Name = "EPC_ID";
            this.EPC_ID.ReadOnly = true;
            // 
            // TAG_COUNT
            // 
            this.TAG_COUNT.HeaderText = "TAG_COUNT";
            this.TAG_COUNT.MinimumWidth = 6;
            this.TAG_COUNT.Name = "TAG_COUNT";
            this.TAG_COUNT.ReadOnly = true;
            // 
            // ANTENA
            // 
            this.ANTENA.HeaderText = "ANTENA";
            this.ANTENA.MinimumWidth = 6;
            this.ANTENA.Name = "ANTENA";
            this.ANTENA.ReadOnly = true;
            // 
            // HORA_REGISTRO
            // 
            this.HORA_REGISTRO.HeaderText = "HORA_REGISTRO";
            this.HORA_REGISTRO.MinimumWidth = 6;
            this.HORA_REGISTRO.Name = "HORA_REGISTRO";
            this.HORA_REGISTRO.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 572);
            this.Controls.Add(this.tabla_1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabla_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_MATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANTENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_REGISTRO;
    }
}

