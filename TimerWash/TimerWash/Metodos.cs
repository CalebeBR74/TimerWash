using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerWash
{
	public class Metodos
	{
		public static int segundo = 10 + 1 ; //Manter um segundo a mais por questão do tempo de execução do método "TemporizadorInverso"
		public static int minuto = 0;
		public static int hora = 3;

		public string tempostring;

		public static string stringMinuto = string.Empty;
		public static string stringSegundo = string.Empty;
		public static string stringHora = string.Empty;

		public static void teste()
		{

		}

		public static string TemporizadorInverso()
		{
			if (segundo <= 59 && segundo > 0)
			{
				segundo = segundo - 1;
			}
			if (minuto > 0 && segundo == 0)
			{
				segundo = 59;
				minuto = minuto - 1;
			}
			if (hora > 0 && minuto == 0 && segundo == 0)
			{
				minuto = 59;
				hora = hora - 1;
			}

			if (hora < 10)
			{
				stringHora = "0" + hora.ToString();
			}
			else { stringHora = hora.ToString(); }

			if (minuto < 10)
			{
				stringMinuto = "0" + minuto.ToString();
			}
			else { stringMinuto = minuto.ToString(); }

			if (segundo < 10)
			{
				stringSegundo = "0" + segundo.ToString();
			}
			else { stringSegundo = segundo.ToString(); }

			var tempostring = stringHora + ":" + stringMinuto + ":" + stringSegundo;
			
			return tempostring;
		}

		public static void Chamar()
		{
			
		}
	}
}
