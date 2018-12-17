using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteETurn
{
    public partial class frmPrincipal : Form
    {
        private List<Cidade> lstCidades;
        private List<Trecho> lstTrechos;
        private List<Trecho> trechosVisitados;
        List<Caminho> lstCaminhos = new List<Caminho>();
        private int qtdParadas = 0;
        private string cidadeInicial;
        private int distanciaInicial;

        public frmPrincipal()
        {
            InitializeComponent();
            InicializaMapa();
        }

        #region Eventos do formulário

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        #endregion

        #region Evento dos Botões

        private void btnSair_Click(object sender, EventArgs e)
        {            
                Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RealizaCalculo();
        }

        #endregion

        #region Metodos

        private void InicializaVariaveisGlobais()
        {
            lstCaminhos = new List<Caminho>();
            qtdParadas = 0;
            cidadeInicial = string.Empty;
            distanciaInicial = 0;
        }

        private void InicializaMapa()
        {
            // Iniciando as listas
            lstCidades = new List<Cidade>();
            lstTrechos = new List<Trecho>();

            //Criando as cidades
            var cidadeA = new Cidade("A");
            var cidadeB = new Cidade("B");
            var cidadeC = new Cidade("C");
            var cidadeD = new Cidade("D");
            var cidadeE = new Cidade("E");

            lstCidades.Add(cidadeA);
            lstCidades.Add(cidadeB);
            lstCidades.Add(cidadeC);
            lstCidades.Add(cidadeD);
            lstCidades.Add(cidadeE);

            // Criando os trechos
            lstTrechos.Add(new Trecho(cidadeA, cidadeB, 5));
            lstTrechos.Add(new Trecho(cidadeB, cidadeC, 4));
            lstTrechos.Add(new Trecho(cidadeC, cidadeD, 8));
            lstTrechos.Add(new Trecho(cidadeD, cidadeC, 8));
            lstTrechos.Add(new Trecho(cidadeD, cidadeE, 6));
            lstTrechos.Add(new Trecho(cidadeA, cidadeD, 5));
            lstTrechos.Add(new Trecho(cidadeC, cidadeE, 2));
            lstTrechos.Add(new Trecho(cidadeE, cidadeB, 3));
            lstTrechos.Add(new Trecho(cidadeA, cidadeE, 7));
        }

        private void RealizaCalculo()
        {
            int totalRota = 0;

            try
            {
                if (rbPergunta1.Checked)
                {
                    var objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "A")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "B")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "B")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "C")));
                    totalRota += objtrecho.Distancia;

                    MessageBox.Show("O resultado é: " + totalRota, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta2.Checked)
                {
                    var objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "A")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "D")));
                    totalRota += objtrecho.Distancia;

                    MessageBox.Show("O resultado é: " + totalRota, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta3.Checked)
                {
                    var objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "A")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "D")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "D")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "C")));
                    totalRota += objtrecho.Distancia;

                    MessageBox.Show("O resultado é: " + totalRota, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta4.Checked)
                {
                    var objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "A")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "E")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "E")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "B")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "B")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "C")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "C")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "D")));
                    totalRota += objtrecho.Distancia;

                    MessageBox.Show("O resultado é: " + totalRota, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta5.Checked)
                {
                    var objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "A")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "E")));
                    totalRota += objtrecho.Distancia;
                    objtrecho = lstTrechos.FirstOrDefault<Trecho>(i => i.Origem.Equals(lstCidades.First(j => j.Nome == "E")) && i.Destino.Equals(lstCidades.First(j => j.Nome == "D")));
                    totalRota += objtrecho.Distancia;

                    MessageBox.Show("O resultado é: " + totalRota, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta6.Checked)
                {
                    MessageBox.Show("O número de viagens começando em C e terminando em C são: " + PercorreTrecho("C", "C", 3) + " rotas possíves", "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else if (rbPergunta7.Checked)
                {
                    MessageBox.Show("O número de viagens começando em A e terminando em C são: " + PercorreTrecho("A", "C", 4) + " rotas possíves", "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta8.Checked)
                {
                    InicializaVariaveisGlobais();
                    PercorreTrecho("A", "C", 99);
                    var menorCusto = lstCaminhos.OrderBy(i => i.Custo).First().Custo;

                    MessageBox.Show("O tamanho da menor viagem(em termos de distância) de A para C é: " + menorCusto, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta9.Checked)
                {
                    InicializaVariaveisGlobais();
                    PercorreTrecho("B", "B", 99);
                    var menorCusto = lstCaminhos.OrderBy(i => i.Custo).First().Custo;
                    MessageBox.Show("O tamanho da menor viagem(em termos de distância) de B para B é: " + menorCusto, "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbPergunta10.Checked)
                {
                    // O numero de viagens começando em C e terminando em C com distância menor que 30

                    /*
                     * Não tive tempo habil para desenvolver este método. Fica para uma próxima oportunidade.
                     */
                }
            }
            catch(NullReferenceException nex)
            {
                MessageBox.Show("Rota não existente!", "..::  Resultado  ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cálculo. O erro é: " + ex.Message, "..::  Erro  ::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int PercorreTrecho(string origem, string destino, int qtdParada)
        {
            var trechos = lstTrechos.FindAll(i => i.Origem.Nome.Equals(origem));
            int contador = 0;
            

            Caminho objCaminho;

            foreach (var t in trechos)
            {
                objCaminho = new Caminho();
                trechosVisitados = new List<Trecho>();

                trechosVisitados.Add(t);
                objCaminho.Percurso += t.Origem.Nome + " - ";
                cidadeInicial = t.Origem.Nome + " - ";
                objCaminho.Custo += t.Distancia;
                distanciaInicial = t.Distancia;
                qtdParadas = 1;

                contador += BuscaProfundidade(t.Destino, destino, qtdParada, ref objCaminho);
            }

            return contador;
        }

        public int BuscaProfundidade(Cidade trechoOrigem, string destino, int qtdParada, ref Caminho caminho)
        {
            int contador = 0;
            var trechos = lstTrechos.FindAll(i => i.Origem.Nome.Equals(trechoOrigem.Nome));
            foreach (var t in trechos)
            {
                if (!trechosVisitados.Contains(t))
                {
                    trechosVisitados.Add(t);
                }
                else
                {
                    caminho.Percurso = caminho.Percurso.Substring(0, caminho.Percurso.Length - 4);
                    caminho.Custo -= t.Distancia;
                    break;
                }

                qtdParadas++;
                caminho.Percurso += t.Origem.Nome + " - ";
                caminho.Custo += t.Distancia;

                if (!t.Destino.Nome.Equals(destino))
                    BuscaProfundidade(t.Destino, destino, qtdParada, ref caminho);
                else
                {
                    caminho.Percurso += t.Destino.Nome;
                    lstCaminhos.Add(caminho);
                    caminho = new Caminho(cidadeInicial, distanciaInicial);
                    trechosVisitados = new List<Trecho>();
                }

                if (qtdParadas <= qtdParada)
                    contador++;
            }

            return contador;
        }




        #endregion
    }
}
