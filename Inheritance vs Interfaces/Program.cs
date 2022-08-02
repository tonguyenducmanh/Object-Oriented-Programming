// Inheritance kế thừa là khi bạn cho 1 class con thừa hưởng lại toàn bộ method,
// property của class cha ( cha có code gì con có code đấy ), chỉ có thể có 1 class cha
// Interface giao diện là 1 bản hợp đồng, mỗi bản hợp đồng sẽ công khai toàn bộ
// tên method, property nhưng k có cách thực hiện ( code bên trong ), mỗi class
// áp dụng hợp đồng sẽ tự triển khai toàn bộ thông tin đó, có thể có nh hợp đồng
// hãy tự hỏi bản thân What is the point ?
// Inheritance không phải là share code, nếu muốn share code thì có nhiều cách
// nếu muốn share code thì có thể đặt code đó vào 1 class riêng và gọi class đó trong class
// khác là được. Dùng kế thừa khi mà có 1 mối quan hệ, ví dụ như class cat và class animal
// class car không thể là class con của class house  mặc dù nó cùng có thể có người bên trong
// cả class cha và class con phải có cùng logic => chỉ chia sẻ method signature và
// property là chưa đủ. nếu share code xong lại override liên tục thì chỉ tốn thêm code.
// kế thừa có thể khiến code ngày càng đi vào 1 góc, ví dụ phương tiện => xe => xe ô tô
// => thuyền k có động cơ, thuyền có động cơ ,.... => chúng ta sẽ có những method k dùng làm gì
// những method k làm gì không nên được gọi. => chúng ta có những đoạn mã chủ động biết bị lỗi
// nếu chúng ta cứ phải override method ngay từ đầu, tại mọi class con thì việc tạo ra
// method gốc để làm gì.
namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
    }
    
}