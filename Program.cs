




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

foreach (int valor in arrayInteiros) // a var "valor" recebe os números que estão em arrayInteiros em cada interação
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


//Redimensionando um Array

Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

/*Após isso o array em questão passa a ter o dobro do tamanho original
É possível também reduzir o tamanho do mesmo usando o mesmo código
"Um array nasce e morre com uma capacidade fixa", então o que o resize faz é criar uma cópia
do array antigo porém com uma capacidade maior, ele também copia todos os elementos do array antigo para o novo. 
*/

//Copiar um Array para outro

int[] arrayInteirosDobrado =  new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros,arrayInteirosDobrado,arrayInteiros.Length);

/* Faz praticamente o que o resize faz, porém o copy transfere os elementos para uma outra
variável na qual foi declarada antes.
*/
