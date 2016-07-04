Feature: Especial
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Ejcutar ataque especial con energia 100 al oponente con vida > 30
	Given I enter the play
	And I add players to game
	When I Click "especialAction"
	Then I see his "livePlayerOne" with "170"
