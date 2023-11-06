using App.Dominio.Servico;
using App.Dominio;

namespace AppThread
{
    public partial class AppComThread : Form
    {
        List<Tarefa> _tarefas;
        ServicoDeTarefas _servicoDeTarefas;
        public AppComThread()
        {
            InitializeComponent();
            _servicoDeTarefas = new ServicoDeTarefas();
            _tarefas = _servicoDeTarefas.ObterTarefas();
        }

        private void AoClicarEmExecutar(object sender, EventArgs e)
        {
            var tarefasGrupo1 = _tarefas.Take(_tarefas.Count / 2).ToList();
            var tarefasGrupo2 = _tarefas.Skip(_tarefas.Count / 2).ToList();

            var tarefasExecutadas = new List<string>();

            var thread_1 = new Thread(() =>
            {
                tarefasGrupo1.ForEach(tarefa =>
                {
                    var retorno = _servicoDeTarefas.Executar(tarefa);
                    tarefasExecutadas.Add(retorno);
                });
            });

            var thread_2 = new Thread(() =>
            {
                tarefasGrupo2.ForEach(tarefa =>
                {
                    var retorno = _servicoDeTarefas.Executar(tarefa);
                    tarefasExecutadas.Add(retorno);
                });
            });

            buttonExecutar.Enabled = false;

            var inicio = DateTime.Now;
            thread_1.Start();
            thread_2.Start();

            while (thread_1.IsAlive || thread_2.IsAlive)
            {
                const int timeout = 1000;
                Thread.Sleep(timeout);
            }

            var fim = DateTime.Now;
            AtualizarTela(tarefasExecutadas, inicio, fim);
        }

        private void AtualizarTela(List<string> execucoes, DateTime inicio, DateTime fim)
        {
            richTextBox.Text = string.Join("\n", execucoes);
            var segundos = fim - inicio;
            labelTempoFinal.Text = segundos.TotalSeconds.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}