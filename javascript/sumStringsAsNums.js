// Link to kata: https://www.codewars.com/kata/5324945e2ece5e1f32000370

/* global BigInt */
const sumStrings = (a, b) => {
    let aa = Array.from(a, Number);
    let bb = Array.from(b, Number);
    let result = [];
    let carry = 0;
    let i = Math.max(a.length, b.length);

    while (i--) {
        carry += (aa.pop() || 0) + (bb.pop() || 0);
        result.unshift(carry % 10);
        carry = Math.floor(carry / 10);
    }
    while (carry) {
        result.unshift(carry % 10);
        carry = Math.floor(carry / 10);
    }

    if (result[0] == '0') result.shift();

    return result.join('');
}