namespace Webapp
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public bool Validar()
        {
            if (Edad < 18) { return false; }
            return true;
        }
        public void StringCalculatorShould()
        {

        }
      
    }
}
