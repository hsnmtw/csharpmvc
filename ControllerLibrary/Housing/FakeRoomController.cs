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
    [ForControllerAttribute(Entities.Room, Enabled = false)]
    public class FakeRoomController : BaseController {

        //static DataTable dt = new DataTable();
        static Dictionary<string, RoomModel> listOfRooms = new Dictionary<string, RoomModel>();
        private static bool dataInitilized = false;
        static Random random = new Random();

        public FakeRoomController() {
            if (!dataInitilized) InitializeMemoryDatabase();
        }
        private void InitializeMemoryDatabase() {
            dataInitilized = true;
            var Room1 = new RoomModel() {
                RoomName = "A",
                BuildingName = "A",
                CountryCode = "BGD",
                BedCapacity = 1,
                NumberOfWindows = 2
            };

            var Room2 = new RoomModel() {
                RoomName = "B",
                BuildingName = "A",
                CountryCode = "IND",
                BedCapacity = 4,
                NumberOfWindows = 1
            };

            var Room3 = new RoomModel() {
                RoomName = "C",
                BuildingName = "A",
                CountryCode = "FIL",
                BedCapacity = 2,
                NumberOfWindows = 3
            };

            this.Insert(Room1);
            this.Insert(Room2);
            this.Insert(Room3);

        }

        public string[] fields { get { return (from property in typeof(RoomModel).GetProperties() select property.Name).ToArray<string>(); } }

        public DataTable GetTable() {
            return List2DataTable((from object item in listOfRooms.Values select item).ToList(), fields);
        }

        public DBModificationResult Delete(object roomModel) {
            RoomModel model = (RoomModel)roomModel;
            if (listOfRooms.ContainsKey(model.RoomName)) {
                listOfRooms.Remove(model.RoomName);
            }
            return new DBModificationResult() { };
        }

        private void Insert(RoomModel model) {
            var copy = (RoomModel)model.Clone();
            if (copy.Id == 0) copy.Id = Math.Abs(random.Next(1000, 2000));
            copy.CreatedBy = Session.Instance.CurrentUser == null ? "" : Session.Instance.CurrentUser.UserName;
            copy.CreatedOn = DateTime.Now;
            listOfRooms[copy.RoomName] = copy;
            Console.WriteLine("insert: {0,-20}  :  {1,-20}", string.Join(",", listOfRooms.Keys.ToList()), string.Join(",", from vsl in listOfRooms.Values select vsl.RoomName));
        }

        public DBModificationResult Save(object roomModel) {
            RoomModel model = (RoomModel)roomModel;
            if (model.Id == 0) Insert(model);
            else Update(model);
            return new DBModificationResult() {
                Result = (RoomModel)listOfRooms[model.RoomName].Clone()
            };
        }

        public List<object> Read() {
            return (from item
                      in listOfRooms.Values.ToList()
                    select item.Clone()).ToList();
        }

        public List<object> Read(object model, string[] whereFields) {
            var propinfo = typeof(RoomModel).GetProperty(whereFields[0]);
            var list = (from item
                      in listOfRooms.Values
                        where propinfo.GetValue(model).Equals(propinfo.GetValue(item))
                        select item.Clone()).ToList();
            return list;
        }

        private static DataTable List2DataTable(List<object> list, string[] fields) {
            var dt = new DataTable();
            foreach (string column in fields) {
                dt.Columns.Add(column);
            }
            foreach (var item in list) {
                dt.Rows.Add(((RoomModel)item).ToObjectArray(fields));
            }
            Console.WriteLine("List2DataTable: {0,-20}  :  {1,-20}", string.Join(",", listOfRooms.Keys.ToList()), string.Join(",", from vsl in listOfRooms.Values select vsl.RoomName));
            return dt;
        }

        private void Update(RoomModel model) {
            Console.WriteLine("0.update: {0,-20}  :  {1,-20}", string.Join(",", listOfRooms.Keys.ToList()), string.Join(",", from vsl in listOfRooms.Values select vsl.RoomName));

            var copy = (RoomModel)model.Clone();
            if (listOfRooms.ContainsKey(copy.RoomName)) {

                copy.UpdatedBy = Session.Instance.CurrentUser == null ? "" : Session.Instance.CurrentUser.UserName;
                copy.UpdatedOn = DateTime.Now;

                Console.WriteLine("1.update: {0,-20}  :  {1,-20}", string.Join(",", listOfRooms.Keys.ToList()), string.Join(",", from vsl in listOfRooms.Values select vsl.RoomName));
                listOfRooms.Remove(copy.RoomName);
                listOfRooms[copy.RoomName] = copy;
                Console.WriteLine("2.update: {0,-20}  :  {1,-20}", string.Join(",", listOfRooms.Keys.ToList()), string.Join(",", from vsl in listOfRooms.Values select vsl.RoomName));
            }
        }

        public MetaData GetMetaData() =>
            BaseCollection.MetaData;
         

        public DataTable GetTable(object model, string[] whereFields, bool like = false) =>
            List2DataTable(listOfRooms.Values.ToList<object>(), new string[] { });
        
        public ResultSet GetTable(object model, string[] whereFields, bool like, int offset, int length) {
            return new ResultSet() {
                Table = GetTable()
            };
        }

        private BaseEntity BaseCollection => EntitiesFactory.GetEntity(Entities.Room);

        public object CreateNewModel() => 
            this.BaseCollection.CreateNew();
        

        public object Dispatch(string action, params object[] arguments) {
            throw new NotImplementedException();
        }
    }
}
