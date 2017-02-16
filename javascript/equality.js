
/*  
    == loose-equality
    The Abstract Equality Comparison Algorithm
    The comparison x == y, where x and y are values, produces true or false. Such a comparison is performed as follows:
        1.	If Type(x) is the same as Type(y), then
            1.	If Type(x) is Undefined, return true.
            2.	If Type(x) is Null, return true.
            3.	If Type(x) is Number, then
                i.	If x is NaN, return false.
                ii.	If y is NaN, return false.
                iii.	If x is the same Number value as y, return true.
                iv.	If x is +0 and y is −0, return true.
                v.	If x is −0 and y is +0, return true.
                vi.	Return false.
            4.	If Type(x) is String, then return true if x and y are exactly the same sequence of characters 
                (same length and same characters in corresponding positions). Otherwise, return false.
            5.	If Type(x) is Boolean, return true if x and y are both true or both false. Otherwise, return false.
            6.	Return true if x and y refer to the same object. Otherwise, return false.
        2.	If x is null and y is undefined, return true.
        3.	If x is undefined and y is null, return true.
        4.	If Type(x) is Number and Type(y) is String,return the result of the comparison x == ToNumber(y).
        5.	If Type(x) is String and Type(y) is Number,return the result of the comparison ToNumber(x) == y.
        6.	If Type(x) is Boolean, return the result of the comparison ToNumber(x) == y.
        7.	If Type(y) is Boolean, return the result of the comparison x == ToNumber(y).
        8.	If Type(x) is either String or Number and Type(y) is Object,
        return the result of the comparison x == ToPrimitive(y).
        9.	If Type(x) is Object and Type(y) is either String or Number,
        return the result of the comparison ToPrimitive(x) == y.
        10.	Return false.
*/
