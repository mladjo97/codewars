# Link to kata: https://www.codewars.com/kata/52a89c2ea8ddc5547a000863

def loop_size(node):
    nodes_iterator = node
    nodes_passed = []
    
    while nodes_iterator not in nodes_passed:
        nodes_passed.append(nodes_iterator)
        nodes_iterator = nodes_iterator.next
    
    return len(nodes_passed)-nodes_passed.index(nodes_iterator)

