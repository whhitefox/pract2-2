   M S B A M L   `   `   `  ????A  =Pract2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Pract2Pract2  5   	       Pract2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Pract2     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??0.5* ?6   ?? 5      $??4* ?6   ?? 5      $
??0.5* ?6    ? ColumnDefinitions 5   
   ?? 5      ?? 5      .+?5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 
DatePicker??5      $??0??6)   $??2??66   6J   ?? 5   
   -   5         ??Name$ ZametkiList??5      $??1??6'   $??0??64   6D   ?? 5   
   $??1??6   $??1??6%   .+?5      ?? $??Название:??6   $??Center=?6(   ?? 5      -   5         ??Name$ NameBox??5       ?? TextWrapping$
 Wrap=?6'   $?? ??6;   ?? 5      $??Описание:??6   $??Center=?6(   ?? 5      -   5        $ DescriptionBox??5      $
 Wrap=?6.   $?? ??6B   5      ?? 5   
   -   5         ??Name$ DeleteButton??5      $!??Удалить запись??6'   $??2??6@   $??0??6M   6]   ?? 5   
   $??1??6   $??2??6%    ?? Orientation$ 
Horizontal=?62   $??Center=?6K   .+?5      ?? -   5        $ CreateButton??5      $??Создать??6+   6=   ?? 5      -   5        $ 
SaveButton??5      $??Сохранить??6)   6=   5      5       5!      