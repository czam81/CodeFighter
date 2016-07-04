Feature: Punch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Player 1 Punches
	Given Player1 "Maria" role1 "QA" Player2 "Juan" role2 "DBA" start game
	When Player1 Punches
	Then Player1 energy is "10" 
	And Player2 Life is "190" 


Scenario: Player 1 Punches 5 times
	Given Player1 "Maria" role1 "QA" Player2 "Juan" role2 "DBA" start game
	When Player1 Punches
	When Player1 Punches
	When Player1 Punches
	When Player1 Punches
	When Player1 Punches
	Then Player1 energy is "50" 
	And Player2 Life is "150" 

	
Scenario: Player 2 kicks
	Given Player1 "Maria" role1 "QA" Player2 "Juan" role2 "DBA" start game
	When Player2 kicks
	Then Player2 energy is "16" 
	And Player1 Life is "180" 
