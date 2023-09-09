using System;
using System.Linq;

class MediaNotas {
    static void Main() {

        double n1;
        double n2;
        double n3;

        Console.Write("Digite a primeira nota do aluno: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota do aluno: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota do aluno: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        double[] notas = { n1, n2, n3 };

        double m = CalcMedia(notas);

        Console.Write("A média das notas foi:   " + m);

    }

    static double CalcMedia(double[] notas) {
        double soma = notas.Sum();
        double m = (soma / 3);
        return m;
    }
}
