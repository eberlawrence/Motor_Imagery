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
            this.BtSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountT = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pnTrigger = new System.Windows.Forms.FlowLayoutPanel();
            this.pbCross = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.TimerOne = new System.Windows.Forms.Timer(this.components);
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
            this.BtColeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColeta.Location = new System.Drawing.Point(49, 48);
            this.BtColeta.Name = "BtColeta";
            this.BtColeta.Size = new System.Drawing.Size(167, 77);
            this.BtColeta.TabIndex = 3;
            this.BtColeta.Text = "Iniciar Coleta";
            this.BtColeta.UseVisualStyleBackColor = true;
            this.BtColeta.Click += new System.EventHandler(this.BtColeta_Click);
            // 
            // pnTwo
            // 
            this.pnTwo.Controls.Add(this.BtSave);
            this.pnTwo.Controls.Add(this.label2);
            this.pnTwo.Controls.Add(this.label1);
            this.pnTwo.Controls.Add(this.lbCountT);
            this.pnTwo.Controls.Add(this.pbMain);
            this.pnTwo.Controls.Add(this.pnTrigger);
            this.pnTwo.Controls.Add(this.pbCross);
            this.pnTwo.Controls.Add(this.tbName);
            this.pnTwo.Controls.Add(this.BtColeta);
            this.pnTwo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTwo.Location = new System.Drawing.Point(341, 0);
            this.pnTwo.Name = "pnTwo";
            this.pnTwo.Size = new System.Drawing.Size(565, 450);
            this.pnTwo.TabIndex = 4;
            // 
            // BtSave
            // 
            this.BtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.Location = new System.Drawing.Point(49, 167);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(167, 35);
            this.BtSave.TabIndex = 12;
            this.BtSave.Text = "Salvar ordem";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "/ 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Repetição:";
            // 
            // lbCountT
            // 
            this.lbCountT.AutoSize = true;
            this.lbCountT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountT.Location = new System.Drawing.Point(153, 215);
            this.lbCountT.Name = "lbCountT";
            this.lbCountT.Size = new System.Drawing.Size(23, 25);
            this.lbCountT.TabIndex = 9;
            this.lbCountT.Text = "0";
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(178, 261);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(301, 120);
            this.pbMain.TabIndex = 5;
            this.pbMain.TabStop = false;
            // 
            // pnTrigger
            // 
            this.pnTrigger.BackColor = System.Drawing.Color.White;
            this.pnTrigger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnTrigger.Location = new System.Drawing.Point(7, 261);
            this.pnTrigger.Name = "pnTrigger";
            this.pnTrigger.Size = new System.Drawing.Size(150, 150);
            this.pnTrigger.TabIndex = 7;
            // 
            // pbCross
            // 
            this.pbCross.Location = new System.Drawing.Point(328, 48);
            this.pbCross.Name = "pbCross";
            this.pbCross.Size = new System.Drawing.Size(190, 190);
            this.pbCross.TabIndex = 6;
            this.pbCross.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(49, 131);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 30);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Voluntário";
            // 
            // TimerOne
            // 
            this.TimerOne.Interval = 1;
            this.TimerOne.Tick += new System.EventHandler(this.TimerOne_Tick);
            // 
            // FormMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 450);
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
        private System.Windows.Forms.FlowLayoutPanel pnTrigger;
        private System.Windows.Forms.Label lbCountT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSave;
    }
}

