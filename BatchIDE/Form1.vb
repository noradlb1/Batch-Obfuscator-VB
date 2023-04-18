Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO
Imports System.Diagnostics
Imports CodeTools
Namespace BatchIDE
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Shared random As New Random()
		Public Shared Function RandomString(ByVal length As Integer) As String
			Const chars As String = "abcdefghijklmnopqrstuvwxyz"
			Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
		End Function
		Public output As String
		Public output2 As String

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If textBox2.Text = "" Then
				MessageBox.Show("Please enter a file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Else
			   ' try
					If checkBox2.Checked = True Then
						Dim input = textBox1.Text
						Dim bruh As String = input = String.Concat(input.Select(Function(x)If(Char.IsLetterOrDigit(x), "%" & RandomString(6) & "%" & x, x.ToString()))).TrimStart()
						output = bruh
					ElseIf checkBox2.Checked = False Then
						output = textBox1.Text
					End If
					If checkBox1.Checked = True Then
						Dim p1 = output & ControlChars.Lf & "Del %~0"
						Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(p1)
						Dim outy = System.Convert.ToBase64String(plainTextBytes)

						Dim sb As String = "@echo off" & ControlChars.Lf & "CERTUTIL -f -decode ""%~f0"" ""%Temp%/test.bat"" >nul 2>&1 " & ControlChars.Lf & "cls" & ControlChars.Lf & """%Temp%/test.bat""" & ControlChars.Lf & "Exit" & ControlChars.Lf & "-----BEGIN CERTIFICATE-----" & ControlChars.Lf & outy & ControlChars.Lf & "-----END CERTIFICATE-----"
						File.WriteAllText(Environment.CurrentDirectory & "/" & textBox2.Text & ".bat", sb)
						output = sb

					End If
					If checkBox3.Checked = True Then
						Dim outy As String = output & ControlChars.Lf & "Del %~0"
						Dim configData1 As String = File.ReadAllText(Environment.CurrentDirectory & "/config.txt")
						Dim configData2 As String = File.ReadAllText(Environment.CurrentDirectory & "/config2.txt")
						Dim o As New Obfuscator()
						Dim out2 As String = o.Obfuscate(outy, "123")
						Dim config As String = $"{out2}"
						Dim conjoined As String = configData1 & Environment.NewLine & config & configData2

						File.WriteAllText(Environment.CurrentDirectory & "/" & textBox2.Text & ".cs", conjoined)
'                        /
'                        Process pr = new Process();
'                        Process process = new Process();
'                        ProcessStartInfo startInfo = new ProcessStartInfo();
'                        startInfo.FileName = Environment.CurrentDirectory + "/csc.exe";
'                        startInfo.Arguments = textBox2.Text + ".cs";
'                        process.StartInfo = startInfo;
'                        process.Start();
'                        /
						MessageBox.Show("Successfully Generated C# File. Now Making Batch File.", "Success!" & MessageBoxIcon.Information)





					End If
					File.WriteAllText(Environment.CurrentDirectory & "/" & textBox2.Text & ".bat", output)

					MessageBox.Show("Obfuscated Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
				'catch { MessageBox.Show("Fatal Error Occured", "Error"); }
			End If

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
