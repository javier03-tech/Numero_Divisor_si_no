Module MainModule
    Sub Main()
        ' Datos de entrada
        Console.Write("Ingrese el primer número: ")
        Dim num1 As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo número: ")
        Dim num2 As Integer = Integer.Parse(Console.ReadLine())

        ' Verificar si num1 es divisor de num2
        If num2 Mod num1 = 0 Then
            Console.WriteLine(num1 & " es divisor de " & num2)
        Else
            Console.WriteLine(num1 & " no es divisor de " & num2)
        End If

        ' Datos del desarrollador
        Console.WriteLine("Desarrollado por: Javier Alexander Naranjo Moz, NM0463012022")

        Console.ReadLine() ' Esperar a que el usuario presione Enter
    End Sub
End Module
