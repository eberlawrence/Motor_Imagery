namespace Motor_Imagery_Protocol
{
    partial class FormMI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbStartMessage1 = new System.Windows.Forms.Label();
            this.pnOne = new System.Windows.Forms.Panel();
            this.BtAvancar = new System.Windows.Forms.Button();
            this.lbStartMessage2 = new System.Windows.Forms.Label();
            this.BtColeta = new System.Windows.Forms.Button();
            this.pnTwo = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
            this.pbCross = new System.Windows.Forms.PictureBox();
            this.pnOne.SuspendLayout();
            this.pnTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStartMessage1
            // 
            this.lbStartMessage1.AutoSize = true;
            this.lbStartMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartMessage1.Location = new System.Drawing.Point(55, 74);
            this.lbStartMessage1.Name = "lbStartMessage1";
            this.lbStartMessage1.Size = new System.Drawing.Size(0, 46);
            this.lbStartMessage1.TabIndex = 0;
            // 
            // pnOne
            // 
            this.pnOne.Controls.Add(this.BtAvancar);
            this.pnOne.Controls.Add(this.lbStartMessage2);
            this.pnOne.Controls.Add(this.lbStartMessage1);
            this.pnOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOne.Location = new System.Drawing.Point(0, 0);
            this.pnOne.Name = "pnOne";
            this.pnOne.Size = new System.Drawing.Size(335, 450);
            this.pnOne.TabIndex = 1;
            // 
            // BtAvancar
            // 
            this.BtAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAvancar.Location = new System.Drawing.Point(12, 123);
            this.BtAvancar.Name = "BtAvancar";
            this.BtAvancar.Size = new System.Drawing.Size(108, 48);
            this.BtAvancar.TabIndex = 2;
            this.BtAvancar.Text = "Avançar";
            this.BtAvancar.UseVisualStyleBackColor = true;
            this.BtAvancar.Click += new System.EventHandler(this.BtInicio_Click);
            // 
            // lbStartMessage2
            // 
            this.lbStartMessage2.AutoSize = true;
            this.lbStartMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartMessage2.Location = new System.Drawing.Point(94, 91);
            this.lbStartMessage2.Name = "lbStartMessage2";
            this.lbStartMessage2.Size = new System.Drawing.Size(0, 46);
            this.lbStartMessage2.TabIndex = 1;
            // 
            // BtColeta
            // 
            this.BtColeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColeta.Location = new System.Drawing.Point(48, 57);
            this.BtColeta.Name = "BtColeta";
            this.BtColeta.Size = new System.Drawing.Size(167, 35);
            this.BtColeta.TabIndex = 3;
            this.BtColeta.Text = "Iniciar Coleta";
            this.BtColeta.UseVisualStyleBackColor = true;
            this.BtColeta.Click += new System.EventHandler(this.BtColeta_Click);
            // 
            // pnTwo
            // 
            this.pnTwo.Controls.Add(this.pbCross);
            this.pnTwo.Controls.Add(this.pbMain);
            this.pnTwo.Controls.Add(this.tbName);
            this.pnTwo.Controls.Add(this.BtColeta);
            this.pnTwo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTwo.Location = new System.Drawing.Point(485, 0);
            this.pnTwo.Name = "pnTwo";
            this.pnTwo.Size = new System.Drawing.Size(315, 450);
            this.pnTwo.TabIndex = 4;
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(48, 126);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(301, 120);
            this.pbMain.TabIndex = 5;
            this.pbMain.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(48, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 20);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Voluntário";
            // 
            // TimerOne
            // 
            this.TimerOne.Interval = 1;
            this.TimerOne.Tick += new System.EventHandler(this.TimerOne_Tick);
            // 
            // pbCross
            // 
            this.pbCross.Location = new System.Drawing.Point(95, 280);
            this.pbCross.Name = "pbCross";
            this.pbCross.Size = new System.Drawing.Size(190, 190);
            this.pbCross.TabIndex = 6;
            this.pbCross.TabStop = false;
            // 
            // FormMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnTwo);
            this.Controls.Add(this.pnOne);
            this.Name = "FormMI";
            this.Text = "Motor Imagery Protocol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMI_Load);
            this.pnOne.ResumeLayout(false);
            this.pnOne.PerformLayout();
            this.pnTwo.ResumeLayout(false);
            this.pnTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStartMessage1;
        private System.Windows.Forms.Panel pnOne;
        private System.Windows.Forms.Label lbStartMessage2;
        private System.Windows.Forms.Button BtAvancar;
        private System.Windows.Forms.Button BtColeta;
        private System.Windows.Forms.Panel pnTwo;
        private System.Windows.Forms.Timer TimerOne;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.PictureBox pbCross;
    }
}

