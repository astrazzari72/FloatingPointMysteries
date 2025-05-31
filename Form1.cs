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

		static void PrintBinaryRepresentation(double number)
		{
			byte[] bytes = BitConverter.GetBytes(number);
			Array.Reverse(bytes); // Per big-endian

			foreach (byte b in bytes)
			{
				Console.Write(Convert.ToString(b, 2).PadLeft(8, '0'));
			}
			Console.WriteLine();
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
			float value = float.Parse(ConversionErrors_Value_textBox.Text);  //0.6

			CE_Res_tb.Text = string.Empty; // Pulisce il TextBox prima di mostrare i risultati
			CE_Res_tb.AppendText("--------------FLOAT -------------" + Environment.NewLine);
			floatTest(value);
			CE_Res_tb.AppendText("--------------DOUBLE-------------" + Environment.NewLine);
			doubleTest(value);
		}
		private void floatTest(float value)
		{
			float result = value * 2;

			string strRes;
			// Usa la cultura "invariant" per usare il punto come separatore
			strRes = $"Valore originale: {value.ToString("G10", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Risultato di value * 2: {result.ToString("G10", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);

			// Mostra la rappresentazione binaria
			strRes = $"Rappresentazione binaria di value: {GetBinaryRepresentation(value)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Rappresentazione binaria di value * 2: {GetBinaryRepresentation(result)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
		}
		private void doubleTest(double value)
		{
			double result = value * 2;

			string strRes;
			// Usa la cultura "invariant" per usare il punto come separatore
			strRes = $"Valore originale: {value.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Risultato di value * 2: {result.ToString("G20", CultureInfo.InvariantCulture)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);

			// Mostra la rappresentazione binaria
			strRes = $"Rappresentazione binaria di value: {GetBinaryRepresentation(value)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
			strRes = $"Rappresentazione binaria di value * 2: {GetBinaryRepresentation(result)}";
			Console.WriteLine(strRes);
			CE_Res_tb.AppendText(strRes + Environment.NewLine);
		}
	}
}
