   M S B A M L   `   `   `  ????  	SER Start$    SER.Run.Viewes.AddDivisionView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .??5      ? $??7q?6     ? ColumnDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5	      $
??auto ?6   ?? 5
      $
??auto ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??5      $??0??5      $??أسم القسم :??5      ?? 5   
   $??0??5      $??1??5      $
??auto??5      $??10q?5      $	??Top=?5      ??5      ?? *DivisionName+ ?? UpdateSourceTrigger$ PropertyChanged=? ?? Mode$ TwoWay=?.??6]    J? InputBindings 5      ?? 5      
 ?? Key$ Enter??6    ?? Command 6)   ?? *AddDivisionCommand+.??5   %   5      ?? 5    
   $??0??5!      $??2??5"      $??Center=?5#      $	??Top=?5$      ??5%      ?? *AddDivisionCommand+??5&      ?? *
DivStyle+?? 5'   
   $??1??5(      $??0??5)      $??أسم الشعبة :??5*      ?? 5+   
   $??1??5,      $??1??5-      $??10q?5.      $	??Top=?5/      ??50      ?? *SubDivisionName+$ PropertyChanged=?$ TwoWay=?.??6`    51      ?? 52      $ Enter??6    6)   ?? *AddSubDivisionCommand+.??53   %   54      ?? 55   
   $??1??56      $??2??57      $??0,7,0,8q?58      $	??Top=?59      ??5:      ?? *AddSubDivisionCommand+??5;      ?? *SubDivStyle+? 5<   
   $??0??5=      $??3??5>      $??4??5?       5@      ?? 5A      $
??auto ?6    ?? 5B      $
??auto ?6    ?? 5C      $??* ?6    .+?5E      ?? $??0??5F      $??الاقسام??5G       ?? TextAlignment$ Center=?5H      ?? 5I      $??1??5J      $
??10,0q?5K         
MainBorder#??[  5L      ._?5M      ?? -   5         ??Name$ 	divisions??5N      $??Center=?5O      
?????? $??0q?5Q        ListItemSelection#??[ 5R      $??Disabled=?5T      	 ?? SelectionMode$	 Single=?5V      ??5S      ?? *	Divisions+
 ?? SelectedItem
 5U      ?? *SelectedDivision+$ TwoWay=?$ PropertyChanged=?5V      5W      ?? 5X      $??2??5Y      $??Bottom=?5Z        
SaveButton#??[ 5\      ??5[      ?? *SaveCommand+5\      5]      ?? 5^   
   $??2??5_      $??0??5`      $??3??5a      $
??10,0q?5b      $??Stretch=?5c      #??[  5d      ._?5e      ?? $	??200??5f      $??0q?5g      ??5h      ?? *	Divisions+ ?? View 5i      ?? 5j      P?5k      ?? 5l      $'??!الأقسام التعليمية??6-    ?? CellTemplate 5m   "   ?? 5n   &   .R?5o   *   ?? ??64   ?? *Name+5p   '   5r      ?? 5s      $#??الشعب التعليمية??6-    5t   "   ?? 5u   &   .R?5v   *   ?? $??Stretch=?5w   -   $??0q?5x   -   $??Disabled=?5z   -   $??Disabled=?5{   -   ??5y   -   ?? *SubDivisions+??5|   .   ?? 5}   2   .R?5~   6   ?? $??0q?5   9   $??15(?5?   9   ??5?   9   ?? *Name+5?   3   5?   +   5?   '   5?      5?      5?      5?      5?      5?      