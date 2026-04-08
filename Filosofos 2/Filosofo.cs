using System;

public class Filosofo
{
    public string Nome;
    private Talheres talheres;

    public Filosofo(string nome, Talheres t)
    {
        Nome = nome;
        talheres = t;
    }

    public void PegarFaca()
    {
        if (talheres.FacaLivre)
        {
            talheres.FacaLivre = false;
            talheres.DonoFaca = Nome;
            Console.WriteLine($"{Nome} pegou a faca (α)");
            Comer();
        }
        else
        {
            Console.WriteLine($"{Nome} não conseguiu pegar a faca, está com {talheres.DonoFaca}");
        }
    }

    public void PegarGarfo()
    {
        if (talheres.GarfoLivre)
        {
            talheres.GarfoLivre = false;
            talheres.DonoGarfo = Nome;
            Console.WriteLine($"{Nome} pegou o garfo (β)");
            Comer();
        }
        else
        {
            Console.WriteLine($"{Nome} não conseguiu pegar o garfo, está com {talheres.DonoGarfo}");
        }
    }

    private void Comer()
    {
        if (talheres.DonoFaca == Nome && talheres.DonoGarfo == Nome)
        {
            Console.WriteLine($"{Nome} comeu (C),e voltou a pensar");
            DevolverTalheres();
        }
    }

    private void DevolverTalheres()
    {
        if (talheres.DonoFaca == Nome)
        {
            talheres.FacaLivre = true;
            talheres.DonoFaca = "";
        }

        if (talheres.DonoGarfo == Nome)
        {
            talheres.GarfoLivre = true;
            talheres.DonoGarfo = "";
        }

        Console.WriteLine($"{Nome} devolveu o garfo e a faca (V)");
    }

    public bool PossuiGarfo()
    {
        return talheres.DonoGarfo == Nome;
    }
}