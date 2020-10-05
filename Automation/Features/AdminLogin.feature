Feature: Admin Login

Scenario: Correct profile name
	Given I have logged in as administrator 'Kishan'
	When I navigate to the user profile page
	Then the correct username should be shown 		