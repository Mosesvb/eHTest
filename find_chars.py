#PROGRAMMING QUESTION - Moses VB

# 2. CHARACTERS IN STRING
#A python function that takes two strings and only returns a string that only 
# contains the characters in string 1 and string 2 in that order

#find_chars function with two input parameters/arguments
def find_chars(string1, string2):
    return_string = ""
    for string1_char in string1:
        for string2_char in string2:
            if string1_char == string1_char:
                return_string += string1_char
                break
    return return_string

####
