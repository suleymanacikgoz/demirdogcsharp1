using System;

namespace demirdogcsharp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string kategorietiketi = "kategori";
			int x = 13;
			bool sistemegirisyapmismi = true;
			double z = 13.2;
			double DolanDun = 7.35;
			double DolarBugun = 7.45;

            if (DolanDun>DolarBugun)
            {
				Console.WriteLine("azalış butonu");
            }
			else if (DolanDun<DolarBugun)
            {



				Console.WriteLine("artış butonu");
            }
            else
            {

				Console.WriteLine("değişmedi butonu");


            }

			Console.WriteLine(kategorietiketi);

            if (sistemegirisyapmismi==true)
            {
				Console.WriteLine("sisteme giriş yapıldı");
            }
			else
            {

				Console.WriteLine("giriş yapılmadı");

            }

			
		}
	}
}
