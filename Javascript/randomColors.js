function generateColor() {
    var e = getRandomColor(),
        t = colorIsLight(hexToRgb(e).r, hexToRgb(e).g, hexToRgb(e).b) ? "black" : "white";
    document.body.style.webkitTransition = "background-color 0.5s ease", document.body.style.background = e, document.getElementById("colorText").value = e, document.getElementById("colorText").style.color = t, document.getElementById("colorText").style.borderBottom = "1px solid " + t, document.getElementById("colorText").style.boxShadow = "0 1px 0 0 " + t
}

function getRandomColor() {
    for (var e = "0123456789ABCDEF".split(""), t = "#", o = 0; 6 > o; o++) t += e[Math.floor(16 * Math.random())];
    return t
}

function hexToRgb(e) {
    var t = /^#?([a-f\d])([a-f\d])([a-f\d])$/i;
    e = e.replace(t, function(e, t, o, n) {
        return t + t + o + o + n + n
    });
    var o = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(e);
    return o ? {
        r: parseInt(o[1], 16),
        g: parseInt(o[2], 16),
        b: parseInt(o[3], 16)
    } : null
}

function colorIsLight(e, t, o) {
    var n = 1 - (.299 * e + .587 * t + .114 * o) / 255;
    return .5 > n
}
document.addEventListener("DOMContentLoaded", function() {
    
});