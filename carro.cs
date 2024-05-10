
using System;   



public class Carro : Veiculo, Iacelerar{
    public string modelo;
    public string marca;

    public Carro(string _tipo, string _placa,string _modelo, string _marca) : base (_tipo,_placa){
        this.modelo = _modelo;
        this.marca = _marca;
        
        
    }

    public void Acelera (){

       
            Console.WriteLine("Acelera Airtonnnnnn!!!");
        

    }
}