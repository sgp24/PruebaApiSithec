using System.ComponentModel.DataAnnotations;

namespace PruebaAPISithec.Models
{
    public class Humano
    {
        //Constructor
        //public Humano(int id, string nombre, string sexo, string edad, string estatura, string peso)
        //{
        //    this.Id = id;
        //    this.Nombre = nombre;
        //    this.Sexo = sexo;
        //    this.Edad = edad;
        //    this.Estatura = estatura;
        //    this.Peso = peso;
        //}
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Edad { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
    }
}
