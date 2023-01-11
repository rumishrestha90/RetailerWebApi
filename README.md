# Retail Customer Reward

A retailer offers a rewards program to its customers, awarding points based on each recorded purchase.

A customer receives 2 points for every dollar spent over $100 in each transaction, plus 1 point for every
dollar spent over $50 in each transaction
(e.g. a $120 purchase = 2x$20 + 1x$50 = 90 points).

Given a record of every transaction during a three-month period, calculate the reward points earned for
each customer per month and total.


## Versions
Framework : .net 6
Language:   c# 10


## Important URL
Swagger UI - https://localhost:44339/swagger/index.html


## How to run the application
1. Clone the repository
2. Open in IDE (Visual Studio or VS Code)
3. Build the project
4. Run the project

##Data

###Customer

| CustomerId     | CustomerName  |
|----------------|---------------|
| 1001           | Customer1     |
| 1002           | Customer2     |
| 1003           | Customer3     |
| 1004           | Customer4     |
| 1005           | Customer5     |
| 1006           | Customer6     |
| 1007           | Customer7     |
| 1008           | Customer8     |


###Transaction

| TransactionId  | CustomerId     | TransactionDate  | TransactionAmount |
|----------------|----------------|------------------|-------------------|
| 1              | 1001           | 2022-07-12       |       1000        |
| 2              | 1001           | 2022-08-04       |       2200        |
| 3              | 1001           | 2022-08-20       |       1000        |
| 4              | 1002           | 2022-09-04       |       1800        |
| 5              | 1002           | 2022-09-07       |       1250        |
| 7              | 1002           | 2022-06-05       |       1230        |
| 8              | 1003           | 2022-06-27       |       3700        |
| 9              | 1004           | 2022-07-04       |       1100        |
| 10             | 1005           | 2022-07-14       |       2350        |
| 11             | 1006           | 2022-08-05       |       1600        |
| 12             | 1006           | 2022-08-18       |       2750        |
| 13             | 1007           | 2022-06-05       |       1050        |
| 14             | 1008           | 2022-06-27       |       3800        |
| 15             | 1008           | 2022-07-04       |       1900        |
| 16             | 1009           | 2022-07-13       |       1030        |
| 17             | 1009           | 2022-03-27       |       5500        |
| 18             | 10010          | 2022-08-02       |       4850        |
| 19             | 10010          | 2022-08-15       |       2400        |

