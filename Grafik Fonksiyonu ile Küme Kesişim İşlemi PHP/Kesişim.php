<?php
header("Content-type: image/png\n\n");
$resim= imagecreate(800,800);
$sari=imagecolorallocate($resim,255,255,255);
$mavi=imagecolorallocate($resim,0,0,0);
imagearc($resim,300,350,400,400,0,360,$mavi);
imagearc($resim,520,350,400,400,0,360,$mavi);

$dizi1=array(1,23,4,6,7,15,49,19);
$dizi2=array(5,3,4,7,9,15,19,23,28,27);

$sayi=230;
$sayi2=200;
$sayi3=200;
$kontrol=0;

imagestring($resim,8,550,130,"B",$mavi);
imagestring($resim,8,400,155,"AB",$mavi);
imagestring($resim,8,250,130,"A",$mavi);
foreach($dizi1 as $eleman)
{

  foreach($dizi2 as $eleman2 )
  {
	  
	   if($eleman==$eleman2)
	   {
		   array_unshift($dizi2,$eleman2);
		   array_shift($dizi2);
		   imagestring($resim,4,400,$sayi,$eleman,$mavi);
		   $sayi=$sayi+30;
		   $kontrol=0;

		   break;
	   }
	   else
	   {
		   $kontrol=1;
	   }
  }
  if($kontrol==1)
  {
	   imagestring($resim,4,250,$sayi2,$eleman,$mavi);
	   $sayi2=$sayi2+30;
	   $kontrol=0;
  }
}
$kontrol5=0;
foreach($dizi2 as $eleman3){
	
  foreach($dizi1 as $eleman4 ){
	  
	   if($eleman3==$eleman4){
		   $kontrol5=0;
		   break;
	   }
	   else{
		    $kontrol5=1;	
	   }
  }
  if($kontrol5==1){	  
	   imagestring($resim,4,550,$sayi3,$eleman3,$mavi);
	 $sayi3=$sayi3+30;
	 $kontrol5=0;
  }  
}

imagepng($resim);

?>
