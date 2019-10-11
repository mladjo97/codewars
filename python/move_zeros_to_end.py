# Link to kata: https://www.codewars.com/kata/52597aa56021e91c93000cb0

def move_zeros(arr):
    new_arr = [i for i in arr if isinstance(i, bool) or i != 0]
    return new_arr + [0]*(len(arr)-len(new_arr))