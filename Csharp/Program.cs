// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

class Program {
  public static void Main (string[] args) {
    int mes;
    double x, y, z, a, b, c, nota;
    double q, w, e, r, area, raio, fx;
    double  numero, raiz;
    c = 33;
    raio = 4;
  
    //soma
      x = 3 + 5;
    //subtração
      y = 7 - 1;
    //multiplicação
      z = 10 * 0.5;
    //divisão
      a = 752/8;
    //resto de divisão
      b = 753%2;
    Console.WriteLine("esses são os valores de: x = "+x+", y = "+y+", z = "+z+", a = "+a+" e b = "+b);

    //Operações de atribuição combinadas
    //Soma combinada, vai somar o mesmo valor + o que você colocar (x += 10 vai ser x = x+10)
    x += 5;
    //Subtração combinada, mesma coisa da soma, pega a mesma variavel e subtrai (x-=1 é x=x-1)
    y -= 4;
    //multiplicação combinada.
    z *= 32;
    //divisão combinada
    a /=2;
    //Resto de divisão combinado
    c %=4;
    Console.WriteLine("esses são os valores de: x = "+x+", y = "+y+", z = "+z+", a = "+a+" e c = "+c);

    //Incremento e decremento
    //Pré incremento e Pré Decremento, o valor é adicionado antes da variavel ser lida pela primeira vez.
    Console.WriteLine($"O novo valor de x é= {++x}, e o novo valor de y é {--y}."); 
    //Pós incremento e pós decremento, o valor é adicionado ou subtraido depois da variável ser lida pela primeira vez.
    Console.WriteLine($"O novo valor de z ({z++}), e o novo valor de a ({a--}), podem ser analisados aqui: z="+z+" e a="+a);

    //Operações de potenciação e radição.
    //Radição quadratica, realiza a raiz quadrada de um número.
    q = Math.Sqrt(9);
    //Potenciação, eleva um número a outro.
    w = Math.Pow(4,2);
    //Radição, fazendo dessa forma, podemos realizar a raiz cubica ou maior de um número.
    e = Math.Pow(125, (1.0/3));

    Console.WriteLine("Dessa forma, os valores de Q, W e E são, respectivamente: "+q+", "+w+" e "+e);

    //Percentual.
    r = 0.10*z;

    Console.WriteLine("r= "+r);

    //área de uma circunferencia
    //A=PI*R²
    area = Math.PI * Math.Pow(raio, 2);

    //Equação de segundo grau
    //f(x) = 4x² + 7x - 2
    fx = 4 * Math.Pow(x, 2) + 7*x - 2;

    //Conversão Explicita
    //int x=5, y = 2;
    //float f = (float)x/y;
    //Double d= x/(Double)y;

    Console.WriteLine("Area é igual a: "+area+" e F(x) é igual a: "+fx);

    //Para imprimir mais casas decimais, é só ao adicionar uma variavel em uma writeline, adicionar um comando ":0.00" para duas casas decimais e assim por diante, por exemplo. 
    //Console.WriteLine("inss é igual a R$ "+INSS:0.00);

    //if, else.

    Console.WriteLine("me informe sua nota:");
    nota = double.Parse(Console.ReadLine());

    if (nota >= 6) {
      Console.WriteLine("Você passou!");
      Console.WriteLine("Parabéns!");
      }
    //operadores ( ==(igualdade)   <(menor)   >(maior)   <=   =>   !=(desigualdade))
    
    else
      Console.WriteLine("Você reprovou");

    //operadores booleanos
    //&& (And) if (nota >= 6 && falta <= 17);
    //|| (or) if (idade >= 60 || salario <= 1000);
    // ! (not) if (!(x==y && a>=b));


    //Switch case
    Console.WriteLine("Digite o numero do mês:");
    mes = int.Parse(Console.ReadLine());
    String mesStr;

    switch (mes)
    {
    case 1: mesStr = "Janeiro";
      break;
    case 2: mesStr = "Fevereiro";
      break;
    case 3: mesStr = "Março";
      break;
    case 4: mesStr = "Abril";
      break;
    case 5: mesStr = "Maio";
      break;
    case 6: mesStr = "Junho";
      break;
    case 7: mesStr = "Julho";
      break;
    case 8: mesStr = "Agosto";
      break;
    case 9: mesStr = "Setembro";
      break;
    case 10: mesStr = "Outubro";
      break;
    case 11: mesStr = "Novembro";
      break;
    case 12: mesStr = "Dezembro";
      break;
    default: mesStr = "Mes invalido";
      break;
    }
    Console.WriteLine(mesStr);

    // while, do while, for
    //ex a ser repetido

    Console.WriteLine("Digite um número: ");
    numero = Double.Parse(Console.ReadLine());
    while (numero > 0)
    {
    raiz = Math.Sqrt(numero);
    Console.WriteLine("a raiz quadrada de:"+numero+" é "+raiz);
    Console.WriteLine("Digite um número: ");
    numero = Double.Parse(Console.ReadLine());
    }    
    Console.ReadKey();
  }
}
