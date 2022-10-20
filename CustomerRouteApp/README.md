# Description
This excercise was created as part of the recruitment process for the position as .Net Developer.

## Exercise

You have been tasked to help the Kiwiland railroad provide information about its routes to its customers, in particular: 
route distance, number of unique routes between two towns, and the shortest route between two towns. In Kiwiland, 
all train routes are one-way, and round trip routes may or may not exist. For example, just because there is a route 
from town A to B does not mean there is necessarily a route from B to A. In fact, if both routes happen to exist, each 
route should be considered unique (and may even have different distances)!
Use a directed graph to represent the train routes. A node represents a town and an edge represents a route between 
two towns. The edge weight represents route distance. No route appears more than once in the input, and for any 
given route, the starting and ending town will never be the same town (e.g., there are no routes from A to A). 

The goal of this exercise is to output a table containing pairs of employees and how often they have coincided in the office.

Input: the name of an employee and the schedule they worked, indicating the time and hours. This should be a .txt file with at least five sets of data. You can include the data from our examples below:

Example 1:

INPUT\
For the test input, the towns are named using the first few letters of the alphabet from A to E. A route between two towns A to B with a distance of 5 is represented as AB5

OUTPUT:\
Given the test inputs, calculate the following: 
1. The distance of the route A-B-C. 
2. The distance of the route A-D. 
3. The distance of the route A-D-C. 
4. The distance of the route A-E-B-C-D. 
5. The distance of the route A-E-D. 
6. The number of trips starting at C and ending at C with a maximum of 3 stops. In the test input, there are two such trips: C-D-C (2 stops). and C-E-B-C (3 stops). 
7. The number of trips starting at A and ending at C with exactly 4 stops. In the test input, there are three such trips: A to C (via B,C,D); A to C (via D,C,D); and A to C (via D,E,B). 
8. The length of the shortest route (in terms of distance to travel) from A to C. 
9. The length of the shortest route (in terms of distance to travel) from B to B. 
10. The number of different routes from C to C with a distance of less than 30. In 
the test input, the trips are: CDC, CEBC, CEBCDC, CDCEBC, CDEBC, CEBCEBC, CEBCEBCEBC. 
For items 1 through 5, if no such route exists, output ‘NO SUCH ROUTE’. Otherwise, follow the route as given; do not make any extra stops!

##Solution
As part of this solution a console application was created:

## License
[@roger1378]
