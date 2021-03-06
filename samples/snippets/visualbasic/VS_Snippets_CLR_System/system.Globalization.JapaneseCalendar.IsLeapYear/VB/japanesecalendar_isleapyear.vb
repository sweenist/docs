' The following code example calls IsLeapYear for five years in each of the eras.

' <snippet1>
Imports System
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class SamplesJapaneseCalendar   
   
   Public Shared Sub Main()

      ' Creates and initializes a JapaneseCalendar.
      Dim myCal As New JapaneseCalendar()

      ' Displays the header.
      Console.Write("YEAR" + ControlChars.Tab)
      Dim y As Integer
      For y = 1 To 5
         Console.Write(ControlChars.Tab + "{0}", y)
      Next y
      Console.WriteLine()

      ' Checks five years in the current era.
      Console.Write("CurrentEra:")
      For y = 1 To 5
         Console.Write(ControlChars.Tab + "{0}", myCal.IsLeapYear(y, JapaneseCalendar.CurrentEra))
      Next y
      Console.WriteLine()

      ' Checks five years in each of the eras.
      Dim i As Integer
      For i = 0 To myCal.Eras.Length - 1
         Console.Write("Era {0}:" + ControlChars.Tab, myCal.Eras(i))
         For y = 1 To 5
            Console.Write(ControlChars.Tab + "{0}", myCal.IsLeapYear(y, myCal.Eras(i)))
         Next y
         Console.WriteLine()
      Next i

   End Sub 'Main 

End Class 'SamplesJapaneseCalendar


'This code produces the following output.
'
'YEAR            1       2       3       4       5
'CurrentEra:     False   False   False   True    False
'Era 4:          False   False   False   True    False
'Era 3:          False   False   True    False   False
'Era 2:          True    False   False   False   True
'Era 1:          True    False   False   False   True

' </snippet1>
