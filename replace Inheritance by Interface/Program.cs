// tất cả những gì kết nối các class phương tiện khác nhau là IRental, nó
// chỉ cho thấy những loại phương tiện đó có những property gì khi cho thuê
// nó không phải là mối quan hệ giữa các class, tách nó thành Interface sẽ
// giúp chúng ta tránh lỗi khi cố gắng triển khai nhiều class kế thừa từ 1 class cha
// mà lại phải kế thừa cả những method hay property phi logic với thực tế
// như là 1 chiếc  thuyền buồm cũng là 1 loại phương tiện, nhưng nó k có động cơ
namespace replace_Inheritance_by_Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();
            rentals.Add(new Truck() { CurrentRenter="truck renter"});
            rentals.Add(new Sailboat() { CurrentRenter= "sailboat renter" });
            rentals.Add(new Car() { CurrentRenter= "car renter" });
            foreach(IRental r in rentals)
            {
                if(r is Truck t)
                {
                    
                }
                if (r is Sailboat s)
                {

                }
            }
        }
    }
}