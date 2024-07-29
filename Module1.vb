Module Module1

    Sub Main()
        Dim num1, num2 As Double
        Console.WriteLine("BIENVENIDO A CALCULADORA EN CONSOLA")
        Console.WriteLine("-----------------------------------")
        Console.Write("Por favor Ingresa el 1er Nùmero: ")
        num1 = Convert.ToDouble(Console.ReadLine())
        Console.Write("Por favor Ingresa el 2do. Nùmero: ")
        num2 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Operaciones Disponibles: ")
        Console.WriteLine(" +  -> SUMA")
        Console.WriteLine("El Resultado de la Suma es: " & (num1 + num2))
        Console.WriteLine(" -  -> RESTA")
        Console.WriteLine("El Resultado de la Resta es: " & (num1 - num2))
        Console.WriteLine(" *  -> MULTIPLICACIÓN")
        Console.WriteLine("El Resultado de la Multiplicación: " & (num1 * num2))
        Console.WriteLine(" /  -> DIVISIÓN")
        Console.WriteLine("El Resultado de la Divisiòn es: " & (num1 / num2))
        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
