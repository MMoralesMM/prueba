Module Module1

    Sub Main()
        Dim peso, altura, imc As Double

        Console.Write("Ingrese su peso en kilogramos: ")
        peso = CDbl(Console.ReadLine())

        Console.Write("Ingrese su altura en centímetros: ")
        altura = CDbl(Console.ReadLine()) / 100

        imc = peso / (altura * altura)

        Console.WriteLine("Su índice de masa corporal es: {0:F1}", imc)

        If imc < 18.5 Then
            Console.WriteLine("Bajo peso")
        ElseIf imc < 25 Then
            Console.WriteLine("Peso normal")
        ElseIf imc < 30 Then
            Console.WriteLine("Sobrepeso")
        Else
            Console.WriteLine("Obesidad")
        End If
        'guardar
        Console.ReadKey()
    End Sub

End Module
