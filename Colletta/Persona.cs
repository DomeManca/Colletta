using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class Persona
    {
        private string _nome, _cognome, _id;

        public Persona(string nome, string cognome)
        {/*costruttore*/
            Nome = nome;
            Cognome = cognome;
            Id = $"{Nome};{Cognome};ID";
        }
        /*properties*/
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                InserisciSeStringaValida(ref _nome, value, "Nome");
            }
        }
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                InserisciSeStringaValida(ref _cognome, value, "Cognome");
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                InserisciSeStringaValida(ref _id, value, "Id");
            }
        }
        /*fine properties*/

        /*funzioni generali*/
        public override string ToString()
        {
            return $"{Nome};{Cognome};{Id}";
        }
        public bool Equals(Persona p)
        {
            if (p == null)
            {
                return false;
            }
            else if (p == this)
            {
                return true;
            }
            else
            {
                return (p.Id == this.Id);
            }
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Persona);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        /*fine funzioni generali*/
        protected void InserisciSeStringaValida(ref string campo, string val, string perErrore)
        {
            if (!String.IsNullOrWhiteSpace(val))
            {
                campo = val;
            }
            else
            {
                throw new Exception($"Inserire il campo \"{perErrore}\" valido");
            }
        }
    }
}
