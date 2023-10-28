using System.Security.Cryptography.X509Certificates;

namespace TimeConversor
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine(TimerConversion.timeConversion("12:45:54PM"));
        }

        public class TimerConversion
        {
            public static string timeConversion(string s)
            {
                char delimiter = ':';
                string[] Hora = s.Split(delimiter);

                int tiempo = int.Parse(Hora[0]);
                string UltimoTramo = Hora[2];
                string UltimoTramosinHorario = UltimoTramo[^2..];


                if (tiempo == 12 && UltimoTramosinHorario == "AM")
                {
                    Hora[0] = "00";
                }
                else if (tiempo != 12 && UltimoTramosinHorario == "PM" )
                {
                    tiempo += 12;
                    Hora[0] = tiempo.ToString();
                }
                else if(tiempo == 12 && UltimoTramosinHorario == "PM")
                {
                    Hora[0] = Hora[0];
                }

                string HoraFinal = Hora[Hora.Length - 1].Replace("AM", "").Replace("PM", "");

                return $"{Hora[0]}:{Hora[1]}:{HoraFinal}";
            }
        }


    }
}