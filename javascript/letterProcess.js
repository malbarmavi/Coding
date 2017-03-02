"use strict";

const p = "Good artists copy, great artists steal.";
var s = {};
for (let i = 0; i < p.length; i++) {
    let letter = p[i];
    s[letter] = (s[letter] || 0) + 1;
}

console.log(s);
