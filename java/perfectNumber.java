//PROGRAMMING QUESTION - Moses VB

//1. PERFECT NUMBERS
// This Java code returns whether a given number N is a perfect number or not

import java.util.Scanner;
 
public class PerfectNumber {
 
    // The main method which begins the execution of this class
    public static void main(String args[]) {
 
		//declaration of variables
        int inputValue;
		int totalN = 0;
 
		//using scanner class to accept user input
        Scanner userInput = new Scanner(System.in);
        System.out.print("Enter a number greater than to check: ");
		
        // Take entered value and store it into the  inputValue variable
        inputValue = userInput.nextInt();
       
        // check/compare the input number whether it's a perfect number of not
        for(int i = 1; i <= inputValue; i++) {
            if(inputValue%i==0) 
			totalN += i;  //or totalN = totalN+i;
        }
		
		//check and display message to the user
        if(totalN == inputValue)
            System.out.print("The number "+inputValue+" is a perfect number ");
        else 
           System.out.print("The number "+inputValue+" is not a perfect number, try again "); 
        
    } 
}

