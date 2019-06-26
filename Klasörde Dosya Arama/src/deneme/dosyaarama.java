package deneme;

import java.io.File;
import java.io.IOException;

public class dosyaarama {

	public static void main(String[] args){
		
		try 
		{
			listele("C:/Program Files (x86)");//Bu uzantý içerisinde ki tüm klasörleri gezer.
		}
		catch(IOException e) 
		{
			System.out.print(e);
		}
	}
	
	public static void listele(String url) throws IOException {
		File folder = new File(url);
	
		File[] listOfFiles = folder.listFiles();
	
		 for (File file : listOfFiles)
	        {
	            if (file.isFile())
	            {
	            	if(file.getName().endsWith(".txt")) {//.txt olan dosyalarý bulma kodu.	
	            		System.out.println(file.getPath());//dosyayý, dosya adres yeri ile yazdýrýr.
	            	}									   //.getName() sadece dosya adýný verir.
 	            }
	            else if (file.isDirectory())
	            {
	                listele(file.getAbsolutePath());
	            }
	        }
	}

}
