@Api
Feature: Test Twitter Tweets

Scenario: 01. Get recent tweets from our Home Timeline
	#Given I post a tweet of "Hello World! This is a test tweet."
	When I retrieve my information
	Then the response in my message contains "kishan"