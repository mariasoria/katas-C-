# Kata Password Validator

## Description
Your job is to create a simple password validation function, as seen on many websites.

The rules for a valid password are as follows:

- Have more than 8 characters
- Contains at least an uppercase
- Contains at least a lowercase
- Contains at least a number
- Contains at least an underscore

## Examples
- password("Abcd1234"); ===> true
- password("Abcd123"); ===> false
- password("abcd1234"); ===> false
- password("AbcdefGhijKlmnopQRsTuvwxyZ1234567890"); ===> true
- password("ABCD1234"); ===> false
- password("Ab1!@#$%^&*()-_+={}[]|\:;?/>.<,"); ===> true;
- password("!@#$%^&*()-_+={}[]|\:;?/>.<,"); ===> false;


## Extra info
- You will only be passed strings.
- The string can contain any standard keyboard character.
- Accepted strings can be any length, as long as they are 8 characters or more.