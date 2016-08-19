
/*
   A palindrome is a word or sentence that's spelled the same way both forward and backward, 
   ignoring punctuation, case, and spacing.
 */

function reverseString(str) {
    return str.split("").reverse().join("");
}

function palindrome(str) {
    var stringResult = str.toLowerCase().replace(/[^A-Za-z0-9]/g, "");
    var reverseResult = reverseString(stringResult);
    return stringResult === reverseResult;
}

palindrome("eye");
