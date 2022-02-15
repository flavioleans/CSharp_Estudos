using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Array
            string[] nomes = new string[2];
            nomes[0] = "Marques";
            nomes[1] = "Leandro";

            //List
            List<string> nomes1 = new List<string>();
            nomes1.Add("Flávio");
            nomes1.Add("Girlene");
            nomes1.AddRange(nomes); // adicinando um array dentro do List

            //remover item da lista de forma direta
            // nomes1.Remove("Leandro");

            //remover com o retorno bool
            //if (nomes1.Remove("Leandro"))
            //{
            //    MessageBox.Show("Item Removido com sucesso");
            //}
            //else
            //{
            //    MessageBox.Show("O item não foi removido!");
            //}

            //Metodo Contains
            //if (nomes1.Contains("Flávio"))
            //{
            //    MessageBox.Show("Contem!");
            //}
            //else
            //{
            //    MessageBox.Show("Não contem");
            //}

            //Metodo Count
            //MessageBox.Show("A Lista contem " + nomes1.Count + " elementos");

            //organizar em ordem alfabetica
            //nomes1.Sort();

            //descobrir o indice de um elemento
            //MessageBox.Show("Leandro esta no index: " + nomes1.IndexOf("Leandro"));

            //inserir item em um index desejado
            //nomes1.Insert(2, "Silva");

            //Remover o item atravez do indice
            //nomes1.RemoveAt(1);

            //Limpar a lista
            //nomes1.Clear();


            foreach (string nome in nomes1)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            //Semelhante a List, mas não permite itens repetidos
            
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //verificando se aceita repetido
            if (veiculos.Add("Avião"))
            {
                MessageBox.Show("item adiconado com sucesso");
            }
            else
            {
                MessageBox.Show("item ja foi adiconado anteriormente");
            }

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }

            //Acessando o item pelo index
            //MessageBox.Show(veiculos.ElementAt(3));

            //Retorna Primeiro Elemento 
            //MessageBox.Show(veiculos.First());

            //Retorna o ultimo elemento
            //MessageBox.Show(veiculos.Last());

            //Metodos que são iguais ao List
            //Contains();
            //Remove();
            //Count();
            //Clear();


        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //Funciona como uma List, mas passamos uma chave e um valor
            //Nâo adiciona chave com o mesmo valor
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Girlene" }, {200, "Leandro"}, {80, "Danny"}
            };
            
           // alunos.Add(100, "Flávio");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                //lista.Items.Add(item);

                //mostrando somente o valor
                //lista.Items.Add(item.Value);

                //mostrando somente o key
                //lista.Items.Add(item.Key);

                //pode ser adicionado a uma variavel e usar seu retorno key/value
                //KeyValuePair<int, string> valor = alunos.First();


                //os 2
                lista.Items.Add(item.Key + "=" + item.Value);

                //Metodos que são iguais ao List
                //.Clear();
                //Count();
                //ContainsKey(200);
                //ContainsValue("Flávio")
                //Remove(key);
                //Count();
                //Clear();
                //.First();
                //.Last();
            }

        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            // cria key, value e index
            //organiza os items pela key
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {50, "Flavio" }, {25, "Girlene"}, {17, "Amora"}
            };

            //add mais um
            //alunos.Add(14, "Silva");

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno.Key + " " + aluno.Value);
            }

            //ordem invertida
            //foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            //{
            //    lista.Items.Add(aluno.Key + " " + aluno.Value);
            //}

            //remover
            //alunos.Remove(50); //passa a key
            //alunos.RemoveAt(0); //passa o index em ordenação 

            //alunos.Count();

            //alunos.ContainsKey(50);
            //alunos.ContainsValue();
        }

        private void btnSortedDict_Click(object sender, EventArgs e)
        {
            //dicionario ordenado crescente/decerescente
            //diferença entre a sorted esta no processamento
            //usa os mesmos metodos do sorted - usa mais memoria, mas processa mais rapido
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>
            {
                {50, "Flavio" }, {25, "Girlene"}, {17, "Amora"}
            };
            //adicionar
            alunos.Add(30, "outro");

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno);
            }

            //ordem reversa
            foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            {
                lista.Items.Add(aluno);
            }


        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            //apresenta os itens na ordem.
            SortedSet<string> nomes = new SortedSet<string>
            {
                "Flavio", "Girlene", "Amora"
            };

            foreach (string item in nomes.Reverse())
            {
                lista.Items.Add(item);
            }
            //Reverse();
            //Add(); retorna bool para saber se existe ou não
            //Remove();
            //ElementAt(); passa o index
            //First();
            //Last();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            //Fila o primeiro a entrar é o primeiro a sair
            lista.Items.Clear();
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Flávio");
            fila.Enqueue("Girlene");
            fila.Enqueue("Silva");

            // MessageBox.Show(fila.Count().ToString());


            //Retorna o primeiro da fila sem remove-lo
            //MessageBox.Show("Primeiro da fila " + fila.Peek());

            //Remover o primeiro objeto da fila
            //MessageBox.Show("Primeiro da fila " + fila.Dequeue());

            //semelhando ao peek, apenas mostra o primeiro da fila
            //MessageBox.Show("Primeiro da fila " + fila.First());

            //apenas mostra o ulitmo da fila
            //MessageBox.Show("Primeiro da fila " + fila.Last());

            //limpar toda a fila
            //fila.Clear();

            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro da fila " + fila.Dequeue());
                MessageBox.Show(fila.Count().ToString());
                lista.Items.Clear();

                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }

        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            //semelhante a fila, porem, primeiro a entrar é o ultimo a sair
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Girlene");
            pilha.Push("Flávio");
            pilha.Push("Silva");

            foreach (string item in pilha)
            {
                lista.Items.Add(item);
            }

            MessageBox.Show(pilha.Count().ToString());

            while (pilha.Count > 0)
            {
                MessageBox.Show("Elemento no topo: " + pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();

                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }


            //pilha.Clear();
            //retorna o objeto do topo da pilha sem remove-lo
            //MessageBox.Show(pilha.Peek());

            //retorna o objeto do topo da pilha e remove
            //MessageBox.Show(pilha.Pop());

        }
    }
}
