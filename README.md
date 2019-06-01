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
<pre>
- [V] -> [M]
- [V] -> [C]
- [C] -> [E]
- [C] -> [M]
- [E] -> [M]

V: Views
M: Models
C: Controllers
E: Entities
</pre>
** The goal is not to have [V] on right side 
** and all others depend on [M]

Example code
=============
```
  
  // Model
  public class ExampleModel : BaseModel{
    public string ExampleProperty {get; set;}
  }
  
  //Entity
  public class ExampleEntity : AbstractDBEntity<ExampleModel> {
         public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
			, Fields           = new HashSet<string> { "ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn", "ExampleProperty" }  
            , RequiredFields   = new HashSet<string> { "Id", "ExampleProperty" }
            , UniqueKeyFields  = new HashSet<string> { "ExampleProperty" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes            = new Dictionary<string, int> {
                ["CreatedBy"       ] = 50,
                ["UpdatedBy"       ] = 50,
                ["ExampleProperty" ] = 25,
            }
            , Source           = "ExampleTable"

        };
    }
  }
 
 //Controller
 public class ExampleController : AbstractDBController<ExampleModel> {
 }
 
 //View
 public class ExampleView : BaseView<ExampleModel, ExampleController> {  
    public ExampleView(){
	
	   Mapper["ExampleProperty"] = txtExampleProperty;  // this will bind textbox to model value
	   
	   //define actions
	   SaveButton   = btnSave;                          
	   DeleteButton = btnDelete;                        
	   NewButton    = btnNew;
	}
 }
```
