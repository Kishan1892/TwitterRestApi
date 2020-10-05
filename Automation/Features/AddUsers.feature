Feature: Add Users


Scenario: Add multiple users
	Given I have input the following users
	| FirstName | LastName |
	| Sarah     | Smith		|
	| Gentry    | Jones    |
	When I choose add
	Then the users should be added
