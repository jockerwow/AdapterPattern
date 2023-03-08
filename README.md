# AdapterPattern

- Summary: A Structural Design Pattern, used to communicate with legacy/external APIs.

- Logic: It depends on creating middle-object (DTO) to memic the external API input object without changing the signature of local object.
An Adapetr can be implemented either by Inheritance or Composition. In this example, Composition was used.

- Result: This results in maintaining the signature of local system objects, and still communicate the required data structure to the remote API.

- The Project contains Two branches: 1- legacy: With legacy code to show the code without implementing the pattern 2- master: with the pattern applied.

- Credits: 
Passionate Coders
https://www.youtube.com/watch?v=9YNAPv4Uz98

