﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
4. Detreminati daca un an y este an bisect. 
5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
9. Afisati toti divizorii numarului n. 
10. Test de primalitate: determinati daca un numar n este prim.
11. Afisati in ordine inversa cifrele unui numar n. 
12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
13. Determianti cati ani bisecti sunt intre anii y1 si y2.
14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
        -O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        -O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        -O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma ""numarul este mai mare sau egal decat x ? "". ");
            Console.WriteLine("Numarul problemei pe care vrei sa o rezolvi: ");
            int nrProblema = int.Parse(Console.ReadLine());
            switch (nrProblema)
            {
                case 1: Console.Clear(); Problema1();break;
                case 2: Console.Clear(); Problema2();break;
                case 3: Console.Clear(); Problema3();break;
                case 4: Console.Clear(); Problema4();break;
                case 5: Console.Clear(); Problema5();break;
                case 6: Console.Clear(); Problema6();break;
                case 7: Console.Clear(); Problema7();break;
                case 8: Console.Clear(); Problema8();break;
                case 9: Console.Clear(); Problema9();break;
                case 10:Console.Clear();Problema10();break;
                case 11:Console.Clear();Problema11();break;
                case 12:Console.Clear();Problema12();break;
                case 13:Console.Clear();Problema13();break;
                case 14:Console.Clear();Problema14();break;
                case 15:Console.Clear();Problema15();break;
                case 16:Console.Clear();Problema16();break;
                case 17:Console.Clear();Problema17();break;
                case 18:Console.Clear();Problema18();break;
                case 19:Console.Clear();Problema19();break;
                case 20:Console.Clear();Problema20();break;
                case 21:Console.Clear();Problema21();break;
                default:
                    break;
            }
        }

        private static void Problema1()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
            Console.Write("a: ");double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");double b = double.Parse(Console.ReadLine());
            double solutie = -b / a;
            Console.WriteLine($"solutia este {solutie}");
        }

        private static void Problema2()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
            Console.Write("a: ");double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");double c = double.Parse(Console.ReadLine());
            if(a !=0 && b!=0 && c!=0)
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Ecuatia nu are solutii reale");
                else if(delta == 0)
                    Console.WriteLine($"Ecuatia are 2 solutii reale egale {-b/(2*a)}");
                else Console.WriteLine($"Ecuatia are solutiile {{{(-b+Math.Sqrt(delta))/(2*a)},{(-b - Math.Sqrt(delta)) / (2 * a)} }}");
            }
            else
            switch (a)
            {
                case 0:
                    double solutie = -c / b;
                    Console.WriteLine($"solutia este {solutie}");
                    break;
                default:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine($"solutia este {Math.Sqrt(-c / a)}");
                            break;
                        default:
                            switch (c)
                            {
                                case 0:
                                    Console.WriteLine($"solutia este {{0, {Math.Sqrt(-b / a)}}}");
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private static void Problema3()
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            if(n%k==0)
                Console.WriteLine($"Numarul {n} se divide cu {k}");
            else
                Console.WriteLine($"Numarul {n} nu se divide cu {k}");
        }

        private static void Problema4()
        {
            Console.WriteLine("Detreminati daca un an y este an bisect.");
            Console.Write("Anul: ");
            int anul = int.Parse(Console.ReadLine());
            if((anul % 4 == 0 && anul % 100 != 0) || anul % 400 == 0)
                Console.WriteLine($"Anul {anul} este un an bisect.");
            else
                Console.WriteLine($"Anul {anul} nu este un an bisect.");
        }

        private static void Problema5()
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
            Console.Write("Numarul: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int kk = k;
            while (n > 0)
            {
                k--;
                if (k == 0)
                {
                    Console.WriteLine($"A {kk}-a cifra este {n % 10}");
                    break;
                }
                n /= 10;
            }
        }

        private static void Problema6()
        {
            Console.WriteLine("Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            if(a+b>c && a+c > b && b+c>a)
                Console.WriteLine($"Numerele {a}, {b} si {c} pot fi lungimile laturilor unui triunghi");
            else    
                Console.WriteLine($"Numerele {a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi");    
        }

        private static void Problema7()
        {
            Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\nb = {b}");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Problema8()
        {
            Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Swap_restrictionat(ref a, ref b);
            Console.WriteLine($"a = {a}\nb = {b}");
        }

        private static void Swap_restrictionat(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }

        private static void Problema9()
        {
            Console.WriteLine("Afisati toti divizorii numarului n. ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
                if (n % i == 0)
                    if (i<n)
                        Console.Write($"{i}, ");
                    else
                        Console.Write($"{i}.\n");
        }

        private static void Problema10()
        {
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    prim = false;
            if(prim)
                Console.WriteLine($"Numarul {n} este prim");
            else
                Console.WriteLine($"Numarul {n} nu este prim");
        }

        private static void Problema11()
        {
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                Console.Write($"{n%10} ");
                n /= 10;
            }
        }

        private static void Problema12()
        {
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    count++;
            Console.WriteLine($"In intervalul [{a},{b}] sunt {count} numere divizibile cu {n}");
        }

        private static void Problema13()
        {
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = y1; i <= y2; i++)
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    count++;
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {count} ani bisecti");
        }

        private static void Problema14()
        {
            Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int o = Oglindit(n);
            if(o==n)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        private static int Oglindit(int n)
        {
            int o = 0;
            while(n>0)
            {
                o = o * 10 + n % 10;
                n /= 10;
            }
            return o;
        }

        private static void Problema15()
        {
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
                Swap(ref a, ref b);
            if (a > c)
                Swap(ref a, ref c);
            if (b > c)
                Swap(ref b, ref c);
            Console.WriteLine($"{a}, {b}, {c}.");
        }

        private static void Problema16()
        {
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());
            if (a > b)
                Swap(ref a, ref b);
            if (a > c)
                Swap(ref a, ref c);
            if (a > d)
                Swap(ref a, ref d);
            if (a > e)
                Swap(ref a, ref e);
            if (b > c)
                Swap(ref b, ref c);
            if (b > d)
                Swap(ref b, ref d);
            if (b > e)
                Swap(ref b, ref e);
            if (c > d)
                Swap(ref c, ref d);
            if (c > e)
                Swap(ref c, ref e);
            if (d > e)
                Swap(ref d, ref e);
            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}.");
        }

        private static void Problema17()
        {
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int cmmdc = Cmmdc(a, b);
            int cmmmc = Cmmmc(a, b);
            Console.WriteLine($"Cel mai mare divizor comun este {cmmdc}\nCel mai mic multiplu comun este {cmmmc}");
        }

        private static int Cmmmc(int a, int b)
        {
            int n = a;
            int m = b;
            while (n != m)
            {
                if (n < m)
                    n += a;
                else if (n > m)
                    m += b;
            }
            return n;
        }

        private static int Cmmdc(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else if (a < b)
                    b -= a;
            }
            return a;
        }

        private static void Problema18()
        {
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while(n > 1)
            {
                int nr = 0;
                while(n%i==0)
                {
                    n /= i;
                    nr++;
                }
                if (nr > 0)
                {
                    if (n == 1)
                        Console.WriteLine($"{i}^{nr}.");
                    else Console.Write($"{i}^{nr} x ");
                }
                i++;
            }
        }

        private static void Problema19()
        {
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int ncopy = n;
            int a = 0; 
            int b = 0;
            bool ok = true;
            while(n>0)
            {
                if (a == 0)
                    a = n % 10;
                else if (b == 0)
                    b = n % 10;
                if (n % 10 != a && n % 10 != b)
                    ok = false;
                n /= 10;
            }
            if(ok)
                Console.WriteLine($"Numarul {ncopy} e format doar cu 2 cifre");
            else
                Console.WriteLine($"Numarul {ncopy} NU e format doar cu 2 cifre");
        }

        private static void Problema20()
        {
            Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = n / m;
            parteFract = n % m;
            Console.Write($"{parteInt}");
            if (parteFract > 0)
                Console.Write(",");
            int rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            rest = parteFract * 10 % m;
            while (rest > 0)
            {
                cifre.Add(parteFract * 10 / m);
                rest = parteFract * 10 % m;
                if (!resturi.Contains(rest))
                    resturi.Add(rest);
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            }
            if (periodic == false)
                for (int i = 0; i < cifre.Count; i++)
                    Console.Write($"{cifre[i]}");
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        private static void Problema21()
        {
            Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x ?\".");
            Random rand = new Random();
            int n = rand.Next(1, 1025);
            int x = int.Parse(Console.ReadLine());
            if (n == x)
                Console.WriteLine("Ai ghicit!");
            else Console.Write($"Numarul este mai mare sau egal decat {x} ?\n");
            if (n>x)
                Console.WriteLine("Da!");
            else Console.WriteLine("Nu!");
            while (x != n)
            {
                x = int.Parse(Console.ReadLine());
                if (n == x)
                {
                    Console.WriteLine("Ai ghicit!");
                    break;
                }
                Console.WriteLine($"Numarul este mai mare decat {x}?");
                if (n > x)
                    Console.WriteLine("Da!");
                else Console.WriteLine("Nu!");
            }
        }
    }
}
