using System.Globalization;
using System.Text;

namespace FloatingPointMysteries
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		static string GetBinaryRepresentation(double number)
		{
			byte[] bytes = BitConverter.GetBytes(number);
			Array.Reverse(bytes); // Per big-endian

			StringBuilder binary = new StringBuilder();

			foreach (byte b in bytes)
			{
				binary.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
			}

			return binary.ToString();
		}

		private void ConversionErrors_button1_Click(object sender, EventArgs e)
		{
			CE_Res_tb.Text = string.Empty; // Pulisce il TextBox prima di mostrare i risultati
			float valueF = float.Parse(ConversionErrors_Value_textBox.Text);  //0.6
			CE_Res_tb.AppendText("--------------FLOAT -------------" + Environment.NewLine);
			floatTest(valueF);

			double valueD = double.Parse(ConversionErrors_Value_textBox.Text);  //0.6
			CE_Res_tb.AppendText("--------------DOUBLE-------------" + Environment.NewLine);
			doubleTest(valueD);
		}
		private void floatTest(float value)
		{
			float result = value * 2;

			string strRes;
			// Usa la cultura "invariant" per usare il punto come separatore
			strRes = $"Valore originale {value}: {value.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Valore originale {result}: {result.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);

			// Mostra la rappresentazione binaria
			strRes = $"Rapp. binaria di {value}: {GetBinaryRepresentation(value)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Rapp. binaria di {result}: {GetBinaryRepresentation(result)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
		}
		private void doubleTest(double value)
		{
			double result = value * 2;

			string strRes;
			// Usa la cultura "invariant" per usare il punto come separatore
			strRes = $"Valore originale {value}: {value.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Valore originale {result}: {result.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);

			// Mostra la rappresentazione binaria
			strRes = $"Rapp. binaria di {value}: {GetBinaryRepresentation(value)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Rapp. binaria di {result}: {GetBinaryRepresentation(result)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
		}
	}
}
