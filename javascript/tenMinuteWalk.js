// Link to kata: https://www.codewars.com/kata/54da539698b8a2ad76000228

function isValidWalk(walk) {
    if(walk.length !== 10) return false;

    let validWalk = true;

    for(let i = 0; i < walk.length - 1; i++){
      if(walk[i] == walk[i+1]) {
        validWalk = false;
        break;
      }
    }
    
    return validWalk;
  }