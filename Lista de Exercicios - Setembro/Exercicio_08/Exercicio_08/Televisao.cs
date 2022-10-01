using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    class Televisao
    {
        private string Marca, Modelo;
        private DateTime data_lancamento;
        private double preco_custo;
        private double lcd;
        private int polegada;
        
        public string  getMarca()
        {
            return Marca;
        }

        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }


        public string getModelo()
        {
            return Modelo;
        }

        public void setModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }


        public DateTime getData_lancamento()
        {
            return data_lancamento;
        }

        public void setData_lancamento(DateTime data_lancamento)
        {
            this.data_lancamento = data_lancamento;
        }


        public double getPreco_custo()
        {
            return preco_custo;
        }

        public void setPreco_custo(double preco_custo)
        {
            this.preco_custo = preco_custo;
        }


        public double getLcd()
        {
            return lcd;
        }

        public void setLcd(double lcd)
        {
            this.lcd = lcd;
        }


        public int getPolegada()
        {
            return polegada;
        }

        public void setPolegada(int polegada)
        {
            this.polegada = polegada;
        }

        public string Mostra_Dados()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nData de lançamento: "
            + data_lancamento + "\nPreco_Custo: " + preco_custo + "\nlcd: " + lcd + "\nPolegadas: " + polegada;
        }

        public double Preco_Venda()
        {
            return (preco_custo * 10) / 100 + preco_custo;
        }
    }
}
