   M S B A M L   `   `   `  ����N  JWPFPersonalTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPFPersonalTracking.ViewsWPFPersonalTracking.Views  5      ,    &WPFPersonalTracking.Views.PositionList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:WPFPersonalTracking.Views     5      -   5        $��18(�5   7   $
��Bold"�6E   .��5	      �   � RowDefinitions  5
   
   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ btnAdd��5      $	��Add��6%   $��0��63   $��	40,5,40,5q�6C   $��18(�6V   $
��Bold"�6d   6v   �� 5      -   5        $ 	btnUpdate��5      $��Update��6(   $��1��69   $��	40,5,40,5q�6I   $��18(�6\   $
��Bold"�6j   6|   �� 5      -   5        $ 	btnDelete��5      $��Delete��6(   $��2��69   $��	40,5,40,5q�6I   $��18(�6\   $
��Bold"�6j   6|   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridPosition��5      $��0��6)      
IsReadOnly .    SelectionMode$ Single=�6H      AutoGenerateColumns .     SelectionUnit$ FullRow=�6{      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 61      
Visibility$ Hidden=�6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ID+6R     5      $	 Position Name��6%   $

 auto 6<    6I   �� *PositionName+  5      $	 Department Name��6%   $

 auto 6>    6K   �� *DepartmentName+  5      $	 Department Id��6%   $

 auto 6<   $ Hidden=�6I    6]   �� *DepartmentId+5!      5"      5#      