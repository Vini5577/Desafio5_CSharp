using System;  

class minhaClasse { 

  static void Main(string[] args) {   

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if( salario < 0) { 
      reajuste = -1;

    } else if ( salario <= 400 ) { 
      percentual = 15; 
      reajuste =  (115 * salario)/100; 
      novoSalario =  reajuste; 


    } else if ( salario <= 800) { 
      percentual =   12; 
      reajuste =  (112 * salario)/100;         
      novoSalario = reajuste; 

    } else if (salario <= 1200) { 
      percentual = 10; 
      reajuste =  (110 * salario)/100; 
      novoSalario = reajuste; 

    } else if (salario  <= 2000) { 
      percentual =  7; 
      reajuste = (107 * salario)/100; 
      novoSalario =  reajuste; 

    } else { 
      percentual = 4; 
      reajuste = (104 * salario)/100; 
      novoSalario = reajuste; 

    } 

    Console.WriteLine($"Novo salario: {reajuste.ToString("F")}"); 
    Console.WriteLine($"Reajuste ganho: {(reajuste - salario).ToString("F")}"); 
    Console.WriteLine($"Em percentual: {percentual} %"); 

  } 
}