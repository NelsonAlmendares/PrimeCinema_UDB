using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Cinema.Data
{
    public class Cliente
    {
        // Creamos las propiedades para obtener los valores
        public string User { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Emali { get; private set; }
        public double Phone { get; private set; }
        public double Document { get; private set; }

        public Cliente (string User_Cliente, string Name_Cliente, string Password_Cliente, string Email_Cliente, double Phone_Cliente, double Document_Cliente) {
            this.User = User_Cliente;
            this.Name = Name_Cliente;
            this.Password = Password_Cliente;
            this.Emali = Email_Cliente;
            this.Phone = Phone_Cliente;
            this.Document = Document_Cliente;
        }
    }
}
