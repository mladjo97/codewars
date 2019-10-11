// Link to kata: https://www.codewars.com/kata/539a0e4d85e3425cb0000a88

const add = (n) => {
    let sum = n;

    function resultFn(y) {
        sum += y;
        return resultFn;
    }

    resultFn.valueOf = function () { return sum };

    return resultFn;
}