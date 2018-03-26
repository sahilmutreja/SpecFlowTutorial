Feature: Feature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@BasicParams
Scenario: Add two numbers 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen with my name sahil
	 
@TableParams @ContextInjection
Scenario: Enter a form
	Given I enter values in a form for following and save them  with my name sahil
	| name  | age | phone      |
	| Sahil | 28  | 9664192488 | 
	| Gaurav | 26  |  9664192423 |
	And I get the values from different binding class
