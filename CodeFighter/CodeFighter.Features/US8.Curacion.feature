Feature: 8. Curacion

Scenario: Jugador 1 tiene energia 100 y vida 140
	Given 
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
