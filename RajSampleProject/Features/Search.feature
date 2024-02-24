Feature: Search Feature 

A short summary of the feature

@Google @Search
Scenario: Search Google 
	Given Open the Browser
	When Enter URL 'https://www.Google.com'
	Then I have searched google for 'Raj Ghedia'


@Youtube @Search
Scenario: Search Youtube 
	Given Open the Browser
	When Enter URL 'https://www.youtube.com'
	Then Searh youtube 
	