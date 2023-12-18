How To Create Windows Form App ? 


=>


1) Go to visual studio => File New Project => Select language C# then Select Windows Platform then Select Project Type Desktop

=> then Select Windows Forms App(.NET Framework) =>Next=> Give Project Name and Location then Select Create.


Your Application will Create



2) Go To Visual Studio View Option and in this select Toolbox to use various tools + In View select Properties Window to set properties.

3) To Create Graphical Changes in Form file 
  Double click on Form1.cs File You will see a Dialogue box is appeared named Form1.cs [Design]
  Then Go To ToolBox and Drag Label => Then Drag TextBox 
  Then Go To ToolBox and Drag Label => Then Drag ListBox 

4) Double Click on Form1.cs file you will see Graphical interface which is "Form1.cs [Design]"
   Then Double click on that Graphical Interface Textbox or Label or Listbox ...It will show Form1.cs file that is actual code.
   So write their your own logic => Double Click on Discover Type Information Button and write below code:

 
	private void button1_Click(object sender, EventArgs e)
    	{
      		string TypeName = textBox1.Text;

  		Type T = Type.GetType(TypeName);

  		listMethods.Items.Clear();
  		listProperties.Items.Clear();
  		listConstructors.Items.Clear();

  		// Methods
 	 	MethodInfo[] methods = T.GetMethods();
  
  		foreach (MethodInfo method in methods)
  		{
      			listMethods.Items.Add(method.ReturnType.Name+" "+method.Name);
  		}

  		// Properties
  		PropertyInfo[] properties = T.GetProperties();

  		foreach(PropertyInfo property in properties)
  		{
      			listProperties.Items.Add(property.PropertyType.Name+" "+property.Name);
  		}

  		// Constructors
  		ConstructorInfo[] constructors = T.GetConstructors();

  		foreach (ConstructorInfo constructor in constructors)
  		{
      			listConstructors.Items.Add(constructor.ToString());
  		}


    	}
   
  
 

5) When you have written all code then Go to Debug => Start Without Debugging   OR press shortcut key (ctrl + f5) and run.
   Then search in textbox of Type Name and click on Discover Type Information Button....you will get desired result.
   Serach (e.g. Type Name = System.Console and click on Discover Type Information Button)
	  (e.g. Type Name = System.String search)

