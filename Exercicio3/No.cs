public class No{

    //Atributos - Características
    public string nome;     
    public string periodo;     
    public decimal cargahoraria; 
    public string professorResponsavel; 
    public No? prox;        //Ponteiro para o próximo Nó
    
    //Construtor
    public No(string Nome, string Periodo, decimal Cargahoraria, string ProfessorResponsavel){
        this.nome = Nome;
        this.periodo = Periodo;
        this.cargahoraria = Cargahoraria;
        this.professorResponsavel = ProfessorResponsavel;
        this.prox = null;
    }
    
    //Métodos
    public void imprimir(){
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Periodo: " + this.periodo);
        Console.WriteLine("Carga Horário: " + this.cargahoraria);
        Console.WriteLine("Professor Responsável: " + this.professorResponsavel);
    }

}