using System;
class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Bem vindo ao banco digital Arael Picturs");
        Console.WriteLine("Para abrir sua conta por favor digite o seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine($"Ola {nome}, qual o tipo de conta voce quer abrir?");
        string tipo = Console.ReadLine();
        Random rnd = new Random();
        int numero = rnd.Next(1000, 9999);

        setDono(nome);
        setConta(tipo);
        setNum(numero);

        Console.WriteLine("Sua conta ja foi gerada!");
        Console.WriteLine("Aqui estao suas informacoes!");
        Console.WriteLine($"Proprietario = {getDono()}"); //retorna o nome do proprietario
        if (getConta() == "cc") {
            Console.WriteLine("Tipo da conta = Conta Corrente"); //retorna CC
        }
        else Console.WriteLine("Tipo da conta = Conta Poupanca"); //retorna CP
        Console.WriteLine($"Numero da conta = {getNum()}");//Retorna numero da conta
        Console.WriteLine("");
        abrirConta();

        Console.WriteLine($"{getDono}! Sua conta ja esta aberta e funcionando, o que deseja fazer a seguir?");

        for (int aux = 0) {
            showInfo();
            int numeroRedirecionar = int.Parse(Console.ReadLine()); 
            redirecionar(numeroRedirecionar);
        }
    }
    private static string nomeDono;
    private static string tipoConta;
    private static int numConta;
    private static double saldo;
    private static bool status = false;

    public static void retornoConta() {
        Console.WriteLine($"Propietario = {getDono()}");
        if (getConta() == "cc") {
            Console.WriteLine("Tipo da conta = Conta Corrente");
        }
        else Console.WriteLine("Tipo da conta = Conta Poupanca");
        Console.WriteLine($"Conta = {getNum()}");
        if (getStatus() == true) {
            Console.WriteLine("Status = Aberta");
        }

        Console.WriteLine($"Saldo = {getSaldo()}");
    }
    public static void showInfo () {
        Console.WriteLine("1 - Abrir conta");
        Console.WriteLine("2 - Fechar conta");
        Console.WriteLine("3 - Ver saldo");
        Console.WriteLine("4 - Depositar");
        Console.WriteLine("5 - Sacar");
        Console.WriteLine("6 - Informacoes da conta");
        Console.WriteLine("0 - Sair");
    }
    public static void redirecionar(int retorno) {
        if (retorno == 1) {
            abrirConta();
            Console.WriteLine();
        }
    }
    public static void abrirConta() {
        setStatus(true);
    }
    public static void fecharConta() {
        setStatus(false);
    }
    public static void depositar(double valorDeposito) {
        if (getStatus() == true) {
            if (getConta() == "cc") {
                setSaldo(50);
            }
            if (getConta() == "cp") {
                setSaldo(150);
            }
        setSaldo(valorDeposito);
        }
        else Console.WriteLine("Conta fechada");
    }
    public static void sacar(double valorSaque) {
        setSaldo(0 - valorSaque);
    }
    public static void setStatus(bool sts) {
        status = sts;
    }
    public static bool getStatus() {
        return status;
    }

    public static void setDono(string name) {
        nomeDono = name;
    }
    public static string getDono() {
        return nomeDono;
    }
    public static void setConta (string account) {
        tipoConta = account.ToLower();
    }
    public static string getConta () {
        return tipoConta;
    }
    public static void setNum (int number) {
        numConta = number;
    }
    public static int getNum () {
        return numConta;
    }
    public static void setSaldo (double amount) {
        saldo += amount;
    }
    public static double getSaldo () {
        return saldo;
    }
}

