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
  public class ExampleEntity : AbstractDBEntity {
         public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ExampleModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "ExampleProperty" }
            , UniqueKeyFields  = new List<string> { "ExampleProperty" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"       ] = 50,
                ["UpdatedBy"       ] = 50,
                ["ExampleProperty" ] = 25,
            }
            , Source           = "ExampleTable"

        };
    }
  }
 
  //Controller
   public class ExampleController : AbstractDBController {
        public ExampleController() : base(DBEntitiesFactory.GetEntity(MODELS.Example)) {}

        public override bool Validate<M>(M model) {
            return base.Validate(model);
        }
    }
 
 //View extends UserControl
 public class ExampleView : BaseView<ExampleModel, ExampleController> { 
 
 }
```
