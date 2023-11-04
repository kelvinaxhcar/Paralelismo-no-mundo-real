namespace App.Dominio.Servico
{
    public class ServicoDeTarefas
    {
       public string Executar(Tarefa tarefa)
       {
            Thread.Sleep(3000);
            return $"Tarefa executada: {tarefa.Nome}";
       }

        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa()
                {
                    Nome = "Tarefa_1"
                },
                new Tarefa()
                {
                    Nome = "Tarefa_2"
                },
                new Tarefa()
                {
                    Nome = "Tarefa_3"
                },
                new Tarefa()
                {
                    Nome = "Tarefa_4"
                },
                new Tarefa()
                {
                    Nome = "Tarefa_4"
                },
                new Tarefa()
                {
                    Nome = "Tarefa_5"
                },
            };
        }
    }
}
