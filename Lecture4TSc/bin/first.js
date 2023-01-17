"use strict";
//1. Hello
console.log("Hello World");
//2. Basic DataTypes and variables using Let var and const
//https://www.typescriptlang.org/docs/handbook/basic-types.html
let isDone = false;
let decimal = 6;
let hex = 0xf00d;
let binary = 0b1010;
let octal = 0o744;
let big = 100n;
let color = "blue";
color = 'single';
console.log(isDone, decimal, hex, binary, octal, big);
let fullName = `Bob Bobbington`;
let age = 37;
let sentence = `Hello, my name is ${fullName}.

I'll be ${age + 1} years old next month.`;
//console.log(sentence)
sentence =
    "Hello, my name is " +
        fullName +
        ".\n\n" +
        "I'll be " +
        (age + 1) +
        " years old next month.";
//console.log(sentence)
//List/Array
let arr1 = [1, 2, 4];
let arr2 = [1, 2, 3];
arr1.reverse();
console.log(arr1[0]);
//Tuple
let kv = [1, "One"];
kv = [2, 'Two'];
console.log(kv[0]);
//Enum
var Gender;
(function (Gender) {
    Gender[Gender["Male"] = 0] = "Male";
    Gender[Gender["Female"] = 1] = "Female";
    Gender[Gender["Confused"] = 2] = "Confused";
})(Gender || (Gender = {}));
let g = Gender.Male;
console.log(g.toString());
//# sourceMappingURL=first.js.map