using App.Dominio.Servico;
using App.Dominio;
using System.Windows.Forms;

namespace AppThread
{
    public partial class AppThread : Form
    {
        List<Tarefa> _tarefas;
        ServicoDeTarefas _servicoDeTarefas;
        public AppThread()
        {
            InitializeComponent();
            _servicoDeTarefas = new ServicoDeTarefas();
            _tarefas = _servicoDeTarefas.ObterTarefas();
        }

        private void AoClicarEmExecutar(object sender, EventArgs e)
        {
            buttonExecutar.Enabled = false;
            var execucoes = new List<string>();

            var inicio = DateTime.Now;

            _tarefas.ForEach(tarefa =>
            {
                var retorno = _servicoDeTarefas.Executar(tarefa);
                execucoes.Add(retorno);
            });
            var fim = DateTime.Now;

            richTextBox.Text = string.Join("\n", execucoes);
            var segundos = fim - inicio;
            labelTempoFinal.Text = segundos.TotalSeconds.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}