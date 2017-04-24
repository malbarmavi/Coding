
!function init() {
    b = 10
}()

console.log(b);

!function init() {
    var b = 10
}()

console.log(b);

!function init() {
    console.log(b); // Uncaught ReferenceError: b is not defined at init
    b = 10
}()

!function init() {
    b = 2 
    console.log(b);
    var b = 10
}()

!function init() { // this how the code above look like after hoisting
    var b;
    b = 2 
    console.log(b);
    b = 10
}()

// about let keyword

 {
     let b = 2;
 }

console.log(b);  // Uncaught ReferenceError: b is not defined

 {
     let b = 2;
     console.log(b);
 }

 { // No hoisting when we using let
     console.log(b); // Uncaught ReferenceError: b is not defined
     let b = 2;
 }

for (var i=0;i<9;i++) { console.log(i)}
console.log(`Here is ${i}`);

for (let i=0;i<9;i++) { console.log(i)}
console.log(`Here is ${i}`); // Uncaught ReferenceError: i is not defined
