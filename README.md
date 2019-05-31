# csharpmvc
Building a simple WinForms MVC .net framework that simplify the process of building applications
This application is built with the following considerations:
1. Models have properties only
2. Views have no logic, but data display and presentation only
3. Controllers have all of the logic and port all actions to entities
4. Entities define metadata of models and connects to the database 
5. Database type invariant


Dependencies
============

- [V] -> [M]
- [V] -> [C]

- [C] -> [E]
- [C] -> [M]

- [E] -> [M]

V: Views
M: Models
C: Controllers
E: Entities

** The goal is not to have [V] on right side 
** and all others depend on [M]