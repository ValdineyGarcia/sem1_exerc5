double lado1, lado2, lado3;
Console.WriteLine("Análise de triângulos! Informe o lado 1:");
lado1 = double.Parse(Console.ReadLine());
Console.WriteLine(" Informe o lado 2:");
lado2 = double.Parse(Console.ReadLine());
Console.WriteLine(" Informe o lado 3:");
lado3 = double.Parse(Console.ReadLine());
if (lado1 + lado2 > lado3 && lado3 + lado2 > lado1 && lado3 + lado1 > lado2) {
Console.WriteLine("É um triângulo!");
        if (lado1 == lado3 && lado2 == lado1) {
    Console.WriteLine("Triângulo Equilátero.");
    }
        else if (lado1 ==lado2 || lado2 == lado3 || lado1 == lado3){
    Console.WriteLine("Triângulo Isósceles.");
    }
        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3){
        Console.WriteLine("Triângulo Escaleno.");
    }
    }
else{
    Console.WriteLine("As medidas não formam um triângulo.");
}