Feature: To validate the login scenario with valid user and password

A short summary of the feature

@functional
Scenario: Login scenario with valid user and password
	Given Open Browser and goto the url
	When Enter valid User and passord
	Then user should be logged in
