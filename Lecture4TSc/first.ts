//1. Hello
console.log("Hello World")

//2. Basic DataTypes and variables using Let var and const
//https://www.typescriptlang.org/docs/handbook/basic-types.html

let isDone: boolean = false;

let decimal: number = 6;
let hex: number = 0xf00d;
let binary: number = 0b1010;
let octal: number = 0o744;
let big: bigint = 100n;

let color: string = "blue";
color ='single'

console.log(isDone, decimal, hex, binary, octal, big)

let fullName: string = `Bob Bobbington`;
let age: number = 37;

let sentence: string = `Hello, my name is ${fullName}.

I'll be ${age + 1} years old next month.`
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
let arr1 : number[] = [1,2,4]
let arr2 : Array<number> = [1,2,3]

arr1.reverse();
console.log(arr1[0])

//Tuple
let kv:[number, string] = [1,"One"]
kv = [2, 'Two']
console.log(kv[0])

//Enum
enum Gender {
  Male,
  Female,
  Confused
} 
let g: Gender = Gender.Male
console.log(g)

//Unknown
let notSure: unknown = 4;
notSure = "maybe a string instead";
 
// OK, definitely a boolean
notSure = false;

let aNumber :number;
//aNumber = notSure; error without making sure typeof unknown
if (typeof notSure == "number")
  aNumber = notSure
else if (typeof notSure=='string'){
  const aString:string = notSure
}
