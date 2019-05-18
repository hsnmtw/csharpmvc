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

    public class FakeRoomController : IDBController<RoomModel> {

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

            this.insert(Room1);
            this.insert(Room2);
            this.insert(Room3);

        }

        public string Source => "FakeRooms";

        public string[] fields { get { return (from property in typeof(RoomModel).GetProperties() select property.Name).ToArray<string>(); } }

        public DataTable GetTable() {
            return List2DataTable(listOfRooms.Values.ToList(),fields);
        }

        public string convertModelToString(RoomModel model) {
            return model.ToString();
        }

        public void Delete(RoomModel model) {
            if (listOfRooms.ContainsKey(model.Room_Name)) {
                listOfRooms.Remove(model.Room_Name);
            }
        }

        public void insert(RoomModel model) {
            var copy = Clone(model);
            if (copy.Id == 0) copy.Id = Math.Abs( random.Next(1000,2000) );
            copy.Created_By = Session.Instance.CurrentUser.User_Name;
            copy.Created_On = DateTime.Now;
            listOfRooms[copy.Room_Name] = copy;
            Console.WriteLine("insert: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
        }

        public RoomModel Save(RoomModel model) {
            if (model.Id == 0) insert(model);
            else update(model);
            return Clone(listOfRooms[model.Room_Name]);
        }

        public DataTable GetTable(RoomModel model, string[] whereFields) {
            Console.WriteLine("selectModelsAsDataTable: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            return List2DataTable(Read(model,whereFields), fields);
        }

        public List<RoomModel> Read() {
            return (from item
                      in listOfRooms.Values.ToList()
                  select Clone(item)).ToList();
        }

        public List<RoomModel> Read(RoomModel model, string[] whereFields) {
           var propinfo = typeof(RoomModel).GetProperty(whereFields[0]);
           var list = (from RoomModel item 
                     in listOfRooms.Values
                  where propinfo.GetValue(model).Equals( propinfo.GetValue(item) )
                 select Clone(item)).ToList();
            return list;
        }

        private static object[] Model2Object(RoomModel model,string[]fields) {
            object[] objects = new object[fields.Length];
            for (int i= 0;i<fields.Length;i++) {
                var column = fields[i];
                objects[i] = typeof(RoomModel).GetProperty(column).GetValue(model);
            }
            Console.WriteLine("Model2Object: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            return objects;
        }

        private static DataTable List2DataTable(List<RoomModel> list,string[]fields) {
            var dt = new DataTable();
            foreach (string column in fields) {
                dt.Columns.Add(column);
            }
            foreach(var item in list) {
                dt.Rows.Add(Model2Object(item,fields));
            }
            Console.WriteLine("List2DataTable: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            return dt;
        }

        public void update(RoomModel model) {
            Console.WriteLine("0.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));

            var copy = Clone(model);
            if (listOfRooms.ContainsKey(copy.Room_Name)) {

                copy.Updated_By = Session.Instance.CurrentUser.User_Name;
                copy.Updated_On = DateTime.Now;

                Console.WriteLine("1.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
                listOfRooms.Remove(copy.Room_Name);
                listOfRooms[copy.Room_Name] = copy;
                Console.WriteLine("2.update: {0,-20}  :  {1,-20}",  string.Join(",",listOfRooms.Keys.ToList())  , string.Join(",", from vsl in listOfRooms.Values select vsl.Room_Name));
            }
        }

        private static RoomModel Clone(RoomModel model) {
            var copy = new RoomModel();
            foreach (var pinfo in model.GetType().GetProperties()) {
                pinfo.SetValue(copy, pinfo.GetValue(model));
            }
            return copy;
        }
    }
}
