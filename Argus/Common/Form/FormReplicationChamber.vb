Imports System.CodeDom.Compiler
Imports System.IO

Public Class FormReplicationChamber

    Private Sub FormReplicationChamber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UniThemer(Me)

        ButtonBuild.Text = "Build"
        ButtonFetch.Text = "Fetch"

    End Sub

End Class

Module Module1

    Sub Main()
        Dim parameters As New CompilerParameters()
        parameters.GenerateExecutable = True
        parameters.OutputAssembly = "Output.exe"
        parameters.ReferencedAssemblies.Add("System.dll")
        parameters.ReferencedAssemblies.Add("System.Core.dll")
        parameters.CompilerOptions = "/target:winexe"
        parameters.MainClass = "MyApplication.Program"
        parameters.WarningLevel = 3

        Dim provider As New VBCodeProvider()
        Dim results As CompilerResults = provider.CompileAssemblyFromSource(parameters, GetSourceCode())

        If results.Errors.Count > 0 Then
            Console.WriteLine("Error building executable:")
            For Each err As CompilerError In results.Errors
                Console.WriteLine(err.ErrorText)
            Next
        Else
            Console.WriteLine("Executable built successfully!")
        End If
    End Sub

    Private Function GetSourceCode() As String
        Return "Imports System.Console

Namespace MyApplication
    Public Class Program
        Public Shared Sub Main(ByVal args As String())
            WriteLine(""Hello, World!"")
            WriteLine(""Parameters: "" & String.Join("" "", args))
            ReadLine()
        End Sub
    End Class
End Namespace"
    End Function

End Module