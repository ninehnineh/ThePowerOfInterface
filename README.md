# The Power Of Interface

## Table of contents
- [Overview](#Overview)
- [Setup](#Setup)
- [Problems](#Problems)
- [Solution](#Solution)
- [Conclusion](#Conclusion)

  
Overview
- This repository helps me :blush: clarify the interface's robustness as well as its benefits
- This repository will simulate an add-to-cart action of one specific Customer
  
Setup:
- We have 2 projects for this demo, DemoLibrary (class library) and Interface (Console):
 
  ![SolutionStructure](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/5e129f57-d1d0-461b-a846-c8ea3a06f480)

- In DemoLibrary project:

  $\textcolor{gray}{\textsf{CustomerModel}}$

  ![Customer](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/d474cf52-a120-4089-92c2-74aa05e04aeb)

  $\textcolor{gray}{\textsf{PhysicalProductModel}}$

  ![NewPhysicalProduct](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/4f1d3762-e3df-418a-bf6c-36788e654917)

- In Interface project:

  $\textcolor{gray}{\textsf{Program}}$
  - We simulate an add-to-cart action by calling a $\textcolor{Yellow}{\textsf{AddSampleData()}}$ method
  - We also have a customer that do a add-to-cart action through $\textcolor{Yellow}{\textsf{GetCustomer()}}$ method
    ![Program](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/7ea9d022-e821-401a-9c82-ade91fe7c374)

Result of the program:
- We get 3 rows as a result of each shipped product listed in the cart to a customer. 
  
  ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/4ff62427-7ef5-44ee-b499-5199ef7699e4)

Problems
- Let's say the above code works fine, but in the future, we may have more requirements like the Customer told the development team "I want to sell more products like digital products and it will be sent via the customer's email".
- So we have not touched an interface yet, the solution that is coming to my mind is to create a $\textcolor{gray}{\textsf{DigitalProductModel}}$ and modify an existing code that is already working fine, this modified action is not recommended, it's a risk and takes time to do testing again to make sure it works as expected.
- In this case, this function is standalone, it does not involve other use cases, but if it does, it means we need to retest all of them, which requires more effort to do that.
- One last thing, just look at a $\textcolor{gray}{\textsf{DigitalProductModel}}$, we are violating a DRY principle as well 
  
    ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/bfb3af44-9998-49f1-9b34-d0fb1b8da74b)
  
Solution
- To solve these problems, we are going to use an Interface, adding and modifying some stuff to do it right.
- Create an Interface named $\textcolor{gray}{\textsf{IProductModel}}$

   ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/78e8ba68-3326-41ee-957c-67a83f1f8467)
  
- Create a new class named $\textcolor{gray}{\textsf{DigitalProductModel}}$ and implement $\textcolor{gray}{\textsf{IProductModel}}$, implement for $\textcolor{gray}{\textsf{PhysicalProductModel}}$ as well

   ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/117ca627-e103-4936-9856-18fad6c24e12)

- Modify a $\textcolor{gray}{\textsf{Program}}$
   - To be able to solve all the problems, I just need to change the data type from $\textcolor{gray}{\textsf{PhysicalProductModel}}$ to $\textcolor{gray}{\textsf{IProductModel}}$ without changing the logic of the code.
   - And one more thing is that I was able to add a digital product to the cart
   - In the future, if our Customers need more types of products, the only thing we do is create a class that represents that type of product and let it implement our Interface and that's done 
     ![ProgramAfterChangeV2](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/ee75c54f-86d4-4de8-8476-3a917a78300d)

- The final result:

  ![image](https://github.com/ninehnineh/ThePowerOfInterface/assets/103179810/df22f66c-4a4e-441d-8114-1c475f176c3b)

Conclusion
- So after using an Interface, we can see some of the benefits of an Interface:
  - Scalability: Interfaces make our code base more scalable. It shows up when we assume a customer makes a new requirement for a digital product
  - Code Reuse: Let's remember how we achieve DRY principle by creating and implementing an $\textcolor{gray}{\textsf{IProductModel}}$
  - loose coupling: In the first version of $\textcolor{gray}{\textsf{Program}}$, we can see Main method is depend on PhysicalProductModel, I mean this method only allows 1 type PhysicalProductModel. But with Interface, we can achieve a loose coupling
- Interface has many more than 2 benefits, but in this demo, I think that is all I can understand.
- To go into depth for knowledge of Interface, I am going to explore [the SOLID principles](https://github.com/ninehnineh/Understand-Solid-P)
