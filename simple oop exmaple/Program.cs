using System;
public class PhuNu
{
    public PhuNu(string ht, int t, bool zin = true)
    {
        hoTen = ht;
        conZin = zin;
        tuoi = t;
    }

    public void TrangDiem()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(hoTen + " đang trang điểm");
    }
    public string ChoiNhacCu(string nhacCu)
    {
        return nhacCu;
    }

    public virtual void TiengKeu()
    {
        Console.WriteLine(hoTen + " đang kêu A A A A A ....");
    }
    // tính trừu tượng, bên ngoài muốn truy cập thì không thể truy cập tùy ý
    // mà phải thông qua method mà chúng ta cung cấp
    public string ShowTen()
    {
        return hoTen;
    }

    public void VaZin()
    {
        if (tuoi < 25)
        {
            conZin = true;
        }
    }

    public void PhaZin()
    {
        conZin = false;
    }

    public bool ShowHang()
    {
        return conZin;
    }

    // tính đóng gói, các giá trị không thể truy cập trực tiếp từ bên ngoài
    protected string hoTen;
    protected bool conZin;
    protected int tuoi;
}

public class GaiNgoan : PhuNu
{
    // tính kế thừa, các class con sẽ sở hữu toàn bộ
    // method và property của class cha
    public GaiNgoan(string ht, int t, bool zin = true) : base(ht, t, zin)
    { }
    public void NoiTro()
    {
        Console.WriteLine(hoTen + " đang làm nội trợ");
    }
    // tính đa hình, mỗi class con sẽ có những hình thái khác nhau thay vì giống
    // hoàn toàn với class cha
    // ở đây gái ngoan sẽ có tiếng kêu 1 kiểu, gái hư sẽ có tiếng kêu 1 kiểu khác nhau
    public override void TiengKeu()
    {
        Console.WriteLine(hoTen + " đang kêu O O O O O ....");
    }
}
public class GaiHu : PhuNu
{
    public GaiHu(string ht, int t, bool zin = true) : base(ht, t, zin)
    { }
    public void DiBar()
    {
        Console.WriteLine(hoTen + " đang đi vô bar á");
    }
    public override void TiengKeu()
    {
        Console.WriteLine(hoTen + " đang kêu Uh Uh Uh Uh Uh ....");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        PhuNu mariaOzawa = new GaiNgoan("mariaOzawa", 29, false);
        mariaOzawa.PhaZin();
        mariaOzawa.VaZin();
        Console.WriteLine(mariaOzawa.ShowTen() + " " + $"{(mariaOzawa.ShowHang() ? "còn zin" : "đã mất zin")}");
        mariaOzawa.TrangDiem();
        //mariaOzawa.NoiTro();
        mariaOzawa.TiengKeu();

        Console.WriteLine("\n");

        PhuNu riku = new GaiHu("riku", 20, false);
        riku.PhaZin();
        riku.VaZin();
        Console.WriteLine(riku.ShowTen() + " " + $"{(riku.ShowHang() ? "còn zin" : "đã mất zin")}");
        riku.TrangDiem();
        //riku.DiBar();
        riku.TiengKeu();
    }
}