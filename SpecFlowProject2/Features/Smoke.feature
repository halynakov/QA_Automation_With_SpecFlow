Feature: Smoke
		As a user
		I want to test all main site functionality
		So that I can be sure that site works correctly

@smoke
Scenario Outline: Check opening the 'gaming headsets' page when clicking on 'Headsets' section
  Given User opens Amazon page
    When User clicks on 'Headsets' section
  Then Page with the '"gaming headsets"' title is opened


@smoke
Scenario: Check search for a product by its name
	Given User opens Amazon page
	When User makes search by product name 'Mixing Bowl'
	Then User checks that the first item in the list has name 'Mixing Bowl'


@smoke
Scenario: Check the addition of items to the cart
	Given User opens Amazon page
	And User clicks on 'Headsets' section
	And User goes to 'Targeal 7.1 Surround Sound Gaming Headset' product page
	When User adds product to the cart
	Then Number of items in the cart is '1'

@smoke
Scenario: Check filtering products by brand
	Given User opens Amazon page
	And User clicks on 'Learning Toys' category
	When User does filtering by 'JOYIN' brand
	Then Brand products are displayed on 'JOYIN' page


@smoke
Scenario: NegativeCheck signing in with empty fields
	Given User opens Amazon page
	And User clicks on All dropdown menu
	And User clicks SignIn button
	When User leaves all fields empty
	Then Entry is denied by warning

@smoke
Scenario: Check that the order price increases when the quantity of goods is increased
	Given User opens Amazon page
	And User clicks on 'Headsets' section
	And User goes to 'Targeal 7.1 Surround Sound Gaming Headset' product page
	When User adds product to the cart
	And User goes to the cart
	And User increases quantity of goods
	Then The order price in the cart is '$43.98'

@smoke
Scenario: Check deleting all goods from the cart
	Given User opens Amazon page
	And User clicks on 'Headsets' section
	And User goes to 'Targeal 7.1 Surround Sound Gaming Headset' product page
	And User adds product to the cart
	When User goes to the cart
	And User click on 'Delete' button
	Then Cart is empty

@smoke
Scenario: Check that user can change language
  Given User opens Amazon page
  And User hovers on Language button
  When User changes language to 'Deutsch'  
  Then Section is translated into 'Geschenkkarten'


  @smoke
Scenario: Check that user can change location
	Given User opens Amazon page
	And User clicks on Location button
	When User changes location to 'United Kingdom' country
	Then Location changes to 'United Kingdom' country
