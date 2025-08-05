//Refactorizar funciones aplicando buenas practicas

function findMax(numbers) {
    var max = 0;
    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
    }
    return max;
}

function filterEvenNumbers(numbers) {
    var evenNumbers = [];
    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] % 2 == 0) {
            evenNumbers.push(numbers[i]);
        }
    }
    return evenNumbers;
}

function isPalindrome(word) {
    var array = word.split('')
    var newWordArray = []
    for (var i = numbers.length; i >= 0; i--) {
        newWordArray.push(array[i]);
    }
    var newWord = newWordArray.join('');
    return word === newWord;
}

function greet(name) {
    if (name) return 'Hello, ' + name + '!';
    else return 'Hello, stranger!';    
}

var numbers = [10, 5, 20, 15];
var maxNumber = findMax(numbers);
console.log('Max Number:', maxNumber);

var word = 'level';
var palindrome = isPalindrome(word);
console.log('Is Palindrome:', palindrome);

var evenNumbers = filterEvenNumbers(numbers);
console.log('Even Numbers:', evenNumbers);

var name = 'John';
var greeting = greet(name);
console.log(greeting);