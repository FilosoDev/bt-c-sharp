using System;
using System.Text;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var id = Guid.NewGuid(); //criar identificador global aleatório
            //id.ToString();
            //id = new Guid();
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));

            var price = 10.2;
            //var texto = "O preço do produto é " + price;
            //var texto = string.Format("O preço do produto é {0}", price);
            var texto = $"O preço da promoção é {price}";

            Console.WriteLine(texto);

            var textoDois = "Testandoe, alguma, coisa";
            Console.WriteLine(textoDois.CompareTo("Testando")); // 0 se tiver

            Console.WriteLine(textoDois.Contains("ando")); // true se tiver

            Console.WriteLine(textoDois.StartsWith("Tes"));

            Console.WriteLine(textoDois.EndsWith("Tes"));

            Console.WriteLine(textoDois.EndsWith("ando"));

            Console.WriteLine(textoDois.Equals("Testando"));

            Console.WriteLine(textoDois.IndexOf("t")); //busca o índice
            Console.WriteLine(textoDois.LastIndexOf("e")); //busca o índice da ultima ocorrência

            Console.WriteLine(textoDois.ToLower());
            Console.WriteLine(textoDois.ToUpper());
            Console.WriteLine(textoDois.Insert(5, "AQUI")); //INSERE O TEXTO na posição

            Console.WriteLine(textoDois.Remove(1, 2));

            Console.WriteLine(textoDois.Length);

            Console.WriteLine(textoDois.Replace("ando", "novo"));

            var divisao = textoDois.Split(",");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);

            var resultado = textoDois.Substring(5, 3);
            Console.WriteLine(resultado);

            var textoTres = " Olá ";
            Console.WriteLine(textoTres.Trim()); //limpa os espaços

            var textoQuatro = new StringBuilder();
            textoQuatro.Append("Esse texto é legal!");
            textoQuatro.Append("...");
            textoQuatro.Append("mesmo!");
            //textoQuatro.ToString();
            Console.WriteLine(textoQuatro);

            // TRABALHANDO COM DATAS
            Console.Clear();
            // var data = new DateTime(); ->só cria uma estrutura datetime
            // var data = DateTime.Now;

            var data = new DateTime(2022, 10, 12, 8, 23, 14);

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);

            Console.Clear();

            //var dataFormatada = String.Format("{0:yyyy}", data);
            //var dataFormatada = String.Format("{0:yy}", data);
            //var dataFormatada = String.Format("{0:y}", data);
            //var dataFormatada = String.Format("{0:yyy}", data);
            //var dataFormatada = String.Format("{0:M}", data);
            //var dataFormatada = String.Format("{0:mm}", data);
            //var dataFormatada = String.Format("{0:yyyy-MM-dd}", data);
            //var dataFormatada = String.Format("{0:dd-MM-yyyy}", data);
            //var dataFormatada = String.Format("{0:dd-MM-yyy hh:mm:ss}", data);
            //var dataFormatada = String.Format("{0:t}", data);
            //var dataFormatada = String.Format("{0:d}", data);
            //var dataFormatada = String.Format("{0:T}", data);
            //var dataFormatada = String.Format("{0:D}", data);
            //var dataFormatada = String.Format("{0:f}", data);
            //var dataFormatada = String.Format("{0:g}", data);
            //var dataFormatada = String.Format("{0:r}", data);
            //var dataFormatada = String.Format("{0:s}", data);
            var dataFormatada = String.Format("{0:u}", data);

            Console.WriteLine(dataFormatada);

            Console.Clear();

            var dataTres = DateTime.Now;
            Console.WriteLine(dataTres);

            Console.WriteLine(dataTres.AddDays(12));

            Console.WriteLine(dataTres.AddMonths(1));

            Console.WriteLine(dataTres.AddYears(1));

            Console.Clear();

            var dataQuatro = DateTime.Now;

            if (dataQuatro.Date == DateTime.Now.Date) // compara só a data, pois sempre será diferente se considerar segubdos
            {
                Console.WriteLine("é igual");
            }

            Console.WriteLine(dataQuatro);

            //GLOBALIZAÇÃO
            Console.Clear();

            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atualCultura = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atualCultura));


            //UTC
            Console.Clear();

            var dateTimeUtc = DateTime.UtcNow;
            Console.WriteLine(dateTimeUtc);
            Console.WriteLine(dateTimeUtc.ToLocalTime());

            var timezoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            Console.WriteLine(timezoneTokyo);

            var horaTokyo = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezoneTokyo);
            Console.WriteLine(horaTokyo);


            Console.Clear();
            // pegar todos timezones
            var dateTime = DateTime.Now;
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezone));
                Console.WriteLine("___________________");
            }

            //timespan
            Console.Clear();
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);


            // algumas funções

            // dias no mês
            Console.WriteLine(DateTime.DaysInMonth(2021, 1));

            // hoje é fim de semana
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            // horário de verão (está ou não)
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

            // MOEDAS
            Console.Clear();

            decimal valor = 10.789m; //mais preciso
            Console.WriteLine(valor);

            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine(valor.ToString(
                "P",
                 CultureInfo.CreateSpecificCulture("pt-BR")));


            // arredondamentos
            Console.WriteLine(
                Math.Round(valor)
            );

            Console.WriteLine(
                Math.Ceiling(valor)
            );

            Console.WriteLine(
                Math.Floor(valor)
            );

        }

        // datas
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
