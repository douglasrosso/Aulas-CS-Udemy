using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18__Aprofundando_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18- Aprofundando DateTime

            DateTime data = new DateTime(2020, 09, 26);
            DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 45);

            // Podemos acessar ano, mês, dia, hora, minuto, segundo individualmente
            Console.WriteLine($"Ano: {dataHora.Year}");
            Console.WriteLine($"mês: {dataHora.Month}");
            Console.WriteLine($"Dia: {dataHora.Day}");
            Console.WriteLine($"Hora: {dataHora.Hour}");
            Console.WriteLine($"Minutos: {dataHora.Minute}");
            Console.WriteLine($"Segundos: {dataHora.Second}");
            Console.WriteLine($"Dia da Semana: {dataHora.DayOfWeek}");
            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());


            // Pegando a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());
            Console.WriteLine("\n---------------------------------------------------------------------------\n");


            // Converter String em DateTime
            DateTime dataConvertida = Convert.ToDateTime("22/11/2030");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2030 14:10:23");
            Console.WriteLine(dataConvertida.ToString());
            Console.WriteLine(dataHoraConvertida.ToString());


            // Formatar data e hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM")); // Ano/Mês
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/dd")); // Ano/Mês/dia
            Console.WriteLine(dataHoraConvertida.ToString("yyyy-MM-dd")); // Ano-Mês-dia
            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss")); // Hora:Minutos:Segundos

            Console.WriteLine("\n---------------------------------------------------------------------------\n");


            // Operações com DateTime
            DateTime dataHora2 = new DateTime(2020, 09, 27, 14, 5, 20);
            dataHora2 = dataHora2.AddDays(4); // Adicionando dias
            // Para o ano: dataHora2.addYears(); // Adicionando anos
            // Para o mês: dataHora2.addMonths(); // Adicionando meses
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));

            dataHora2 = dataHora2.Add(new TimeSpan(1, 55, 30)); // Adicionar um Intevalo de tempo
            Console.WriteLine("\n---------------------------------------------------------------------------\n");



            // Subtrair datas
            DateTime dataHora3 = new DateTime(2022, 3, 1, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));

            dataHora3 = dataHora.AddDays(-1);
            Console.WriteLine(dataHora3.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n---------------------------------------------------------------------------\n");
            Console.WriteLine("Precione qualquer tecla para sair!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
