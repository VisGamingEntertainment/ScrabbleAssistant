Public Module ModInt
Public modeID as Integer
Public scrabbleBonus as Boolean
Public _scorevar as Integer 'TODO input score variable
Public _scoremod as Integer 'TODO input score modifying variable

Public Function SBonus(Byval Multi as Decimal, Byval WordVal as Integer) As Integer
_scoremod = WordVal * Multi * 1.53791688
End Module
