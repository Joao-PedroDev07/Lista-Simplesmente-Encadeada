public class No{

    //Atributos - Características
    public string nome;     //Nome do Funcionário
    public int idade;       //Idade do Funcionário
    public string telefone; //Telefone do Funcionário
    public decimal salario; //Salário do Funcionário
    public No? prox;        //Ponteiro para o próximo Nó
    
    //Construtor
    public No(string Nome, int Idade, string Telefone, decimal Salario){
        this.nome = Nome;
        this.idade = Idade;
        this.telefone = Telefone;
        this.salario = Salario;
        this.prox = null;
    }
    
    //Métodos
    public void imprimir(){
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Idade: " + this.idade);
        Console.WriteLine("Telefone: " + this.telefone);
        Console.WriteLine("Salário: " + this.salario);
    }

}