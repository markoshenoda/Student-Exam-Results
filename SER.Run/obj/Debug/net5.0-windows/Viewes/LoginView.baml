   M S B A M L   `   `   `  ????D  @SER Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SER.Run.UI_ElementsSER.Run.UI_Elements  5          SER.Run.Viewes.LoginView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      0ui!clr-namespace:SER.Run.UI_Elements     5      .??5      ??    
MainBorder#??[  6   ._?5   
   ?   ? RowDefinitions  5      ?? 5	      $
??auto ?6    ?? 5
      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6     ? ColumnDefinitions 5      ?? 5      $
??auto ?6#   ?? 5      $
??auto ?6#   .+?5      ?? $??0??5      $??0??5      $??2??5        	TitleBlok#??[ 5      $??تسجيل الدخول??5      ?? 5      $??1??5      $??0??5      $??كود المستخدم :??5      ?? 5      $??2??5      $??0??5      $??كلمة المرور :??5      ?? 5       $??1??5!      $??1??5"        NumberTextBox#??[ 5#      ??5$      ?? *
UserCode+ ?? Mode$ OneWayToSource=? ?? UpdateSourceTrigger$ PropertyChanged=?+   %SER.Run.UI_Elements.CustomPasswordBox  5%      $??2??5&      $??1??5'         Password 5(      ?? *
UserPass+$ OneWayToSource=?$ PropertyChanged=??? 5)      $??3??5*      $??0??5+      $??2??5,      $??تسجيل الدخول??5.      ??5-      ?? *CLoginCommand+5.      5/      50      51      