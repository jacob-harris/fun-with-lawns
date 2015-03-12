Module Module1
    Class information
        Public companyname As String
        Public ownersname As String
        Public contactnumber As Integer
        Public address As String
        Public hourlyrate As Single
        Public hourscompleted As Integer



    End Class
    Dim company As New information






    Sub Main()

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.Green

        Console.Clear()
        Console.WriteLine("Welcome to the fun wit lawns v0.1 ")
        Console.WriteLine(" your all in one lawn management system.")
        Console.WriteLine()
        Console.WriteLine(" press any key to continue ....")


        Console.ReadLine()

    End Sub
    Sub noprofile()

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.Green


        Console.WriteLine("no company information has been found. we'll set up a profile before we begin ")
        Console.WriteLine()
        Console.WriteLine("press any key to continue...")
        Console.ReadLine()

        details()
    End Sub

    Sub details()



        Console.WriteLine("here you need to enter the details for ypur new company profile. ")
        Console.WriteLine()
        Console.Write("company name: ")
        company.companyname = Console.ReadLine
        Console.Write("company owner's name: ")
        company.ownersname = Console.ReadLine
        Console.Write("company contact number: ")
        company.contactnumber = Console.ReadLine()
        Console.Write("company address: ")
        company.address = Console.ReadLine
        Console.Write("company hourly rate: ")
        company.hourlyrate = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("setup is complete! ")
        Console.WriteLine()
        Console.WriteLine("press any key to continue... ")

    End Sub
    Sub menu()

        Console.WriteLine("Welcome")







    End Sub

















End Module
