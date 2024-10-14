namespace ConsoleApp_2024C2_12C_EF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var micontexto = new EscuelaDBContext();

            var estud = new Estudiante()
            {
                Nombre = "Bill",
                Edad = 18,
                Email = "micorreo@gamil.com"
            };
            micontexto.Estudiantes.Add(estud);
            micontexto.SaveChanges();

        }
    }
}
