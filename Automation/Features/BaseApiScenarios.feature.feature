@Api
Feature: Test Twitter Tweets

Scenario: 01. Get recent tweets from our Home Timeline
	When I retrieve my information
	Then the response in my message contains "kishan"

