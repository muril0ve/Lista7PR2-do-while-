using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int p;
            Console.WriteLine("qual o programa que você deseja executar ? ");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:

                    int numdeprod, prec, tot = 0;

                    do
                    {

                        Console.WriteLine("qual a quantidade desse produto ");
                        numdeprod = int.Parse(Console.ReadLine());
                        if (numdeprod == 0)
                        {
                            break;
                        }
                        Console.WriteLine("qual o preço do produto: ");
                        prec = int.Parse(Console.ReadLine());

                        tot = prec * numdeprod + tot;

                        if (tot == 0)
                        {
                            break;
                        }





                    }
                    while (true);
                    Console.WriteLine("o valor total vai igual a:" + tot);


                    break;

                case 2:


                    double vl, qq, vtt, vm, u, vmm;

                    string nom, nm, nmm;

                    Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");

                    nom = Console.ReadLine();

                    if (nom == "parar")

                    {

                        break;

                    }

                    Console.WriteLine("digite o valor do produto por unidade");

                    vl = double.Parse(Console.ReadLine());

                    Console.WriteLine("digite o a quantidade do produto");

                    qq = double.Parse(Console.ReadLine());

                    vtt = qq * vl;

                    vm = vtt;

                    nm = nom;

                    vmm = vtt;

                    nmm = nom;

                    do

                    {

                        Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");

                        nom = Console.ReadLine();

                        if (nom == "parar")

                        {

                            break;

                        }

                        Console.WriteLine("digite o valor do produto por unidade");

                        vl = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite o a quantidade do produto");

                        qq = double.Parse(Console.ReadLine());

                        vtt = qq * vl;

                        if (vtt > vm)

                        {

                            nm = nom;

                        }

                        if (vtt < vmm)

                        {

                            nmm = nom;

                        }
                        int k = 0;
                        k++;
                    } while (nom != "parar");

                    Console.WriteLine("o produto com maior investimento é: " + nm + " com um investimento de R$" + vm + " e o de menor investimento é: " + nmm + " com um investimento de R$" + vmm);

                    break;

                case 3:

                    double na, pda, pt;

                    Console.WriteLine("quantas avaliações terão neste bimestre?");

                    na = double.Parse(Console.ReadLine());

                    pt = 0;
                    int i = 0;
                    do

                    {

                        Console.WriteLine("qual o peso das avaliações (ex: 3)");

                        pda = double.Parse(Console.ReadLine());

                        pt = pt + pda;
                        i++;

                    }while(i!= 0);


                       pt = pt * 10;

                    if (pt > 100)

                    {

                        Console.WriteLine("\nOs pesos ultrapassam 100%");

                        break;

                    }

                    if (pt == 100)

                    {

                        Console.WriteLine("\nOs pesos resultam em 100%");

                        break;

                    }

                    if (pt > 100)

                    {

                        Console.WriteLine("\nOs pesos nao atingem 100%");

                        break;

                    }

                    break;

                case 4:

                    string estado;

                    Console.WriteLine("qual a sigla do estado");

                    estado = Console.ReadLine();

                    switch (estado)

                    {

                        case "AC":

                            Console.WriteLine("o estado é: Acre");

                            break;

                        case "AL":

                            Console.WriteLine("o estado é: Alagoas");

                            break;

                        case "AP":

                            Console.WriteLine("o estado é: Amapá");

                            break;

                        case "AM":

                            Console.WriteLine("o estado é: Amazonas");

                            break;

                        case "BA":

                            Console.WriteLine("o estado é: Bahia");

                            break;

                        case "CE":

                            Console.WriteLine("o estado é: Ceará");

                            break;

                        case "DF":

                            Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");

                            break;

                        case "ES":

                            Console.WriteLine("o estado é: Espírito Santo");

                            break;

                        case "GO":

                            Console.WriteLine("o estado é: Goiás");

                            break;

                        case "MA":

                            Console.WriteLine("o estado é: Maranhão");

                            break;

                        case "MT":

                            Console.WriteLine("o estado é: Mato Grosso");

                            break;

                        case "MS":

                            Console.WriteLine("o estado é: Mato Grosso do Sul");

                            break;

                        case "MG":

                            Console.WriteLine("o estado é: Minas Gerais");

                            break;

                        case "PA":

                            Console.WriteLine("o estado é: Pará");

                            break;

                        case "PB":

                            Console.WriteLine("o estado é: Paraíba");

                            break;

                        case "PR":

                            Console.WriteLine("o estado é: Paraná");

                            break;

                        case "PE":

                            Console.WriteLine("o estado é: Pernambuco");

                            break;

                        case "PI":

                            Console.WriteLine("o estado é: Piauí");

                            break;

                        case "RJ":

                            Console.WriteLine("o estado é: Rio de Janeiro");

                            break;

                        case "RN":

                            Console.WriteLine("o estado é: Rio Grande do Norte");

                            break;

                        case "RS":

                            Console.WriteLine("o estado é: Rio Grande do Sul");

                            break;

                        case "RO":

                            Console.WriteLine("o estado é: Rondônia");

                            break;

                        case "RR":

                            Console.WriteLine("o estado é: Roraima");

                            break;

                        case "SC":

                            Console.WriteLine("o estado é: Santa Catarina");

                            break;

                        case "SP":

                            Console.WriteLine("o estado é: São Paulo");

                            break;

                        case "SE":

                            Console.WriteLine("o estado é: Sergipe");

                            break;

                        case "TO":

                            Console.WriteLine("o estado é: Tocantins");

                            break;

                        default:

                            Console.WriteLine("nao existe estado com essa sigla");

                            break;

                    }

                    break;

                case 5:

                    int m, d;

                    Console.WriteLine("digite o mês");

                    m = int.Parse(Console.ReadLine());

                    switch (m)

                    {

                        case 1:

                            Console.WriteLine("a estação correspondente a este mês é: verão");

                            break;

                        case 2:

                            Console.WriteLine("a estação correspondente a este mês é: verão");

                            break;

                        case 3:

                            Console.WriteLine("qual é o dia?");

                            d = int.Parse(Console.ReadLine());

                            if (d < 20 && d > 1)

                                Console.WriteLine("a estação correspondente a este mês é: verão");

                            if (d >= 20 && d < 31)

                                Console.WriteLine("a estação correspondente a este mês é: outono");

                            break;

                        case 4:

                            Console.WriteLine("a estação correspondente a este mês é: verão");

                            break;

                        case 5:

                            Console.WriteLine("a estação correspondente a este mês é: verão");

                            break;

                        case 6:

                            Console.WriteLine("qual é o dia?");

                            d = int.Parse(Console.ReadLine());

                            if (d < 21 && d > 1)

                                Console.WriteLine("a estação correspondente a este mês é: outono");

                            if (d >= 21 && d < 30)

                                Console.WriteLine("a estação correspondente a este mês é: inverno");

                            break;

                        case 7:

                            Console.WriteLine("a estação correspondente a este mês é: inverno");

                            break;

                        case 8:

                            Console.WriteLine("a estação correspondente a este mês é: inverno");

                            break;

                        case 9:

                            Console.WriteLine("qual é o dia?");

                            d = int.Parse(Console.ReadLine());

                            if (d < 23 && d > 1)

                                Console.WriteLine("a estação correspondente a este mês é: inverno");

                            if (d >= 23 && d < 30)

                                Console.WriteLine("a estação correspondente a este mês é: primavera");

                            break;

                        case 10:

                            Console.WriteLine("a estação correspondente a este mês é: primavera");

                            break;

                        case 11:

                            Console.WriteLine("a estação correspondente a este mês é: primavera");

                            break;

                        case 12:

                            Console.WriteLine("qual é o dia?");

                            d = int.Parse(Console.ReadLine());

                            if (d < 22 && d > 1)

                                Console.WriteLine("a estação correspondente a este mês é: primavera");

                            if (d >= 22 && d < 30)

                                Console.WriteLine("a estação correspondente a este mês é: verão");

                            break;

                        default:

                            Console.WriteLine("o valor digitado é invalido");

                            break;

                    }

                    break;

                case 6:

                    double alt, kg, imc;

                    Console.WriteLine("Digite sua altura (em metros): ");

                    alt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite seu peso (em kilos): ");

                    kg = double.Parse(Console.ReadLine());

                    imc = kg / (alt * alt);

                    if (imc < 18.5)

                    {

                        Console.WriteLine("você está abaixo do peso");

                        break;

                    }

                    if (imc >= 18.5 && imc <= 24.9)

                    {

                        Console.WriteLine("você está no peso comum");

                        break;

                    }

                    if (imc >= 25 && imc <= 29.9)

                    {

                        Console.WriteLine("você está acima do peso");

                        break;

                    }

                    if (imc >= 30 && imc < 34.9)

                    {

                        Console.WriteLine("você está com obesidade grau 1");

                        break;

                    }

                    if (imc >= 35 && imc < 39.9)

                    {

                        Console.WriteLine("você está com obesidade grau 2");

                        break;

                    }

                    if (imc >= 40)

                    {

                        Console.WriteLine("você está com obesidade grau 3");

                        break;

                    }

                    break;

                case 7:

                    int num;

                    Console.WriteLine("digite um numero");

                    num = int.Parse(Console.ReadLine());
                    int b = 1;
                    do

                    {
                        b++;
                        if (num % b == 0)

                            Console.WriteLine(i);

                        else

                            i++;

                    }
                    while (b < num);

                    break;

                default:

                    Console.WriteLine("Número inválido");

                    break;

            }

        }

    }

}