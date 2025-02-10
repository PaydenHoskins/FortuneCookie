'Payden Hoskins
'Spring 2025
'RCET2265
'SayMyName
'https://github.com/PaydenHoskins/FortuneCookie.git

Option Explicit On
Option Strict On

Module FortuneCookie

    Sub Main()
        Randomize(DateAndTime.Now.Millisecond)
        For i = 1 To 1
            Select Case RandomNumber()
                Case 1
                    Console.WriteLine("Don't hold onto things. that require a tight grip.")
                Case 2
                    Console.WriteLine("I didn't come this far. to only come this far.")
                Case 3
                    Console.WriteLine("Vulnerability sounds like faith. and looks like courage.")
                Case 4
                    Console.WriteLine("And into the forest I go, to lose my mind and find my soul.")
                Case 5
                    Console.WriteLine("Look how far you've come.")
                Case 6
                    Console.WriteLine("Little by little, one travels far.")
                Case 7
                    Console.WriteLine("Not all those who wander are lost.")
                Case 8
                    Console.WriteLine("Do not be afraid of competition.")
                Case 9
                    Console.WriteLine("You love peace.")
                Case 10
                    Console.WriteLine("Get your mind set.")
            End Select
        Next
    End Sub
    Function RandomNumber() As Integer
        Dim myRandomNumber As Single
        Randomize()

        myRandomNumber = Rnd() * 10
        myRandomNumber = Int(myRandomNumber) + 1
        Return CInt(myRandomNumber)
    End Function
End Module
