# Introduction

You have to implement two methods which will be returning the words from the text and reversing them.

# Problem Statement

## 1. GetWordFromText

#### Summary
The first method to implement is `GetWordFromText`. It should return a specific word of an input text. Words are separated by space (`' '`).

#### Examples
```csharp
GetWordFromText("one two three", 2)
``` 
should return `"two"`

--------


```csharp
GetWordFromText("one;two three", 2)
```
should return `"three"`

----------

```csharp
GetWordFromText("one", 1)
```

should return `"one"`

#### Be aware of

When input parameter `wordNumberToFind` is less than 1, the method should throw `ArgumentOutOfRangeException`. 
When input text does not have enough words (`GetWordFromText("one", 2)`), method should throw `ArgumentException`. 
When input is null method should throw `ArgumentNullException`.

The method should ignore all spaces at the beginning and at the end of the input text.


## 2. Reverse

#### Summary
The second method to implement in this task is `Reverse`. It should only return a reversed string of a passed input value.
When input is null method should throw `ArgumentNullException`.

#### Examples
```csharp
Reverse("one")
```
should return `eno`

--------

```csharp
Reverse("abcd dcba")
```
should return `abcd dcba`

#### Be aware of

Method should return empty string, if empty string is passed as an input parameter