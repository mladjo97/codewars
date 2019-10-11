# Link to kata: https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9

import string

def is_pangram(s):
    letters = list(string.ascii_lowercase)
    for c in s.lower():
        if c in letters:
            letters.remove(c)
    
    if len(letters) > 0:
        return False
    else:
        return True
