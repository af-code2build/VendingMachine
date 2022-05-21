# Vending Machine
#### A quick Windows Forms app in Visual Studio simulating a Vending Machine, keeping track of the products and coins that it contains with a portable SQLite database.  

## About The Project

<kbd>
  <img src="https://user-images.githubusercontent.com/68421082/168543078-fffe6b67-2c9b-41dc-9db1-24bce7f28214.png" height="500" width="400" >
</kbd>

<br />
<br />
It's a simple application with a simple UI interface where the user can select a product in the list of options and initiate a transaction.
Every time a product is selected, a new transaction begins and the old one stops without saving any changes.

During a transaction, it's possible to see the state of the purchase (the price of the selected product, the money you are still missing or if you are ready to buy, and the change you will receive). To simulate adding a coin to the machine, the user can click on the coin images (1p, 2p, 5p, etc.).

When the necessary amount is added, it's possible to conclude the transaction by clicking the Buy button:
<br />
<br />
<kbd>
  <img src="https://user-images.githubusercontent.com/68421082/168544896-d757f159-9f03-4669-b39b-41d296812fc8.png" height="500" width="400" >
</kbd>

There's also an admin page simulating the option of having a master key to open the machine and adding new products. It's also possible to replenish the coin reserves and increase the quantities of the existing products. For that, a password is needed: "admin123"
<br />
<br />
<kbd>
  <img src="https://user-images.githubusercontent.com/68421082/168546299-847c86bc-7511-4ec8-8ade-7a2516916689.png" height="500" width="400" >
</kbd>

After clicking the lock icon, the user will have access to the admin control panel to add or update the machine inventory:
<br />
<br />
<kbd>
  <img src="https://user-images.githubusercontent.com/68421082/169643719-eb1c2b5f-d29e-4d4b-87b8-e2be2b1e2836.png" height="500" width="400" >
</kbd>
<br />
<br />
Simply click one of the items on the list to update one of them.

## How to Build
This application requires at least Visual Studio 2019 V16.6 and .NET 5.0 SDK to build on Windows.


