using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Housing {
    [ForControllerAttribute(ControllersEnum.Room, Enabled = false)]
    public class FakeRoomController : RoomController,BaseController {

        //static DataTable dt = new DataTable();
        static Dictionary<string,RoomModel> listOfRooms = new Dictionary<string, RoomModel>();
        private static bool dataInitilized = false;
        static Random random = new Random();

        public FakeRoomController() {
            if (!dataInitilized) InitializeMemoryDatabase();
        }
        private void InitializeMemoryDatabase() {
            dataInitilized = true;
            var Room1 = new RoomModel() {
                Room_Name = "A",
                Building_Name = "A",
                Nationality_Code = "BGD",
                Bed_Capacity = 1,
                Number_Of_Windows = 2
            };

            var Room2 = new RoomModel() {
                Room_Name = "B",
                Building_Name = "A",
                Nationality_Code = "IND",
                Bed_Capacity = 4,
                Number_Of_Windows = 1
            };

            var Room3 = new RoomModel() {
                Room_Name = "C",
                Building_Name = "A",
                Nationality_Code = "FIL",
                Bed_Capacity = 2,
                Number_Of_Windows = 3
            };

            this.Insert(Room1);
            this.Insert(Room2);
            this.Insert(Room3);

        }

        public string[] fields { get { return (from property in typeof(RoomModel).GetProperties() select property.Name).ToArray<string>(); } }

        public override DataTable GetTable() {
            return List2DataTable((from object item in listOfRooms.Values select item).ToList(),fields);
        }

        public override void Delete(object _model) {
            RoomModel model = (RoomModel)_model;
            if (listOfRooms.ContainsKey(model.Room_Name)) {
                listOfRooms.Remove(model.Room_Name);
            }
        }

        private void Insert(RoomModel model) {
            var copy = (RoomModel)model.Clone();
            if (copy.Id == 0) copy.Id = Math.Abs( random.Next(1000,2000) );
            copy.Created_By = Session.Instance.CurrentUser==null? "" : Session.Instance.CurrentUser.User_Name;
            copy.Created_On = DateTime.Now;
            listOfRooms[copy.Room_Name] = copy;
            Console.WriteLine("insert: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
        }

        public override object Save(object _model) {
            RoomModel model = (RoomModel)_model;
            if (model.Id == 0) Insert(model);
            else Update(model);
            return (RoomModel)listOfRooms[model.Room_Name].Clone();
        }

        public override List<object> Read() {
            return (from item
                      in listOfRooms.Values.ToList()
                  select item.Clone()).ToList();
        }

        public override List<object> Read(object model, string[] whereFields) {
           var propinfo = typeof(RoomModel).GetProperty(whereFields[0]);
           var list = (from item 
                     in listOfRooms.Values
                  where propinfo.GetValue(model).Equals( propinfo.GetValue(item) )
                 select item.Clone()).ToList();
            return list;
        }

        private static DataTable List2DataTable(List<object> list,string[]fields) {
            var dt = new DataTable();
            foreach (string column in fields) {
                dt.Columns.Add(column);
            }
            foreach(var item in list) {
                dt.Rows.Add(((RoomModel)item).ToObjectArray(fields));
            }
            Console.WriteLine("List2DataTable: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            return dt;
        }

        private void Update(RoomModel model) {
            Console.WriteLine("0.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));

            var copy = (RoomModel)model.Clone();
            if (listOfRooms.ContainsKey(copy.Room_Name)) {

                copy.Updated_By = Session.Instance.CurrentUser == null? "": Session.Instance.CurrentUser.User_Name;
                copy.Updated_On = DateTime.Now;

                Console.WriteLine("1.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
                listOfRooms.Remove(copy.Room_Name);
                listOfRooms[copy.Room_Name] = copy;
                Console.WriteLine("2.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            }
        }
    }
}
