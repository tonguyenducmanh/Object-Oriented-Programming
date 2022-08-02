namespace abstract_classes
{
    public class Program
    {
        // cho dễ hiểu thì abstract class là thằng ở giữa base class và interface
        // nó cơ bản là sự pha trộn giữa cả 2
        public static void Main(string[] args)
        {
            // nếu chúng ta dùng interface thì có thể tạo ra cả 2 database ví dụ
            // nhưng lại thừa đoạn code bị lặp của cả 2 database là về loadconnectionstring
            //List<IDataAccess> database = new List<IDataAccess>()
            //{
            //    new SqlDataAccess(),
            //    new SqliteDataAccess()
            //};
            //foreach(IDataAccess db in database)
            //{
            //    db.LoadConnectionString("demo");
            //    db.LoadData("select * from table");
            //    db.SaveData("insert into table");
            //    Console.WriteLine();
            //}

            // trong khi nếu dùng base class có tên DataAccess thì lại chỉ dùng được mỗi
            // cái loadconnectionstring, 2 cái loaddata và savedata k thể thêm vào được baseclass
            // vì mỗi cái 1 loại database khác nhau
            // DataAccess da = new DataAccess();
            // da.LoadData => error
            // da.SaveData => error

            // đó là lúc ta thêm chữ abstract vào trong class DataAccess và cho những cái còn lại
            // kế thừa nó, dùng abstract với cả các method, giống interface, chỉ khai báo tên
            // sau đó bên class kế thừa dùng override. khi đó ta có cả việc tiết kiệm code của
            // base class và triển khai code của interface

            //DataAccess da = new SqlDataAccess();
            //da.LoadConnectionString();

            List<DataAccess> database = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };
            foreach (var db in database)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}