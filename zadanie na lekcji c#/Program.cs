using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_na_lekcji_c_{
    internal class Program{
        static void Main(string[] args){
            // zad 1
            int[] primeBin = new int[115];
            primeBin[0] = 3;
            for (int i = 1; i < primeBin.Length; i++){
                primeBin[i] = primeBin[i - 1] + 4;
            }

            foreach (int num in primeBin){
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // zad 2
            Osoba[] os = new Osoba[5];
            StreamReader sr = new StreamReader("C:\\Users\\uczen\\Desktop\\Project Alkomator\\zadanie na lekcji c#\\zadanie na lekcji c#/osoby.txt");
            string[] S = new string[5];
            int iterator = 0;
            while (!sr.EndOfStream){
                S = sr.ReadLine().Split(';');
                Osoba osoba;
                osoba.firstName = S[0];
                osoba.lastName = S[1];
                osoba.age = int.Parse(S[2]);
                os[iterator] = osoba;
                iterator++;
            }

            foreach (var item in os){
                Console.WriteLine(item.firstName + " " + item.lastName + " " + item.age);
            }
            Console.WriteLine();

            // zad 3
            Random random = new Random();
            char[] vowels = new char[] { 'e', 'y', 'u', 'i', 'o', 'a' };
            List<string> words = new List<string>(6);
            List<char> VOWELS;

            string word;
            int number;
            for (int i = 0; i < 6; i++){
                word = "";
                VOWELS = vowels.ToList();
                for (int j = 0; j < 6; j++){
                    number = random.Next(0, VOWELS.Count());
                    word += VOWELS[number];
                    VOWELS.RemoveAt(number);
                }
                words.Add(word);
            }
            foreach (string str in words){
                Console.WriteLine(str + " ");
            }
            Console.WriteLine("zad 4");

            // zad 4
            Queue queueOfFIb = new Queue();
            int[] fib = new int[10];
            fib[0] = 1;
            fib[1] = 2;
            for (int i = 2; i < fib.Length; i++){
                fib[i] = fib[i - 1] + fib[i - 2];
                if (fib[i] > 100){
                    break;
                }
            }
            int randomNumber;
            for (int i = 0; i < 4; i++) {
                randomNumber = random.Next(0, fib.Length);
                queueOfFIb.Enqueue(fib[randomNumber]);
            }
            foreach (int num in queueOfFIb){
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            queueOfFIb.Dequeue();
            queueOfFIb.Dequeue();

            foreach (int num in queueOfFIb){
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("zad 5");

            // zad 5
            Stack primeStack = new Stack();
            int iter = 0;
            for (int i = 10; i < 100; i++){
                if (isPrime(i)){
                    primeStack.Push(i);
                    iter++;
                }
                if (iter == 5){
                    break;
                }
            }
            foreach (int num in primeStack){
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            primeStack.Pop();
            primeStack.Pop();
            primeStack.Pop();

            foreach (int num in primeStack)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
            // zad 6
            Dictionary<int, List<int> > graf = new Dictionary<int, List<int> >();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++){
                graf.Add(i, new List<int>());
            }
            int k = int.Parse(Console.ReadLine());
            
            string[] Liczby;
            int a, b;
            for (int i = 0; i < k; i++){
                Liczby = Console.ReadLine().Split();
                a = int.Parse(Liczby[0]);
                b = int.Parse(Liczby[1]);
                graf[a].Add(b);
                graf[b].Add(a);
            }

foreach (var item in graf){
    Console.WriteLine(item.Key + " ");
    foreach (var item2 in graf){
        Console.WriteLine(item + " ");
    }
    Console.WriteLine();
}
            Console.ReadKey();
        }
        public static bool isPrime(int num){
            for (int i = 2; i < num; i++){
                if (num % i == 0){
                    return false;
                }
            }
            return true;
        }
    }
    // zad 2
    struct Osoba{
        public string firstName;
        public string lastName;
        public int age;
    }
}
