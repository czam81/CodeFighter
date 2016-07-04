Feature: Start
	Al Ingresar 2 Jugadores en pantalla
	200 de vida para cada jugadores


Scenario: Start Game
	Given Player1 is "Maria" 
		And Player2 is "Juan"
		And Start game
	Then Life Player1 is "200" 
		And Life Player2 is "200" 
		And Energy Player1 is "0" 
		And Energy Player2 is "0" 
