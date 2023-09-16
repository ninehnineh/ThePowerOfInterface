## The Power Of Interface
This repository helps clarify the interface's robustness as well as its benefits

1, Set Up:
- We have 2 projects for this demo, DemoLibrary (class library) and Interface (Console):
 
  ![SolutionStructure](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/5e129f57-d1d0-461b-a846-c8ea3a06f480)

- In DemoLibrary project:

  Customer.cs

  ![Customer](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/d474cf52-a120-4089-92c2-74aa05e04aeb)

  PhysicalProductModel.cs

  ![NewPhysicalProduct](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/4f1d3762-e3df-418a-bf6c-36788e654917)

- In Interface project:

  Program.cs
  - We get a list of PhysicalProduct by $\textcolor{Yellow}{\textsf{AddSampleData()}}$ method
  - We also have a customer through $\textcolor{Yellow}{\textsf{GetCustomer()}}$ method
    ![Program](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/7ea9d022-e821-401a-9c82-ade91fe7c374)

Result of the program:
- We get 3 rows as a result of each shipped product listed in the cart variable
  
  ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/4ff62427-7ef5-44ee-b499-5199ef7699e4)

2, Problem
- Let's say the above code works fine, but in the future, we may have more requirements like the Customer told the development team "I want to sell more products like digital products and it will be sent via the customer's email".
- So we have not touched an interface yet, the solution that is coming to my mind is to create a new DigitalProductModel.cs like this:
  
    ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/bfb3af44-9998-49f1-9b34-d0fb1b8da74b)

