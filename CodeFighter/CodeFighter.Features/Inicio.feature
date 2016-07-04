Feature: Start
	Al Ingresar 2 Jugadores en pantalla
	200 de vida para cada jugadores


Scenario: Start Game
	Given I enter the gamex
		And Player1 name is set "Maria" 
		And Player2 name is set "Juan"
		And Player1 role is set "QA"
		And Player2 role is set "PM"
		And Start game
	Then Life Player1 is "200" 
		And Life Player2 is "200" 
		And Energy Player1 is "0" 
		And Energy Player2 is "0" 
