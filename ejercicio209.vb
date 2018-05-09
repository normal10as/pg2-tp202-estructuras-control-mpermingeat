Imports Microsoft.VisualBasic
Imports System


Module ejercicio209
    Sub Main()
        Dim a As Decimal


        Console.WriteLine("Ingrese la opcion deseada.")
        Console.WriteLine("")
        Console.WriteLine("Para convertir metros ingrese       1 .")
        Console.WriteLine("Para convertir centimetros ingrese  2 .")
        Console.WriteLine("Para convertir pies ingrese         3 .")
        Console.WriteLine("Para convertir yardas ingrese       4 .")
        Console.WriteLine("Para convertir pulgadas ingrese     5 .")
        a = Console.ReadLine()
        Dim metros As Decimal
        Dim centi As Decimal
        Dim pies As Decimal
        Dim yardas As Decimal
        Dim pulgadas As Decimal

        Select Case a
            Case 1
                Console.WriteLine("Ingrese los metros a convertir")
                metros = Console.ReadLine()
                centi = metros * 100
                pulgadas = centi / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                Console.WriteLine(metros & " metros son " & centi & " centimetros.")
                Console.WriteLine(metros & " metros son " & pies & " pies.")
                Console.WriteLine(metros & " metros son " & yardas & " yardas.")
                Console.WriteLine(metros & " metros son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 2
                Console.WriteLine("Ingrese los centimetros a convertir")
                centi = Console.ReadLine()
                metros = centi * 0.01
                pulgadas = centi / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                Console.WriteLine(centi & " centimetros son " & metros & " metros.")
                Console.WriteLine(centi & " centimetros son " & pies & " pies.")
                Console.WriteLine(centi & " centimetros son " & yardas & " yardas.")
                Console.WriteLine(centi & " centimetros son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 3
                Console.WriteLine("Ingrese los pies a convertir")
                pies = Console.ReadLine()
                pulgadas = pies * 12
                centi = pulgadas * 2.54
                metros = centi / 100

                yardas = pies / 3
                Console.WriteLine(pies & " pies son " & centi & " centimetros.")
                Console.WriteLine(pies & " pies son " & metros & " metros.")
                Console.WriteLine(pies & " pies son " & yardas & " yardas.")
                Console.WriteLine(pies & " pies son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 4
                Console.WriteLine("Ingrese las yardas a convertir")
                yardas = Console.ReadLine()
                pies = yardas * 3
                pulgadas = pies * 12
                centi = pulgadas * 2.54
                metros = centi / 100

                Console.WriteLine(yardas & " yardas son " & centi & " centimetros.")
                Console.WriteLine(yardas & " yardas son " & metros & " metros.")
                Console.WriteLine(yardas & " yardas son " & pies & " pies.")
                Console.WriteLine(yardas & " yardas son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 5
                Console.WriteLine("Ingrese las pulgadas a convertir")
                pulgadas = Console.ReadLine()

                pies = pulgadas / 12
                centi = pulgadas * 2.54
                metros = centi / 100
                yardas = pies / 3
                Console.WriteLine(pulgadas & " pulgadas son " & centi & " centimetros.")
                Console.WriteLine(pulgadas & " pulgadas son " & metros & " metros.")
                Console.WriteLine(pulgadas & " pulgadas son " & pies & " pies.")
                Console.WriteLine(pulgadas & " pulgadas son " & yardas & " yardas.")
                Console.WriteLine(" ")
            Case Else
                Console.WriteLine("Sos un pelotudo te dije q del 1 al 5 .")
        End Select



    End Sub
End Module
