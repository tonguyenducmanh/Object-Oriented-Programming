namespace interfaces_namespace
{
    public class Program
    {
        // interface đơn giản là 1 bản hợp đồng
        // nó nói rằng đây là những thứ mà những class kế thừa nó sẽ có
        // đã là hợp đồng thì mọi thứ trong đó đều ở dạng công khai
        // tức là public. nếu k thì làm sao mọi người thấy được nó
        // interface không quan tâm class có thêm những gì
        // nó chỉ quan tâm class phải có ít nhất những thứ mà nó có
        // nếu đặt kiểu dữ liệu là interface thì list có thể chứa nhiều
        // type hơn á. 
        // interface luôn đứng sau base class lúc kế thừa ( ý là base class bắt
        // buộc phải sau dấu :
        // vì ngôn ngữ CSharp chỉ cho kế thừa từ 1 class, và kế thừa từ nhiều Interface
        // hiểu đơn giản là 1 cô gái chỉ có thể có 1 người bố thôi
        // nhưng mà có thể có nhiều hợp đồng, nhiều bằng cấp (như học nhiều trường đại học),...
        public static void Main()
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();
            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel()
            {
                FirstName = "Manh",
                LastName = "Duc",
                City = "HaNoi",
                EmailAddress = "ducmanh14032000@gmail.com",
                PhoneNumber = "0981071321"
            };
        }
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Neft Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Chung Ta Cua Hien Tai"});

            return output;
        }
    }
}