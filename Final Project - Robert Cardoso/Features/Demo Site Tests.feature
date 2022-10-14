Feature: Applying discount

The test will login to an e-commerce site as a registered user, purchase an item of clothing, apply a 
discount code and check that the total is correct after the discount & shipping is applied. 


Background:
	Given I am on the demo site

@tag1
Scenario Outline: Coupon
	Given I am logged in using a valid <username> and <password>
	When I add an item to the basket
	And I apply a <coupon>
	Then a discount will be applied

Examples:
	| username                    | password             | coupon    |
	| robert.cardoso@nfocus.co.uk | thisismypassword123. | edgewords |

Scenario Outline: Order
	Given I am logged in using a valid <username> and <password>
	When I add an item to the basket
	And I enter my details
	Then I can place an order

Examples:
	| username                    | password             | coupon    |
	| robert.cardoso@nfocus.co.uk | thisismypassword123. | edgewords |