#Link to kata: https://www.codewars.com/kata/525c65e51bf619685c000059

def cakes(recipe, available):
    quantity = []
    for ingredient in recipe:
        if ingredient not in available:
            return 0
            
        if available[ingredient] >= recipe[ingredient]:
            quantity.append(available[ingredient] / recipe[ingredient])
        else:
            quantity.append(0)
            
    return min(quantity)