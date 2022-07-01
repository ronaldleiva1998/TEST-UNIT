using Webapp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
            //public void validarModelo_EdadEsMayorque18_RetornarVerdadero() 
            //{
            //var persona = new Persona();
            //persona.Edad = 19;
            //bool resultado = persona.Validar();
            //Assert.IsTrue(resultado);

            //}

        public void Return_0_When_recives_Empty()
        {
            var calculator = new StringCalculatorShould();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }
        internal int  Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            return 0;

            var parts = numbers.Split(',');
            if (parts.Length==1)
            
                return int.Parse(numbers);
            var total = 0;
            foreach (var number in parts)
            {
                total=total+int.Parse(number);
            }
          return total;
        }
        [TestMethod]
        public void Return_Number_When_Recives_That_Number()
        {
            var calculator = new StringCalculatorShould();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void return_sum_when_recives_two_numbers()
        {
            var calculator = new StringCalculatorShould();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Return_Sum_When_Recives_Any_Amount_of_Numbers()
        {
            var calculator = new StringCalculatorShould();
            var result = calculator.Add("1,2,3,4");
            Assert.AreEqual(10, result);    

        }
    }
}