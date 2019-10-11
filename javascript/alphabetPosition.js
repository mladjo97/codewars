// Link to kata: https://www.codewars.com/kata/546f922b54af40e1e90001da

function alphabetPosition(text) {
    let result = "";

    for (let i = 0; i < text.length; i++) {
        let code = text.toUpperCase().charCodeAt(i);
        if (code > 64 && code < 91) result += (code - 64) + " ";
    }

    return result.slice(0, result.length - 1);
}