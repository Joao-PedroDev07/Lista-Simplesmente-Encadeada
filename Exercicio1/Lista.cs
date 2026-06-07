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

    public void inserirInicio(int Valor){
        No novoNo = new No(Valor);

        if (this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void inserirFim(int Valor){
        No novoNo = new No(Valor);

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
       No NovoNo = this.inicio; //copia do inicio 
       if (NovoNo.prox.prox != null)
       {
            NovoNo = NovoNo.prox;
       }
       NovoNo.prox = null;
       this.fim= null;
        
    }

    public Boolean buscar(int chave){
        
        No? noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            if(noAtual.valor == chave) 
            {
                Console.WriteLine("O valor de busca foi encontrado, é " + noAtual.valor);
                return(true); //Encontrou o elemento
            }
            noAtual = noAtual.prox;
        }

        Console.WriteLine("O valor de busca não foi encontrado");
        return(false); //Não encontrou o elemento!
    }


    public void percurso(){
        
        No noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            Console.WriteLine(noAtual.valor + "-> ");
            noAtual = noAtual.prox;
        }
    }
}