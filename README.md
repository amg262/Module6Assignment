# Module 6 Assignment #

Create a program to simulate a vending machine. It should have a class called Item.

The Item class should have fields that store the name of the item, quantity in the machine, and price per unit.

The main program should use a List<Item> to store the inventory in the vending machine.

At program start, the user should be able to fill the machine with items to vend.

When they are done filling the machine, the program allows users to purchase from the machine.

When users are done purchasing, the program should print out the inventory remaining in the vending machine. It should also print the amount of money the machine collected from item sales.



Sample Program Run
After your program runs, the console should look similar to the following example. The exact output will vary depending on what the user inputs.

```
Item to stock (NA to end): Snickers
Quantity: 12
Price each: 1.75
Item to stock (NA to end): Trail Mix
Quantity: 10
Price each: 1.55
Item to stock (NA to end): NA

################################

Vending Machine
1 - Snickers $1.75
2 - Trail Mix $1.55
Item to buy (NA to end): 1
Item to buy (NA to end): 1
Item to buy (NA to end): 2
Item to buy (NA to end): 1
Item to buy (NA to end): NA

################################

Inventory in Vending Machine
9 Snickers
9 Trail Mix
$6.80 collected from sales
```