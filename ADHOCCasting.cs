using System.Numerics;

class  ADHOCCasting
{
    public class Funcionario{
        private string nome;
        private BigInteger salario;

        public void setNome(string _nome){
            this.nome = _nome;
        }

        public string getNome(){
            return this.nome;
        }

        public void setSalario(BigInteger _salario) {
            this.salario = _salario;
        }

        public BigInteger getSalario() {
            return this.salario;
        }

    }

    class Gerente :Funcionario{
            private string senha;

            public void setSenha( string _senha){
                this.senha = _senha;
            }

            public String getSenha() {
                return this.senha;
            }    
    }
            public static void Executar(){

                Funcionario f1 = new Funcionario();
                Gerente g1 = new Gerente();

                g1.getNome();
                g1.getSalario();
                g1.getSenha();

                Funcionario g2 = new Gerente();

                Gerente gerente = (Gerente) g2;

                gerente.getSenha();

            }
        
    
}