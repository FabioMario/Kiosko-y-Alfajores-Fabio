using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string paciente1 = AppointmentService.CreateAppointment("Fabio", "1234", "0987", DateTime.Parse("2020-10-10"), "Montevideo", "Dr.Chau");
            string paciente2 = AppointmentService.CreateAppointment("", "1234", "0987", DateTime.Parse("2020-10-10"), "Montevideo", "Dr.Chau");
            Console.WriteLine(paciente1);
            Console.WriteLine(paciente2);
        }
    }
}
