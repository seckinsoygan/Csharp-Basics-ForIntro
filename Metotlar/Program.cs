using Metotlar;

User mynewUser=new User();
mynewUser.Mail = "seckinsoygann@gmail.com";
mynewUser.Password = "12345";

User mynewUser2 = new User();
mynewUser2.Mail = "seckinsoy48@gmail.com";
mynewUser2.Password = "54231";

Console.WriteLine(mynewUser.Mail);
Console.WriteLine(mynewUser.Password);

User.Metot1(mynewUser);

Console.Read();
