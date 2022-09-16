using System;

public class User{

 public static void Main(string[] args) {
    while (true) {
     Console.WriteLine("");
     Console.WriteLine("Please input");
     Console.WriteLine("Input A สำหรับดูข้อมูลของมหาวิทยาลัย");
     Console.WriteLine("Input B แสดงข้อมูลตัวแทนมหาวิทยาลัย");
     Console.WriteLine("Input C แสดงข้อมูลห้องสมุดมหาวิทยาลัยที่ใช้ไฟน้อยที่สุด");
     Console.WriteLine("Input E เพื่อออกจากโปรแกรม");
     Console.WriteLine("");
     var input = Console.ReadLine();
     if (input=="A"){
        Console.Write(cu.name());
        Console.Write(" "+cu.libraly());
        Console.Write(" "+cu.address());
        Console.WriteLine(" "+cu.phone());

        Console.Write(mu.name());
        Console.Write(" "+mu.libraly());
        Console.Write(" "+mu.address());
        Console.WriteLine(" "+mu.phone());

        Console.Write(kmitl.name());
        Console.Write(" "+kmitl.libraly());
        Console.Write(" "+kmitl.address());
        Console.WriteLine(" "+kmitl.phone());

        Console.Write(kku.name());
        Console.Write(kku.libraly());
        Console.Write(kku.address());
        Console.WriteLine(kku.phone());

        Console.Write(kmutt.name());
        Console.Write(" "+kmutt.libraly());
        Console.Write(" "+kmutt.address());
        Console.WriteLine(" "+kmutt.phone());


     }

     if (input=="B"){
        Console.Write(cu.name());
        Console.WriteLine(" "+cu.agent());


        Console.Write(mu.name());
        Console.WriteLine(" "+mu.agent());


        Console.Write(kmitl.name());
        Console.WriteLine(" "+kmitl.agent());


        Console.Write(kku.name());
        Console.WriteLine(" "+kku.agent());


        Console.Write(kmutt.name());
        Console.WriteLine(" "+kmutt.agent());



     }

     if (input=="C"){
        if (sort.bill()==cu.bill()){
        Console.Write(cu.name());
        Console.Write(" "+cu.libraly());
        Console.Write(" ค่า FT: "+cu.ft());
        Console.WriteLine(" ค่าไฟ: "+cu.bill());
         }

        if (sort.bill()==mu.bill()){
        Console.Write(mu.name());
        Console.Write(" "+mu.libraly());
        Console.Write(" ค่า FT: "+mu.ft());
        Console.WriteLine(" ค่าไฟ: "+mu.bill());
         }

        if (sort.bill()==kmitl.bill()){
        Console.Write(kmitl.name());
        Console.Write(" "+kmitl.libraly());
        Console.Write(" ค่า FT: "+kmitl.ft());
        Console.WriteLine(" ค่าไฟ: "+kmitl.bill());
         }

        if (sort.bill()==kku.bill()){
        Console.Write(kku.name());
        Console.Write(" "+kku.libraly());
        Console.Write(" ค่า FT: "+kku.ft());
        Console.WriteLine(" ค่าไฟ: "+kku.bill());
         }

        if (sort.bill()==kmutt.bill()){
        Console.Write(kmutt.name());
        Console.Write(" "+kmutt.libraly());
        Console.Write(" ค่า FT: "+kmutt.ft());
        Console.WriteLine(" ค่าไฟ: "+kmutt.bill());
         }


     }

     if (input=="E"){
        break;
     }
    }
 }

public  class sort{
    public static double bill(){
       double[] bill = {cu.bill(),mu.bill(),kmitl.bill(),kku.bill(),kmitl.bill(),kmutt.bill()};
       Array.Sort(bill);
       double min = bill[0];
    return min;
    }
}


}

public class cu{
     public static string name(){
     var input = "จุฬาลงกรณ์มหาวิทยาลัย"; 
     return input;
     }

     public static string libraly(){
     var input = "รักดี"; 
     return input;
     }

     public static string address(){
     var input = "เขตปทุมวัน กรุงเทพมหานคร"; 
     return input;
     }

     public static string phone(){
     var input = "02-215-3555"; 
     return input;
     }
     public static string agent(){
     var input = "นายชัยดี"+"รักดี"+"เลขบัตรประชาชน: 153-698-4561237"; 
     return input;
     }
    public static double ft(){
     var ft1 = 10.2;
     var ft2 = 7.3;
     var ft3 = 8.4;
     var ft4 = 5.6;
     var ft5 = 9.3;
     var ft6 = 4.6;
     var ft7 = 1.2;
     var ft8 = 7.5;
     var ft9 = 8.2;
     var ft10 = 4.3;
     var ft11 = 6.0;
     var ft12 = 7.0;

     var input = + ft1 + ft2 + ft3 + ft4 + ft5 + ft6 + ft7 + ft8 + ft9 + ft10 + ft11 +ft12;
     return input;
     }
    public static int bill(){
     var bill1 = 955;
     var bill2 = 742;
     var bill3 = 873;
     var bill4 = 511;
     var bill5 = 921;
     var bill6 = 461;
     var bill7 = 122;
     var bill8 = 521;
     var bill9 = 751;
     var bill10 = 432;
     var bill11 = 611;
     var bill12 = 711;

     var input = + bill1 + bill2 + bill3 + bill4 + bill5 + bill6 + bill7 + bill8 + bill9 + bill10 + bill11 +bill12;
     return input;
     }


}
public class mu{


     public static string name(){
     var input = "มหาวิทยาลัยมหิดล"; 
     return input;
     }

     public static string libraly(){
     var input = "รักโลก"; 
     return input;
     }

     public static string address(){
     var input = "เขตศาลายานครปฐม"; 
     return input;
     }

     public static string phone(){
     var input = "02-215-3555"; 
     return input;
     }
    public static string agent(){
     var input = "นายนอนดี"+"ใจดี"+"เลขบัตรประชาชน: 742-112-5687412"; 
     return input;
     }

    public static double ft(){
     var ft1 = 9.2;
     var ft2 = 5.2;
     var ft3 = 8.9;
     var ft4 = 7.1;
     var ft5 = 9.3;
     var ft6 = 2.2;
     var ft7 = 1.7;
     var ft8 = 5.2;
     var ft9 = 9.1;
     var ft10 = 8.4;
     var ft11 = 2.1;
     var ft12 = 2.3;

     var input = + ft1 + ft2 + ft3 + ft4 + ft5 + ft6 + ft7 + ft8 + ft9 + ft10 + ft11 +ft12;
     return input;
     }
    public static int bill(){
     var bill1 = 911;
     var bill2 = 501;
     var bill3 = 891;
     var bill4 = 712;
     var bill5 = 921;
     var bill6 = 461;
     var bill7 = 171;
     var bill8 = 521;
     var bill9 = 901;
     var bill10 = 831;
     var bill11 = 451;
     var bill12 = 453;

     var input = + bill1 + bill2 + bill3 + bill4 + bill5 + bill6 + bill7 + bill8 + bill9 + bill10 + bill11 +bill12;
     return input;
     }


}
public class kmitl{


     public static string name(){
     var input = "สถาบันเทคโนโลยีพระจอมเกล้าเจ้าคุณทหารลาดกระบัง"; 
     return input;
     }

     public static string libraly(){
     var input = "เกย์กีย์"; 
     return input;
     }

     public static string address(){
     var input = "เขต ลาดกระบัง"; 
     return input;
     }

     public static string phone(){
     var input = "02-849-6211"; 
     return input;
     }

    public static string agent(){
     var input = "นายอภัยดี"+"เรียนดี"+"เลขบัตรประชาชน: 541-772-3215689"; 
     return input;
     }
    public static double ft(){
     var ft1 = 17.2;
     var ft2 = 19;
     var ft3 = 23;
     var ft4 = 25.1;
     var ft5 = 31;
     var ft6 = 32.1;
     var ft7 = 17.0;
     var ft8 = 14;
     var ft9 = 11.3;
     var ft10 = 18.1;
     var ft11 = 19.2;
     var ft12 = 22;

     var input = + ft1 + ft2 + ft3 + ft4 + ft5 + ft6 + ft7 + ft8 + ft9 + ft10 + ft11 +ft12;
     return input;
     }
    public static int bill(){
     var bill1 = 1721;
     var bill2 = 1911;
     var bill3 = 2311;
     var bill4 = 2511;
     var bill5 = 3111;
     var bill6 = 3211;
     var bill7 = 1711;
     var bill8 = 1411;
     var bill9 = 1131;
     var bill10 = 1811;
     var bill11 = 2121;
     var bill12 = 2211;

     var input = + bill1 + bill2 + bill3 + bill4 + bill5 + bill6 + bill7 + bill8 + bill9 + bill10 + bill11 +bill12;
     return input;
     }

}
public class kku{


     public static string name(){
     var input = "มหาวิทยาลัยขอนแก่น"; 
     return input;
     }

     public static string libraly(){
     var input = "อาธร"; 
     return input;
     }

     public static string address(){
     var input = "เขตในเมือง ขอนแก่น"; 
     return input;
     }

     public static string phone(){
     var input = "043-002539"; 
     return input;
     }

    public static string agent(){
     var input = "นายทำดี"+"งานดี"+"เลขบัตรประชาชน: 777-772-4578923"; 
     return input;
     }
    public static double ft(){
     var ft1 = 2.1;
     var ft2 = 2.0;
     var ft3 = 1.1;
     var ft4 = 1.5;
     var ft5 = 3.2;
     var ft6 = 4.1;
     var ft7 = 2.2;
     var ft8 = 2.2;
     var ft9 = 1.3;
     var ft10 = 1.4;
     var ft11 = 5.0;
     var ft12 = 4.1;

     var input = + ft1 + ft2 + ft3 + ft4 + ft5 + ft6 + ft7 + ft8 + ft9 + ft10 + ft11 +ft12;
     return input;
     }
    public static int bill(){
     var bill1 = 451;
     var bill2 = 411;
     var bill3 = 110;
     var bill4 = 150;
     var bill5 = 321;
     var bill6 = 610;
     var bill7 = 462;
     var bill8 = 462;
     var bill9 = 131;
     var bill10 = 141;
     var bill11 = 510;
     var bill12 = 610;

     var input = + bill1 + bill2 + bill3 + bill4 + bill5 + bill6 + bill7 + bill8 + bill9 + bill10 + bill11 +bill12;
     return input;
     }

}

public class kmutt{


     public static string name(){
     var input = "มหาวิทยาลัยเทคโนโลยีพระจอมเกล้าธนบุรี"; 
     return input;
     }

     public static string libraly(){
     var input = "รักโลก"; 
     return input;
     }

     public static string address(){
     var input = "กรุงเทพมหานคร"; 
     return input;
     }

     public static string phone(){
     var input = "02-470-8000"; 
     return input;
     }

    public static string agent(){
     var input = "นายนอนดี"+"เรียบดี"+"เลขบัตรประชาชน: 003-852-4752000"; 
     return input;
     }
    public static double ft(){
     var ft1 = 17.2;
     var ft2 = 20;
     var ft3 = 23;
     var ft4 = 25.1;
     var ft5 = 31;
     var ft6 = 32.1;
     var ft7 = 17.0;
     var ft8 = 14;
     var ft9 = 11.3;
     var ft10 = 18.1;
     var ft11 = 19.2;
     var ft12 = 22;

     var input = + ft1 + ft2 + ft3 + ft4 + ft5 + ft6 + ft7 + ft8 + ft9 + ft10 + ft11 +ft12;
     return input;
     }
    public static int bill(){
     var bill1 = 1721;
     var bill2 = 2111;
     var bill3 = 2311;
     var bill4 = 2511;
     var bill5 = 3111;
     var bill6 = 610;
     var bill7 = 1711;
     var bill8 = 1411;
     var bill9 = 1131;
     var bill10 = 510;
     var bill11 = 2121;
     var bill12 = 2211;

     var input = + bill1 + bill2 + bill3 + bill4 + bill5 + bill6 + bill7 + bill8 + bill9 + bill10 + bill11 +bill12;
     return input;
     }

}
