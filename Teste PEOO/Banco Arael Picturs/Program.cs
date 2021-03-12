using System;

class MainClass {

    public static void Main(string[] args) {
        Console.WriteLine("Bem vindo ao banco digital Arael Picturs!");
        Console.WriteLine("Para abrir sua conta por favor digite o seu nome:");
        string nome = Console.ReadLine();
        if (nome == "") {
            redirecionar(0);
            return;
        }
        Console.WriteLine($"Ola {nome}, qual o tipo de conta voce quer abrir? (CC ou CP)");
        string tipo = Console.ReadLine();
        if (tipo == "") {
            redirecionar(0);
            return;
        }
        Random rnd = new Random();
        int numero = rnd.Next(1000, 9999);

        setDono(nome);
        setConta(tipo);
        setNum(numero);
        criandoConta();

        Console.WriteLine("");
        Console.WriteLine($"{getDono()}! Sua conta ja foi gerada!");
        Console.WriteLine("Aqui estao suas informacoes!");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine($"Proprietario = {getDono()}"); //retorna o nome do proprietario
        if (getConta().ToLower() == "cc") {
            Console.WriteLine("Tipo da conta = Conta Corrente"); //retorna CC
        }
        else Console.WriteLine("Tipo da conta = Conta Poupanca"); //retorna CP
        Console.WriteLine($"Numero da conta = {getNum()}");//Retorna numero da conta
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("");
        abrirConta();
        if (getConta() == "CC") {
            setSaldo(50);
        }
        else setSaldo(100);

        Console.WriteLine($"{getDono()}! Sua conta ja esta aberta e funcionando!");
        if (getSaldo() == 50) Console.WriteLine($"Foi adicionado R$50,00 pela abertura da sua conta!");
        else Console.WriteLine($"Foi adicionado R$100,00 pela abertura da sua conta!");
        System.Threading.Thread.Sleep(2000);

        int aux = 0;
        while (aux != 1) {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer a seguir?");
            showInfo();
            int numeroRedirecionar = int.Parse(Console.ReadLine()); 
            Console.WriteLine("");
            redirecionar(numeroRedirecionar);
            if (numeroRedirecionar == 0) {
                aux = 1;
            }
            System.Threading.Thread.Sleep(1000);
        }
        return;
    }
    private static string nomeDono;
    private static string tipoConta;
    private static int numConta;
    private static double saldo;
    private static bool status;

    public static void criandoConta() {
        Console.WriteLine("");
        Console.Write("Aguarde");
        for (int i = 0; i <= 3; i++) {
            System.Threading.Thread.Sleep(1500);
            if (i <= 2) Console.Write(".");
            else Console.Write(" ");
        }
        Console.WriteLine("");
    }
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
        else Console.WriteLine("Status = Fechada");

        Console.WriteLine($"Saldo = R${getSaldo()}");
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
            Console.WriteLine("Sua conta agora esta aberta!");
        }
        if (retorno == 2) {
            fecharConta();
            Console.WriteLine("Sua conta agora esta fechada!");
        }
        if (retorno == 3) {
            Console.WriteLine($"Seu saldo eh de R${getSaldo()}");
        }
        if (retorno == 4) {
            Console.WriteLine("Quanto voce gostaria de depositar?");
            double valorDep = double.Parse(Console.ReadLine());
            if (getStatus() == false) {
                Console.WriteLine("A conta esta fechada!");
            }
            else {
                depositar(valorDep);
                Console.WriteLine($"O valor de R${valorDep} foi adicionado a sua conta!");
            } 
        }
        if (retorno == 5) {
            Console.WriteLine("Quanto voce gostaria de sacar?");
            double valorSaq = double.Parse(Console.ReadLine());
            if (getStatus() == false) Console.WriteLine("A sua conta esta fechada!");
            else if (getSaldo() - valorSaq < 0) Console.WriteLine("Voce nao tem saldo suficiente!");
            else {
                sacar(valorSaq);
                Console.WriteLine($"O valor de R${valorSaq} foi retirado da sua conta!");
            }
        }
        if (retorno == 6) {
            retornoConta();
        }
        if (retorno == 0) {
            Console.WriteLine("O banco Arael Picturs agradece a preferencia! Volte sempre!");
        }
    }
    public static void abrirConta() {
        setStatus(true);
    }
    public static void fecharConta() {
        setStatus(false);
    }
    public static void depositar(double valorDeposito) {
        setSaldo(valorDeposito);
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
        return tipoConta.ToUpper();
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

