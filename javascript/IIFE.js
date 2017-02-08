 //Immediately Invoked Function Expression


 (Function init(){
    // all your code here
    var foo = function() {};
    window.onload = foo;
    // all your code here
 })() 

foo();  //foo is unreachable here (it’s undefined)