Feature: MrOne
	In order to use R9
	As a user
	I need to be able to log into it

Scenario: Successful Login
	Given I have opened a browser
	And I have navigated to "https://au-ws-02.fhprelgb01.local/"
	And I have entered my username as "fullaccess"
	And I have entered my password as "Budapest11"
	When I click Login
	Then I should be on the Select Organisation Page
	Then I clicked on the "stock management" page
	Then I clicked on the "create order page" page


