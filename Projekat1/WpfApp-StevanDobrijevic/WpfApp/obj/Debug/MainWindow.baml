   M S B A M L   `   `   `  ????A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5          ? Title$   Airsoft team ''Wild Hogs''??5   	   $	??540??6,   $	??900??69   $??
Sitka Text)?6E   ??5	      ?? 5
   
    ?? ImageSource$[ Uhttp://pantex.com.ua/media/zoo/images/multicam_b_5d22ad4fc000f0146710c7135b8c7ecb.jpg??6   .??5      ? .+?5   
   ?? $
??Left=?6   $??17??6/   $??
30,415,0,0q?6;   ???	#FFB49560$	??Top=?6b   $	??830??6z   ???	#FFD1B4826?   ?? 5   
   -   5         ??Name$ buttonDodajNovogClana??5      $??Dodaj novog clana??60   $
??Left=?6L   $??43??6g   $??
30,446,0,0q?6s   $	??Top=?6?   $	??180??6?   ???	#FFD1B482???	#FFB49560???	#FFE62C2C$??15(?6?   $
??Bold"?6   $??
Sitka Text)?6  $??Center=?6*  6N  ?? 5   
   -   5        $ buttonIzadji??5      $??Izadji??60   $
??Left=?6L   $??43??6g   $??680,446,0,0q?6s   $	??Top=?6?   $	??180??6?   ???	#FFD1B482???	#FFB49560???	#FFE62C2C$??15(?6?   $
??Bold"?6   $??
Sitka Text)?6  $??Center=?6*  6N  ?? 5   
   -   5         ??Name$ labelNaslov??5      $??CLANOVI??6%   $
??Left=?67   $??	30,10,0,0q?6R   $	??Top=?6e   $??45??6}   $	??821??6?   $??Center=?6?   $??Center=?6?   $??
Sitka Text)?6?   $??30(?6?   ???	#00000000$
??Bold"?6  $??Italic$?6*   J? IsHitTestVisible .   J? RenderTransformOrigin$ 0.5,0.5&?6V  
???????
???????z?5      V? 5      .~?5      ??  ?? ScaleY$	 1.3Q?6%   ?? 5      ?? 5      T? 5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridAirsoftTim??5         AutoGenerateColumns .  	   SelectionMode$	 Single=?6k   
   
IsReadOnly
 . $
??Left=?6?   $	??350??6?   $??	30,60,0,0q?6?   $	??Top=?6?   $	??830??6?   ???	#FFD1B482??6/   ?? *	Clanovi+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Slika??6)      CellTemplate 5!      ?? 5"      .R?5#      ?? $??95??6C   $	??100??6O   $??0,5,0,5q?6[   $??Uniform=?6l   $??Center=?6~   $??Center=?6?   ??6%   ?? *
SlikaClana+6?   5$      5&      0  *System.Windows.Controls.DataGridTextColumn  5(      $	 Ime??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6R      
FontFamily$ 
Sitka Text)?6^      
FontWeight$
 Bold"?6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ?? *Ime+6v     5)      $ Prezime??6%   $	 120 6R   $ 
Sitka Text)?6^   $
 Bold"?6v    66   ?? *	Prezime+6v     5*      $ Godina??6%   $ 60 6R   $ 
Sitka Text)?6^   $
 Bold"?6v    66   ?? *	Starost+6v     5+      $	 Cin??6%   $	 160 6R   $ 
Sitka Text)?6^   $
 Bold"?6v    66   ?? *Cin+6v     5,      $ Datum??6%   $ 70 6R   $ 
Sitka Text)?6^   $
 Bold"?6v    66   ?? *Datum+6v     5-      $ * 6)    5/      ?? 50      .R?51      ?? $??Center=?6*   $??Center=?6G   .+?52   "   ?? $ Detalji??6)   -   5        $??Detalji??52   :   $	??125??6b   $??30??6n   ???	#FFD1B482$??
Sitka Text)?6?   ???	#FFE62C2C???	#FFB49560$??14(?6?   $
??Bold"?6?   $??0,2,0,2q?6?   ?? 53   "   $ Izmeni??6)   -   5        $??Izmeni??53   :   $	??125??6b   $??30??6n   ???	#FFD1B482$??
Sitka Text)?6?   ???	#FFE62C2C???	#FFB49560$??14(?6?   $
??Bold"?6?   $??0,2,0,2q?6?   ?? 54   "   $ Obrisi??6)   -   5        $??Obrisi??54   :   $	??125??6b   $??30??6n   ???	#FFD1B482$??
Sitka Text)?6?   ???	#FFE62C2C???	#FFB49560$??14(?6?   $
??Bold"?6?   $??0,2,0,2q?6?   55      56      59      5;      5<      5=      