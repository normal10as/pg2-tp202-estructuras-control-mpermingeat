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
        Do While x <= b


            If (x Mod 5 = 0) Then
                Console.WriteLine("do while loop : " & x)
            End If
            x += 1
        Loop
        Console.WriteLine("-----------------------------")
        x = a
        Do Until x = (b + 1)

            If (x Mod 5 = 0) Then
                Console.WriteLine("do until loop : " & x)
            End If
            x += 1
        Loop
        Console.WriteLine("-----------------------------")
        x = a

        Do


            If (x Mod 5 = 0) Then
                Console.WriteLine("do loop while: " & x)
            End If
            x += 1
        Loop While x <= b
        Console.WriteLine("-----------------------------")
        x = a
        Do

            If (x Mod 5 = 0) Then
                Console.WriteLine("do loop until: " & x)
            End If
            x += 1
        Loop Until x = (b + 1)
        Console.WriteLine("-----------------------------")
        x = a
        For y As Int16 = a To b

            If (y Mod 5 = 0) Then
                Console.WriteLine("for: " & y)
            End If

        Next


    End Sub
End Module
