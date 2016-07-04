Feature: Punch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Player 1 Punches
	Given Player1 "Maria" role1 "QA" Player2 "Juan" role2 "DBA" start game
	When Player1 Punches
	Then Player1 energy is "5" 
		And Player2 Life is "190" 
