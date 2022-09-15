'Xavier Hoskins
'RCET 0265
'Fall 2022
'Multiplication Table
'https://github.com/hoskxavi/MultiplicationTable

Option Explicit On
Option Strict On

Imports System
Imports System.Net.Http.Headers

Module Multiply
    Sub Main()
        Dim userInput As String
        Dim numberOfColumns As Integer
        Dim retry As Boolean = False
        Dim numbers As Integer = 1
        Dim temp As Integer
        Dim row As String

        Do While retry = False 'loop to ensure only numbers are valid entries

            Console.Write("Please enter a number: ")
            userInput = Console.ReadLine()

            Try
                numberOfColumns = CInt(userInput)
                retry = True
            Catch ex As Exception
                Console.Write("You entered ")
                Console.WriteLine(userInput)
            End Try

        Loop

        'write out the table size
        Console.Write("Enjoy your ")
        Console.Write(numberOfColumns)
        Console.Write(" x ")
        Console.Write(numberOfColumns)
        Console.WriteLine(" multiplication table")
        Console.WriteLine()

        For i = 1 To numberOfColumns 'for loop to build the table

            For numbers = 1 To numberOfColumns
                temp = (numbers * i)
                row = CStr(temp)
                row = row.PadLeft(8)
                Console.Write(row)
            Next

            'add space after each row
            Console.WriteLine()

        Next

    End Sub
End Module
