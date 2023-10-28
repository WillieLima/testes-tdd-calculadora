using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCalculadora
{
    public class Calculadora
    {
        private int _numero1;
        private int _numero2;
        private List<string> _historico;
        private DateTime _data;
        private string _dataString;
        public Calculadora(string data)
        {
            _historico = new List<string>();
            _data = DateTime.Now;

            this._dataString = data;

        }

        public DateTime Data 
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        public int Numero1
        {
            get
            {
                return _numero1;
            }
            set
            {
                _numero1 = value;
            }
        }
        public int Numero2
        {
            get
            {
                return _numero2;
            }
            set
            {
                _numero2 = value;
            }
        }
        public List<string> Historico 
        {
            get
            {
                return _historico;
            }
            set
            {
                _historico = value;
            }
        }
        public int Somar(int numero1, int numero2)
        {
            Historico.Insert(0, "Resultado: " + (numero1 + numero2) + "Data: " + Data);

            return numero1 + numero2;
        }
        public int Subtrair(int numero1, int numero2)
        {
            Historico.Insert(0, "Resultado: " + (numero1 - numero2) + "Data: " + Data);

            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            Historico.Insert(0, "Resultado: " + (numero1 * numero2) + "Data: " + Data);

            return numero1 * numero2;
        }
        public int Dividir(int numero1, int numero2)
        {
            Historico.Insert(0, "Resultado: " + (numero1 / numero2) + "Data: " + Data);

            return numero1 / numero2;
        }
        public List<string> HistoricoLista()
        {
            Historico.RemoveRange(3, Historico.Count - 3); // o primeiro parâmetro é a casa da qual deve começar a remover, o segundo parâmetro
            //é a quantidada da lista menos a quantidade que eu quero manter.

            return Historico;
        }

    }
}
