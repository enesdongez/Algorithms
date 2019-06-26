package deneme;

import java.io.File;
import java.io.IOException;

public class dosyaarama {

	public static void main(String[] args){
		
		try 
		{
			listele("C:/Program Files (x86)");//Bu uzant� i�erisinde ki t�m klas�rleri gezer.
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
	            	if(file.getName().endsWith(".txt")) {//.txt olan dosyalar� bulma kodu.	
	            		System.out.println(file.getPath());//dosyay�, dosya adres yeri ile yazd�r�r.
	            	}									   //.getName() sadece dosya ad�n� verir.
 	            }
	            else if (file.isDirectory())
	            {
	                listele(file.getAbsolutePath());
	            }
	        }
	}

}
