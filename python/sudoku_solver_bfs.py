# Link to kata: https://www.codewars.com/kata/5296bc77afba8baa690002d7

# Sudoku solver 
# Algorithm used: Breadth-First search

def sudoku(puzzle):
    solve_sudoku(puzzle) 
    return puzzle
    
def solve_sudoku(puzzle):
    unassigned_row, unassigned_col = get_unassigned_location(puzzle)
    
    if unassigned_row == -1 and unassigned_col == -1:
        return True
    
    for num in range(1, 10):
        if is_safe(puzzle, unassigned_row, unassigned_col, num):
            puzzle[unassigned_row][unassigned_col] = num
            
            if solve_sudoku(puzzle):    
                return True
            
            puzzle[unassigned_row][unassigned_col] = 0
    
    return False

def get_unassigned_location(puzzle):
    for row in range(0, 9):
        for col in range(0, 9):
            if puzzle[row][col] == 0:
                return row, col
    return -1, -1

def used_in_row(puzzle, row, num):
    for col in range(0, 9):
        if puzzle[row][col] == num:
            return True
    return False

def used_in_col(puzzle, col, num):
    for row in range(0, 9):
        if puzzle[row][col] == num:
            return True
    return False
    
def used_in_box(puzzle, start_box_row, start_box_col, num):
    for row in range(0, 3):
        for col in range(0, 3):
            if puzzle[row + start_box_row][col + start_box_col] == num:
                return True
    return False
    
def is_safe(puzzle, row, col, num):
    return not used_in_row(puzzle, row, num) and \
           not used_in_col(puzzle, col, num) and \
           not used_in_box(puzzle, row - (row % 3), col - (col % 3), num)