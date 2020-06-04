using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWash
{ 
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//Loop infinito
			if (Metodos.minuto == 0 && Metodos.hora == 0 && Metodos.segundo == 0)
			{
				notifyIcon1.ShowBalloonTip(10, "Sua maquina acabou!", "O programa indentificou através do timer\n" +
			" que sua maquina acabou de lavar todas as roupas!", ToolTipIcon.Info);
			}


			lblCronometro.Text = Metodos.TemporizadorInverso();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//Botão Despause || Iniciar
			
			btnIniciar.Visible = false;
			timer1.Start();
			btnPause.Visible = true;
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			//Botão pause
			
			timer1.Stop();
			btnIniciar.Visible = true;
			btnPause.Visible = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Implementação de notificação
			var contextMenu = new ContextMenu();
			notifyIcon1.ContextMenu = contextMenu;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			//função de resetar o temporizador
			Metodos.segundo = 10 + 1; //Manter um segundo a mais por questão do tempo de execução do método "TemporizadorInverso"
			Metodos.minuto = 0;
			Metodos.hora = 3;

			timer1.Stop();
			lblCronometro.Text = Metodos.TemporizadorInverso();

			btnPause.Visible = false;
			btnIniciar.Visible = true;

			
		}
	}
}
