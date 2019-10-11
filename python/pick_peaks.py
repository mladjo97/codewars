# Link to kata: https://www.codewars.com/kata/5279f6fe5ab7f447890006a7

def pick_peaks(arr):
    pos = []
    peaks = []
    
    if len(arr) == 0:
        return { "pos": pos, "peaks": peaks }
    
    plateau = [arr[1], arr[-1]]
    
    for i in range(1, len(arr)-1):
        if arr[i-1] < arr[i] and arr[i] >= arr[i+1]:
            if arr[i] == arr[i+1]:
                if arr[i] != plateau[1]:
                    can_add = True
                    for j in range(i+1, len(arr)):
                        if arr[i] > arr[j]:
                            break
                        if arr[i] < arr[j]:
                            can_add = False
                            break
                    if can_add:
                        pos.append(i)
                        peaks.append(arr[i])
            else:
                pos.append(i)
                peaks.append(arr[i])
    
    return { "pos": pos, "peaks": peaks }
    