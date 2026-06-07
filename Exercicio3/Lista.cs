public class Lista{ //SE - Simplesmente Encadeada

    //Atributos
    public No? inicio; //cabeça
    public No? fim; //cauda

    //Construtor
    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia(){
        if(inicio == null && fim == null){
            return(true); //Lista está vazia
        }
        return(false);
    }

    public void inserirInicio(string Nome, string Periodo, decimal CargaHoraria, string ProfessorResponsavel){
        No novoNo = new No(Nome, Periodo, CargaHoraria, ProfessorResponsavel);

        if (this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void ordenada(string Nome, string Periodo, decimal CargaHoraria, string ProfessorResponsavel){
        No novoNo = new No(Nome, Periodo, CargaHoraria, ProfessorResponsavel);

        if (this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
            return;
        }

        if (string.Compare(this.inicio.nome, Nome, StringComparison.OrdinalIgnoreCase) > 0){
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
            return;
        }

        No anterior = this.inicio;
        No atual = anterior.prox;

        while (atual != null && string.Compare(atual.nome, Nome, StringComparison.OrdinalIgnoreCase) < 0){
            anterior = atual;
            atual = atual.prox;
        }

        anterior.prox = novoNo;
        novoNo.prox = atual;

        if (atual == null){
            this.fim = novoNo;
        }
    }

    public void removerPorNome(string Nome){
        if (this.estaVazia()){
            Console.WriteLine("Lista vazia. Nada para remover.");
            return;
        }

        if (this.inicio.nome == Nome){
            this.removerinicio();
            return;
        }

        No anterior = this.inicio;
        No atual = anterior.prox;

        while (atual != null && atual.nome != Nome){
            anterior = atual;
            atual = atual.prox;
        }

        if (atual == null){
            Console.WriteLine("Disciplina não encontrada.");
            return;
        }

        anterior.prox = atual.prox;

        if (atual == this.fim){
            this.fim = anterior;
        }
    }

    public void inserirFim(string Nome, string Periodo, decimal CargaHoraria, string ProfessorResponsavel){
        No novoNo = new No(Nome, Periodo, CargaHoraria, ProfessorResponsavel);

        if(this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public void removerinicio()
    {
  
        if(this.estaVazia())
        {
            Console.WriteLine("Não há nada para remover");
            return;
        }
        if (this.inicio.prox == null)
       {
            this.inicio = null;
            this.fim = null;
            Console.WriteLine("A lista ficou vazia!");
            return;
       }
        this.inicio = this.inicio.prox;
    }
    public void removerfim()
    {
       if(this.estaVazia())
        {
            Console.WriteLine("Não há nada para remover");
            return;
        }
       if (this.inicio.prox == null)
       {
            this.inicio = null;
            this.fim = null;
            Console.WriteLine("A lista ficou vazia!");
            return;
       }
        No NovoNo = this.inicio;
       while (NovoNo.prox.prox != null)
       {
            NovoNo = NovoNo.prox;
       }
        NovoNo.prox = null;
        this.fim= null;
    }

    public Boolean buscar(string chave){
        
        No noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            if(noAtual.nome == chave) 
            {
                Console.WriteLine("Disciplina encontrada: " + noAtual.nome);
                noAtual.imprimir();
                return(true); //Encontrou o elemento
            }
            noAtual = noAtual.prox;
        }

        Console.WriteLine("Funcionário não foi encontrado");
        return(false); //Não encontrou o elemento!
    }


    public void percurso(){
        
        No noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            noAtual.imprimir();
            Console.WriteLine("-> ");
            noAtual = noAtual.prox;
        }
    }
}