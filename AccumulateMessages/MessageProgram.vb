
Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code here
        Dim message As String() = {"Hello", "Good bye", "Jimmy likes pizza!!", "too many bananas", "more", "aardvark", "must be a number", "I need one more message"}
        Return "" 'messages
        UserMessages("Hello", False) 'return
        UserMessages("Goodbye", False)
        Dim result As String

        ' Adding messages sequentially
        result = UserMessages("Hello", False)
        result = UserMessages("Good bye", False)
        result = UserMessages("Jimmy likes pizza!!", False)

        Console.WriteLine(result) ' Expected output:
        ' Hello
        ' Good bye
        ' Jimmy likes pizza!!

    End Function


End Module
