Feature: Custom Step Param Conversion


Scenario: Force regular password change
	Given I last logged in 10 days ago
	When I try to log in
	Then the new password wizard should start
