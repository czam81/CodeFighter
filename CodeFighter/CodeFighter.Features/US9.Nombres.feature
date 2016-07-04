Feature: US9 Nombres
	
Scenario: Ingresar nombre de jugadores
	Given I enter the game
	And PlayerUno name is set "Maria" 
	And PlayerDos name is set "Juan"
	Then PlayerUno name is get "Maria"
	And PlayerDos name is get "Juan"