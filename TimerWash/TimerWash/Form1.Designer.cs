namespace TimerWash
{
	public partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblCronometro = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnPause = new System.Windows.Forms.Button();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCronometro
			// 
			this.lblCronometro.AutoSize = true;
			this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCronometro.Location = new System.Drawing.Point(27, 57);
			this.lblCronometro.Name = "lblCronometro";
			this.lblCronometro.Size = new System.Drawing.Size(284, 73);
			this.lblCronometro.TabIndex = 1;
			this.lblCronometro.Text = "00:00:00";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.SystemColors.Control;
			this.btnPause.BackgroundImage = global::TimerWash.Properties.Resources.BtnPause;
			this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPause.Location = new System.Drawing.Point(127, 357);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(82, 81);
			this.btnPause.TabIndex = 0;
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnIniciar
			// 
			this.btnIniciar.BackColor = System.Drawing.SystemColors.Control;
			this.btnIniciar.BackgroundImage = global::TimerWash.Properties.Resources.PlayButton;
			this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnIniciar.Location = new System.Drawing.Point(127, 357);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(82, 81);
			this.btnIniciar.TabIndex = 0;
			this.btnIniciar.UseVisualStyleBackColor = false;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "TimerWash";
			this.notifyIcon1.Visible = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(339, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblCronometro);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnIniciar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "TimerWash";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Label lblCronometro;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}

