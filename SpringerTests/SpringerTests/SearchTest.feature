Feature: SearchTest
	In order to check the Search is working
	As a user
	I want to be given Search results correctly

@mytag
Scenario: Testing the Search bar
	Given I am a user
	And I navigate to the site
	When I search for the word
	Then I receive search results with the word in the title
