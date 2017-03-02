"use strict";

/*
 Explore primative type Api
*/

// number

var n = 10;

console.log(n); // 10
console.log(n.toFixed(2)); // 10.00
console.log(n.toFixed(0)); // 10

n = 2.5;

console.log(n);
console.log(n.toFixed(2)); // 2.50
console.log(n.toFixed(0)); // 3

// string

var s = "Hello JavaScript.";

console.log(s); // Hello JavaScript.
console.log(s.length);
console.log(s[0]);
console.log(s.charAt(0));
console.log(s.toLowerCase());
console.log(s.toUpperCase());
console.log(s.indexOf("J"));

console.log(s.startsWith("H"));
console.log(s.startsWith("H",0));
console.log(s.startsWith("J",6));

console.log(s.endsWith("."));
console.log(s.endsWith("H",1));

console.log(s.split());
console.log(s.split(""));
console.log(s.split(" "));
console.log(s.split("",6));
