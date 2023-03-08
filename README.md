# AdapterPattern

Summary: Used to communicate with legacy/external APIs.

Logic: It depends on creating middle-object (DTO) to memic the external API input object without changing the signature of local object.

Result: This results in maintaining the signature of local system objects, and still communicate the required data structure to the remote API.

The Project contains Two branches: 1- legacy: With legacy code to show the code without implementing the pattern 2- master: with the pattern applied.

