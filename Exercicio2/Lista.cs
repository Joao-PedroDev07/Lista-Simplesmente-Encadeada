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

    public void inserirInicio(string Nome, int Idade, string Telefone, decimal Salario){
        No novoNo = new No(Nome, Idade, Telefone, Salario);

        if (this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void inserirFim(string Nome, int Idade, string Telefone, decimal Salario){
        No novoNo = new No(Nome, Idade, Telefone, Salario);

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
                Console.WriteLine("Funcionário encontrado: " + noAtual.nome);
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