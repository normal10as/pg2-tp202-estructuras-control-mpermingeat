Module ejercicio210

    Sub Main()
        Dim a As Int16
        Dim b As Int16
        Dim x As Int16

        Console.WriteLine("Ingrese un numero entero")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese un numero entero mayor al anterior")
        b = Console.ReadLine()
        Console.WriteLine(" ")
        x = a
        Do


            If (x Mod 5 = 0) Then
                Console.WriteLine("loop do while: " & x)
            End If
            x += 1
        Loop While x < b

        x = a
        Do

            If (x Mod 5 = 0) Then
                Console.WriteLine("loop do until: " & x)
            End If
            x += 1
        Loop Until x = b




    End Sub
End Module
