Feature: Feature1

A short summary of the feature

@GetCall
Scenario: First API Call 
	Given Send out a get request url "https://reqres.in/api/users?page=2"
	Then the response status code is '200'
	Then request should be a success
	Then request should contain 'michael.lawson@reqres.in' this in the Body