// Link to kata: https://www.codewars.com/kata/5263c6999e0f40dee200059d

const getPINs = (observed) => {
  
    const adjacentDigits = {
      '1': ['1', '2', '4'],
      '2': ['2', '1', '3', '5'],
      '3': ['3', '2', '6'],
      '4': ['4', '1', '5', '7'],
      '5': ['5', '2', '4', '6', '8'],
      '6': ['6', '3', '5', '9'],
      '7': ['7', '4', '8'],
      '8': ['8', '5', '7', '9', '0'],
      '9': ['9', '6', '8'],
      '0': ['0', '8']
    };
    
    if (observed.length === 1) {
      return adjacentDigits[observed];
    } 
    
    let allPins = [];
    let subPins = getPINs(observed.substring(1));

    adjacentDigits[observed[0]].forEach((p) => {
      allPins = allPins.concat(subPins.reduce((acc, sp) => {
          acc.push(p + sp);
          return acc;
      }, []));
    });
    
    return allPins;  
  }