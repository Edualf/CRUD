using System;
using System.Collections.Generic;
using System.Linq;
using Estudio.Models;

namespace Estudio
{
    public class CarrosRepository
    {
        private static List<Carros> db;
        static CarrosRepository() {
            db = new List<Carros>();
            db.Add(new Carros(0, "Tsuru", "Rojo", 175500));
            db.Add(new Carros(1, "Corolla", "Azul", 230900));
        }

        public List<Carros> LeerCarros() {
            return db.ToList();
        }

        internal object LeerCarroPorID(int id)
        {
            return db.FirstOrDefault(t=> t.Id == id);
        }

        internal void AgregarCarro(Carros model)
        {
            model.Id = db.Max(p=> p.Id)+1;
           db.Add(model);
        }

        internal void EditarCarro(Carros model)
        {
            var carro = db.FirstOrDefault(t=> t.Id == model.Id);
            carro.Modelo = model.Modelo;
            carro.Precio = model.Precio;
            carro.Color = model.Color;
        }

        internal void EliminarCarro(Carros model)
        {

            var carro =  db.FirstOrDefault(t=> t.Id == model.Id);
           db.Remove(carro);
        }
    }
}