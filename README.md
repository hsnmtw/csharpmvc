# csharpmvc
Building a simple WinForms MVC .net framework that simplify the process of building applications
This application is built with the following considerations:
1. Models have properties only
2. Views have no logic, but data display and presentation only
3. Controllers perform validation on models before passing them to Entities, also perform complex logic 
   and acts as middle person between entities and views
4. Entities define metadata of models and connects to the database, execute and runs queries 
5. Database type invariant


## Dependencies
```
      [C]  
    ↗  ↓   ↘ 
[V] → [M] ← [E]

[C] → [E]        
[V] → [C]        
[V] → [M]                 
[C] → [M]
[E] → [M]

V: Views
M: Models
C: Controllers
E: Entities
```
** The goal is to have [V] on right side 
** and all others depend on [M]
** [V] should not communicate directly to [E]

## Example code
```
  
  // Model
  public class ExampleModel : BaseModel{
    public string ExampleProperty {get; set;}
  }
  
  //Entity
  public class ExampleEntity : AbstractDBEntity<ExampleModel> {
         public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> { "ReadOnly","Id","CreatedBy","CreatedOn",
                                                       "UpdatedBy","UpdatedOn", "ExampleProperty" }  
            , RequiredFields   = new HashSet<string> { "Id", "ExampleProperty" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "ExampleProperty" } }
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
     private Label   lblExampleProperty;
	 private TextBox txtExampleProperty;
	 private Button  btnSave, btnDelete, btnNew;
	 
	 public void InitializeComponent(){
		lblExampleProperty = new Label()  { Text = "Example:" , Left = 10, Top = 10 };
		txtExampleProperty = new TextBox(){ Text = ""         , Left = 10, Top = 30 };
		btnDelete = new Button()          { Text = "Delete"   , Left = 10, Top = 55 };
		btnSave   = new Button()          { Text = "Save"     , Left = 10, Top = 75 };
		btnNew    = new Button()          { Text = "New"      , Left = 10, Top = 95 };		
		Controls.AddRange(new Control[]{ txtExampleProperty,btnDelete, btnNew, btnSave });
	 }
	 
	 public ExampleView(){
		InitializeComponent();
		
        Mapper["ExampleProperty"] = txtExampleProperty;  // this will bind textbox to model value
        
        //define actions
        SaveButton   = btnSave;                          
        DeleteButton = btnDelete;                        
        NewButton    = btnNew;
     }
  }
  
  //Main view
  public class MainView{
	public static void Main(){
		var form = new Form(){ Width = 400, Height = 400 };
		form.Controls.Add(new ExampleView(){ Dock = DockStyle.Fill });
		Application.EnableVisualStyles();
		Application.Run(form);
	}
  }
  
```
