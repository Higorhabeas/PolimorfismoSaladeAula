
    

public class Carro : Veiculo, Iacelerar{
    public string modelo;
    public string marca;

    public Carro (string _modelo, string _marca,string tipo, string placa) {
        this.modelo = _modelo;
        this.marca = _marca;
        this.tipo = tipo;
        this.placa = placa;
        
    }

    public void Acelera (Carro c){

       
            Console.WriteLine("Acelera Airtonnnnnn!!!");
        

    }
}