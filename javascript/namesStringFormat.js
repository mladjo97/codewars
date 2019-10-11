// Link to kata: https://www.codewars.com/kata/53368a47e38700bd8300030d

function list(names){

    if(names.length == 1) return names[0].name;
    
    return names.map((obj, index) => {
      if(index == names.length-1)
        return `& ${obj.name}`;
      if(index == names.length-2)
        return `${obj.name} `;
      return `${obj.name}, `;
    }).join('');
  }