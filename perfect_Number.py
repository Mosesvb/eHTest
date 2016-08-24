
#PROGRAMMING QUESTION - Moses VB

# 1. PERFECT NUMBERS
# This python code returns whether a given number N is a perfect number or not

#Function to do the calculation
def perfect_number(number):
    total_n = 0
    for i in range(1, number):
        if(number % i == 0):
            total_n = total_n + i
    return total_n        
 
# Taking input from the user
number = int(input("Please Enter any number to check: "))

#calling the defined function above using if statement
if (number == perfect_number(number)):
    print("\n %d is a Perfect Number entered" %number)
else:
    print("\n %d is not a Perfect Number, try another number" %number)
	
#####