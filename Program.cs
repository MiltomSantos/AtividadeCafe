using System;
using System.Linq;

namespace AtividadeCafe;

public static class Program
{
	public static double moneykey;
	public static void Main()
	{
		double money;
		string cafe;
		string pro1="Café expresso",pro2="Capuccino",pro3="Mocaccino", pro4="Água quente";
		double pre1=3.00, pre2=4.50, pre3=6.00, pre4=1.00;
		
		Console.WriteLine("Por favor insira o seu dinheiro para continuarmos");
		money=double.Parse(Console.ReadLine());
		
		if(money<0){
		   Console.WriteLine("Comando invalido");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		moneykey = money + moneykey;
		
		Console.WriteLine("Digite o numero referente ao produto que deseja:");
		Console.WriteLine($"'1'{pro1} - R$ {pre1}");
		Console.WriteLine($"'2'{pro2} - R$ {pre2}");
		Console.WriteLine($"'3'{pro3} - R$ {pre3}");
		Console.WriteLine($"'4'{pro4} - R$ {pre4}");
		cafe=Console.ReadLine();
		
		if(cafe!="1" && cafe!="2" && cafe!="3" && cafe!="4"){
		   Console.WriteLine("Você digitou um numero invalido");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(cafe=="1"){
		   if(moneykey<pre1){
		      Console.WriteLine("Você não tem saldo suficiente");
			  Console.WriteLine($"Falta {pre1-moneykey} de saldo para comprar esse produto");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine($"Você comprou {pro1}, e seu saldo é {moneykey-pre1} reais");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
        if(cafe=="2"){
		   if(moneykey<pre2){
		      Console.WriteLine("Você não tem saldo suficiente");
			  Console.WriteLine($"Falta {pre2-moneykey} de saldo para comprar esse produto");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine($"Você comprou {pro2}, e seu saldo é {moneykey-pre2} reais");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(cafe=="3"){
		   if(moneykey<pre3){
		      Console.WriteLine("Você não tem saldo suficiente");
			  Console.WriteLine($"Falta {pre3-moneykey} de saldo para comprar esse produto");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine($"Você comprou {pro3}, e seu saldo é {moneykey-pre3} reais");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(cafe=="4"){
		   if(moneykey<pre4){
		      Console.WriteLine("Você não tem saldo suficiente");
			  Console.WriteLine($"Falta {pre4-moneykey} de saldo para comprar esse produto");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine($"Você comprou {pro4}, e seu saldo é {moneykey-pre4} reais");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		Console.ReadKey();

	}
}
