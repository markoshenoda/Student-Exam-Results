   M S B A M L   `   `   `  ????D  @SER Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SER.Run.UI_ElementsSER.Run.UI_Elements  5      '    !SER.Run.Viewes.ChangePasswordView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      0ui!clr-namespace:SER.Run.UI_Elements     5      .??5      ??    
MainBorder#??[  6   ._?5   
   ?   ? RowDefinitions  5      ?? 5	      $
??auto ?6    ?? 5
      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6     ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   ?? 5      $
??auto ?6#   .+?5      ?? $??0??5      $??0??5      $??2??5        	TitleBlok#??[ 5      $$??تغير كلمة المرور??5      ?? 5      $??1??5      $??0??5      $??اسم المستخدم :??5      ?? 5      $??2??5      $??0??5       $,??&كلمة المرور الحالية :??5!      ?? 5"      $??3??5#      $??0??5$      $,??&كلمة المرور الجديدة :??5%      ?? 5&      $??4??5'      $??0??5(      $(??"تاكيد كلمة المرور :??5)      ?? 5*      $??1??5+      $??1??5,      ??5-      ?? *
UserName++   %SER.Run.UI_Elements.CustomPasswordBox  5.      $??2??5/      $??1??50         Password 51      ?? *CurantPassword+ ?? Mode$ OneWay=?  52      $??3??53      $??1??54       55      ?? *NewPassword+  56      $??4??6#   $??1??60   ?? 57      $??5??58      $??0??59      $??2??5:       ?? Orientation$ 
Horizontal=?5;      $??Center=?5<      $??Center=?6,   .+?5=      ?? $??Stretch=?5>      $??حفظ التعديلات??5@      ??5?      ?? *ChangePasswordCommand+5@      ?? 5A      $??1??5B      $??Stretch=?5C      $??ألغاء الامر??5E      ??5D      ?? *CancelCommand+y?5F      ?? *
MustChange+  VisibleIfTrueConverter ?? 	Converter# [ 5H      5I      5J      5K      