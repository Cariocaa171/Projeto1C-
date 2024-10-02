using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cariocaa23
{
    internal interface Interface22_carioca
    {
    }
}

using System;

// Interfaces
public interface IVoador
{
    void Decolar();
    void Planar();
    void Pousar();
    void Cair();
}

public interface IPairador : IVoador
{
    void Pairar();
}

public interface ISerVivo
{
    void Comer();
    void Dormir();
    void Respirar();
    void Morrer();
}

public interface IMaquina
{
    void Ligar();
    void Desligar();
    void Abastecer();
    void Alerta();
}

// Classes concretas implementando as interfaces
public class Aviao : IVoador, IMaquina
{
    public void Decolar() => Console.WriteLine("Avião decolando.");
    public void Planar() => Console.WriteLine("Avião planando.");
    public void Pousar() => Console.WriteLine("Avião pousando.");
    public void Cair() => Console.WriteLine("Avião caindo!");
    public void Ligar() => Console.WriteLine("Ligando motores do avião.");
    public void Desligar() => Console.WriteLine("Desligando motores do avião.");
    public void Abastecer() => Console.WriteLine("Abastecendo o avião.");
    public void Alerta() => Console.WriteLine("Alerta crítico no avião!");
}

public class Helicoptero : IVoador, IMaquina
{
    public void Decolar() => Console.WriteLine("Helicóptero decolando.");
    public void Planar() => Console.WriteLine("Helicóptero planando.");
    public void Pousar() => Console.WriteLine("Helicóptero pousando.");
    public void Cair() => Console.WriteLine("Helicóptero caindo!");
    public void Ligar() => Console.WriteLine("Ligando rotor do helicóptero.");
    public void Desligar() => Console.WriteLine("Desligando rotor do helicóptero.");
    public void Abastecer() => Console.WriteLine("Abastecendo o helicóptero.");
    public void Alerta() => Console.WriteLine("Alerta crítico no helicóptero!");
}

public class Passaro : IVoador, ISerVivo
{
    public void Decolar() => Console.WriteLine("Pássaro alçando voo.");
    public void Planar() => Console.WriteLine("Pássaro planando.");
    public void Pousar() => Console.WriteLine("Pássaro pousando.");
    public void Cair() => Console.WriteLine("Pássaro caindo!");
    public void Comer() => Console.WriteLine("Pássaro se alimentando.");
    public void Dormir() => Console.WriteLine("Pássaro dormindo.");
    public void Respirar() => Console.WriteLine("Pássaro respirando.");
    public void Morrer() => Console.WriteLine("Pássaro morreu!");
}

public class BeijaFlor : IPairador, ISerVivo
{
    public void Decolar() => Console.WriteLine("Beija-flor alçando voo.");
    public void Planar() => Console.WriteLine("Beija-flor planando.");
    public void Pousar() => Console.WriteLine("Beija-flor pousando.");
    public void Cair() => Console.WriteLine("Beija-flor caindo!");
    public void Pairar() => Console.WriteLine("Beija-flor pairando no ar.");
    public void Comer() => Console.WriteLine("Beija-flor se alimentando de néctar.");
    public void Dormir() => Console.WriteLine("Beija-flor dormindo.");
    public void Respirar() => Console.WriteLine("Beija-flor respirando.");
    public void Morrer() => Console.WriteLine("Beija-flor morreu!");
}

// Outros exemplos...
public class Trem : IMaquina
{
    public void Ligar() => Console.WriteLine("Trem ligando.");
    public void Desligar() => Console.WriteLine("Trem desligando.");
    public void Abastecer() => Console.WriteLine("Abastecendo o trem.");
    public void Alerta() => Console.WriteLine("Alerta no trem!");
}

public class Carro : IMaquina
{
    public void Ligar() => Console.WriteLine("Carro ligando.");
    public void Desligar() => Console.WriteLine("Carro desligando.");
    public void Abastecer() => Console.WriteLine("Abastecendo o carro.");
    public void Alerta() => Console.WriteLine("Alerta no carro!");
}

// Exemplo de uso
class Program
{
    static void Main(string[] args)
    {
        Aviao aviao = new Aviao();
        aviao.Decolar();
        aviao.Ligar();

        Helicoptero helicoptero = new Helicoptero();
        helicoptero.Pousar();

        // Adicione mais exemplos aqui para testar outras classes
    }
}
