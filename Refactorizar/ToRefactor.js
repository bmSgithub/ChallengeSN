//Refactorizar funciones aplicando buenas practicas

const numbers = [10, 5, 20, 15];
const maxNumber = findMax(numbers);
console.log('Max Number:', maxNumber);

const evenNumbers = filterEvenNumbers(numbers);
console.log('Even Numbers:', evenNumbers);

const word = 'level';
const palindrome = isPalindrome(word);
console.log('Is Palindrome:', palindrome);

const userName = 'John';
const greeting = greet(userName);
console.log(greeting);

function findMax(numbers)
{
    let max = numbers[0];
    for (let i = 1; i < numbers.length; i++){
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

function filterEvenNumbers(numbers) {
    return numbers.filter(n => n % 2 === 0)
}

function isPalindrome(word) {
    const wordArray = word.split('');
    const lastIndex = wordArray.length - 1;
    const newWordArray = []
    for (let i = lastIndex; i >= 0; i--) {
        newWordArray.push(wordArray[i]);
    }
    const newWord = newWordArray.join('');
    return word === newWord;
}

function greet(userName) {
    return userName ? 'Hello, ' + userName + '!' : 'Hello, stranger!';
}

