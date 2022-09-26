

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;


Console.WriteLine("Percorrendo o array com o FOR");

for (int contador =0;contador < arrayInteiros.Length;contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}



//forma alternativa de percorrer uma lista sem um contador
Console.WriteLine("Percorrendo o array com o FOREACH");

foreach (int valor in arrayInteiros) // a variável "valor" recebe os números que estão em arrayInteiros em cada interação
{
    Console.WriteLine(valor);  
}

//ter o mesmo retorno ao exemplo 1, porém usando foreach com uma var contador


Console.WriteLine("Percorrendo o array com o FOREACH");
int contadorForeach = 0;
foreach (int valor2 in arrayInteiros) 
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor2}"); 
    contadorForeach++;
}
