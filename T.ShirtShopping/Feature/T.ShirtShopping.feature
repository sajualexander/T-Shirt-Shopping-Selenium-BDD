Feature: T-ShirtShopping
	A shopping site to order a T-Shirt and verify the same in Order History Page.

@saju
Scenario: 01. Order T-Shirt and verify in Order History
	Given I navigate to the shopping website
	And I navigate to the signin page
	And I enter the emailid as "sajualexander@ymail.com" and password as "Test@123" 
	And I add T.Shirt in the cart
	And I confirm my order
	And I navigate to Order History page
	Then I verify the order with reference number "FBSINLIVE" is placed in Order History page
	
Scenario: 02. Update Personal Information(First Name) in My Account
	Given I navigate to Personal Information page
	And I update the firstname in My Accounts