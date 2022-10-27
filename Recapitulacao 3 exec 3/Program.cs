/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo */

int num, qtAlc = 0, qtGas = 0, qtDis = 0;

Console.WriteLine("Informe  combustível abastecido :  1.Álcool 2.Gasolina 3.Diesel 4.Fim");
num = int.Parse(Console.ReadLine());

while (num != 4)
{
    if (num == 1)
    {
        qtAlc++;
    }
    else if (num == 2)
    {
        qtGas++;
    }
    else if(num == 3)
    {
        qtDis++;
    }
        Console.WriteLine("Informe  combustível abastecido :  1.Álcool 2.Gasolina 3.Diesel 4.Fim");
        num = int.Parse(Console.ReadLine());
    }
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + qtAlc);
Console.WriteLine("Gasolina: " + qtGas);
Console.WriteLine("Diesel: " + qtDis);