using ClassLibrary1;
using System;

namespace ClassLibrary1
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string facebook;
        private Auto auto;
        private Servicio servicio;

        public Cliente(int id, string nombre, string apellido, string direccion, string telefono, string facebook, Auto auto, Servicio servicio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Facebook = facebook;
            ID = id;
            Auto = auto;
            Servicio = servicio;
        }

        public Cliente(int id, string nombre, string apellido, string direccion, string telefono, string facebook, Auto auto, Servicio servicio)
        {
            ID = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.facebook = facebook;
            this.auto = auto;
            this.servicio = servicio;
        }

        public Cliente(int id, Auto auto, Servicio servicio)
        {
            this.id = id;
            this.auto = auto;
            this.servicio = servicio;
        }

        public int ID { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get {  return apellido; } set { apellido = value; } }
        public string Direccion { get {  return direccion; } set { direccion = value; } }
        public string Telefono { get {  return telefono; } set { telefono = value; } }
        public string Facebook { get {  return facebook; } set { facebook = value; } }
        public Auto Auto { get { return auto; } set {  auto = value; } }
        public Servicio Servicio { get {  return servicio; } set { servicio = value; } }

    }
}