using System;

namespace Zajecia2
{
	public class Program
	{
		static void z1()
		{
			Console.WriteLine("Podaj rok: ");
			int rok = Convert.ToInt32(Console.ReadLine());
			if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
			{
				Console.WriteLine("To jest rok przestepny");
			}
			else
			{
				Console.WriteLine("To nie rok przestepny");
			}
		}

		static void z2()
		{
			Console.Write("Podal 1 liczbe: ");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Podal 2 liczbe: ");
			int n2 = Convert.ToInt32(Console.ReadLine());
			if (n1 % n2 == 0)
			{
				Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}", n2, n1);
			}
			else
			{
				Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", n2, n1);
			}
		}

		static void z3()
		{
			float[] nums = new float[3];
			Console.Write("Podaj 1 liczbe: ");
			nums[0] = float.Parse(Console.ReadLine());
			Console.Write("Podaj 2 liczbe: ");
			nums[1] = float.Parse(Console.ReadLine());
			Console.Write("Podaj 3 liczbe: ");
			nums[2] = float.Parse(Console.ReadLine());
			float max = nums[0];
			for (int i = 1; i < 3; i++)
			{
				if (nums[i] > max)
					max = nums[i];
			}

			Console.WriteLine("Najwieksza liczba to: {0}", max);
		}

		static void z4()
		{
			Console.Write("Podaj znak operacji(+,-,*,/): ");
			char operand = Convert.ToChar(Console.ReadKey());
			Console.Write("Podaj 1 liczbe: ");
			float n1 = float.Parse(Console.ReadLine());
			Console.Write("Podaj 2 liczbe: ");
			float n2 = float.Parse(Console.ReadLine());
			if (operand == '+')
				Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
			else if (operand == '-')
				Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
			else if (operand == '*')
				Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
			else if (operand == '/')
				Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
		}

		static void z5()
		{
			Console.Write("Podaj a: ");
			float a = float.Parse(Console.ReadLine());
			Console.Write("Podaj b: ");
			float b = float.Parse(Console.ReadLine());
			Console.Write("Podaj c: ");
			float c = float.Parse(Console.ReadLine());
			float delta = MathF.Pow(b, 2) - 4 * a * c;
			if (delta > 0)
				Console.Write("x1 = {0}, x2 = {1}", (-b - MathF.Sqrt(delta)) / (2 * a), (-b + MathF.Sqrt(delta)) / (2 * a));
			else if (delta == 0)
				Console.Write("x0 = {0}", (-b) / (2 * a));
			else
				Console.Write("Rownanie nie ma pierwiastkow rzeczywistych");
		}

		static void z6_a()
		{
			Console.Write("Podaj wage w kg: ");
			float weight = float.Parse(Console.ReadLine());
			Console.Write("Podaj wzrost w metrach: ");
			float height = float.Parse(Console.ReadLine());
			float bmi = weight / (height * height);
			if (bmi < 18.5f)
				Console.WriteLine("Niedowaga");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("Waga prawidlowa");
			else
				Console.WriteLine("Nadwaga");
		}

		static void z6_b()
		{
			Console.Write("Podaj wage w kg: ");
			float weight = float.Parse(Console.ReadLine());
			Console.Write("Podaj wzrost w metrach: ");
			float height = float.Parse(Console.ReadLine());
			float bmi = weight / (height * height);
			if (bmi < 16)
				Console.WriteLine("Dorazna niedowaga");
			else if (bmi >= 16 && bmi < 17)
				Console.WriteLine("Przecietna niedowaga");
			else if (bmi >= 17 && bmi < 18.5f)
				Console.WriteLine("Niska niedowaga");
			else if (bmi >= 18.5f && bmi < 25)
				Console.WriteLine("Waga prawidlowa");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("Nadwaga");
			else if (bmi >= 30 && bmi < 35)
				Console.WriteLine("Otylosc stopnia I");
			else if (bmi >= 35 && bmi < 40)
				Console.WriteLine("Otylosc stopnia II");
			else
				Console.WriteLine("Otylosc stopnia III");
		}

		static void z7()
		{
			Console.Write("Wpisz numer tygodnia: ");
			int num = Convert.ToInt32(Console.ReadKey());
			switch (num)
			{
				case 1:
					Console.Write("Poniedzialek");
					break;
				case 2:
					Console.Write("Wtorek");
					break;
				case 3:
					Console.Write("Sroda");
					break;
				case 4:
					Console.Write("Czwartek");
					break;
				case 5:
					Console.Write("Piatek");
					break;
				case 6:
					Console.Write("Sobota");
					break;
				case 7:
					Console.Write("Poniedzialek");
					break;
				default:
					Console.Write("Nie ma takiego dnia");
					break;
			}
		}

		static void z8()
		{
			Console.Write("Podaj srednia ocen: ");
			float gpa = float.Parse(Console.ReadLine());
			if ((2f <= gpa) && (gpa <= 3.99f))
			{
				Console.WriteLine("Kwota stypendium: 0 PLN");
			}
			else if ((4f <= gpa) && (gpa <= 4.79f))
			{
				Console.WriteLine("Kwota stypendium: 350 PLN");
			}
			else if ((4.8f <= gpa) && (gpa <= 5f))
			{
				Console.WriteLine("Kwota stypendium: 550 PLN");
			}
		}

		static void z9()
		{
			Console.Write("Wpisz liczbe wierszy: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("a");
			for (int i = 1; i <= num; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine("b");
			for (int i = 1; i <= num; i++)
			{
				for (int j = num - i; j >= 0; j--)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine("c");
			for (int i = 1; i <= num; i++)
			{
				for (int s = num - i; s > 0; s--)
				{
					Console.Write(" ");
				}

				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine("d");
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					if (j == 0 || j == num - 1 || i == 0 || i == num - 1)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(' ');
					}
				}

				Console.WriteLine();
			}
		}

		static int silnia(int n)
		{
			if (n == 0 || n == 1)
				return 1;
			else
				return n * silnia(n - 1);
		}

		static void z10()
		{
			Console.Write("Podaj n: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.Write(silnia(num));
		}

		static void z11()
		{
			int sum = 0;
			int i = 0;
			for (; sum < 100; i++)
			{
				sum += i;
			}

			Console.Write("nalezy dodac {0} liczb", i);
		}

		static void z12()
		{
			int num = -1;
			int sum = 0;
			while (num != 0)
			{
				num = Convert.ToInt32(Console.ReadLine());
				sum += num;
			}

			Console.Write("suma liczb wynosi: {0}", sum);
		}

		static void z13()
		{
			int res = 1;
			Console.Write("podaj n: ");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 2; i <= n; i++)
			{
				if ((i % 2) == 0)
				{
					res -= i;
				}
				else
				{
					res += i;
				}
			}

			Console.Write("suma szeregu wynosi {0}", res);
		}

		static void z14()
		{
			long sum = 0;
			Console.Write("wpisz n: ");
			long n = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("liczby doskonale:");
			for (long i = 2; i <= n; i++)
			{
				for (long j = 1; j < i; j++)
				{
					if (i % j == 0)
					{
						sum += j;
					}
				//if(sum > i) {break;}
				}

				if (sum == i)
				{
					Console.WriteLine(sum);
				}

				sum = 0;
			}
		}

		static void z15()
		{
			int[] monety = {1, 2, 5};
			int num = 0;
			for (int z1 = 0; z1 <= 10; z1++)
				for (int z2 = 0; z2 <= 5; z2++)
					for (int z5 = 0; z5 <= 2; z5++)
						if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
						{
							Console.WriteLine("zlowotki = {0} dwozlotowki = {1} pieciozlotowki = {2}", z1, z2, z5);
							num++;
						}

			Console.Write("calkowita ilosc sposobow: {0}", num);
		}

		public static void Main()
		{
			z1();
			z2();
			z3();
			z4();
			z5();
			z6_a();
			z6_b();
			z7();
			z8();
			z9();
			z10();
			z11();
			z12();
			z13();
			z14();
			z15();
		}
	}
}
