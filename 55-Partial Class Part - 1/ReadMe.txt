
For Creating Project Demo_Partial_Class :


Go to visual studio and select new project => then select template of ASP.NET Web Application(.NET Framework) with Web Form.

==============================================================================================================================


Partial classes allow us to split a class into 2 or more files. All these parts are then combined into a single class, when the application is compiled. The partial keyword can also be used to split a struct or an interface over two or more files.

Advantages of partial classes

1. The main advantage is that, visual studio uses partial classes to separate, automatically generated system code from the developer's code. For example, when you add a webform, two.CS files are generated

A a) WebForm1.aspx.cs-Contains the developer code

b) WebForm1.aspx.designer.cs-Contains the system generated code. For example, declarations for the controls that you drag and drop on the webform.

A 2. When working on large projects, spreading a class over separate files allows multiple

programmers to work on it simultaneously. Though, Microsoft claims this as an advantage, I haven't really seen anywhere, people using partial classes, just to work on them simultaneously.