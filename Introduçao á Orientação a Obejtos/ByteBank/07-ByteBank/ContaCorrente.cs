﻿using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        

        static public int TotalDeContas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int NumeroConta { get; set; }
        private double _saldo = 100; // Definindo como default o valor 100


        public double Saldo
        {
            get // Obter Saldo || Sempre retornar saldo
            {
                return _saldo;
            }
            set // Definir Saldo || sempre definir o saldo
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numeroconta)
        {
            Agencia = agencia;
            NumeroConta = numeroconta;

            TotalDeContas++;
        }

        // função sacar
        public bool Sacar(double valor) // função sempre começa com maiuscula
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        // metodo depositar
        // é costume chamar de metodo quando não retonar nada.
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor; //retirar o saldo da conta de origem
            contaDestino.Depositar(valor); // atribui saldo na conta destino
            return true;
        }
    }
}
