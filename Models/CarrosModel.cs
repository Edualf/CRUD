using System;

namespace Estudio.Models
{
    public class Carros
    {
        public Carros(){
            
        }
        public Carros(int id, string modelo, string color, double precio)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Color = color;
            this.Precio = precio; 
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
    }

}