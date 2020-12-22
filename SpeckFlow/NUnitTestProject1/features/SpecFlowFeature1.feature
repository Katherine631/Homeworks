Feature: FishTest
	As a user 
	I want to login on URL http://localhost:5000/
	So I can create a product and make sure it exists


Scenario: Create product
	Given I open "http://localhost:5000/" url 
	When I login with "user", "user" fields
	And I click All Products link
	And I click Create new button
	And I fill next fields "Fish", "Seafood", "Tokyo Traders", "7", "1", "10", "3", "1"
	And I click Send button
	Then The product "Fish" should be created