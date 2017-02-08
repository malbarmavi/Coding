 // Shorthand for console object 
 (function(_windows){
  let c =Object.create(console);
  c.l = c.log;
  c.w=c.warn;
  c.i = c.info
  c.e = c.error
  c.d = c.debug
  c.c= c.clear
  _windows.c = c;
})(window)