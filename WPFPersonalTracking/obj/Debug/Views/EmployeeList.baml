   M S B A M L   `   `   `  ����N  JWPFPersonalTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPFPersonalTracking.ViewsWPFPersonalTracking.Views  5      ,    &WPFPersonalTracking.Views.EmployeeList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:WPFPersonalTracking.Views     5      -   5        $��18(�5   7   $
��Bold"�6E   .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridEmployee��5      $��1��6)   $��5��66      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   	   
Visibility$	 Hidden=�6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Id+6R     5      $ UserNo��6%   $ * 65   
 6?   �� *UserNo+  5      $
 Name��6%   $ * 63   
 6=   �� *Name+  5      $ Surname��6%   $ * 66   
 6@   �� *	Surname+  5      $ Position Name��6%   $ * 6<   
 6F   �� *PositionName+  5      $ Department Name��6%   $ * 6>   
 6H   �� *DepartmentName+  5      $ Salary��6%   $ * 65   
 6?   �� *Salary+  5      $ 
PositionId��6%   $ * 69   $	 Hidden=�6b   
 6C   �� *
PositionId+6b     5       $ DepartmentId��6%   $ * 6;   $	 Hidden=�6f   
 6E   �� *DepartmentId+6f     5!      $ isAdmin��6%   $ * 66   $	 Hidden=�6\   
 6@   �� *	isAdmin+6\     5"      $ BirthDay��6%   $ * 67   $	 Hidden=�6^   
 6A   �� *
BirthDay+6^     5#      $ Adress��6%   $ * 65   $	 Hidden=�6Z   
 6?   �� *Adress+6Z     5$      $ Password��6%   $ * 67   $	 Hidden=�6^   
 6A   �� *
Password+6^     5%      $ 	ImagePath��6%   $ * 68   $	 Hidden=�6`   
 6B   �� *	ImagePath+6`   5'      � 5(   
   $��5��6    5)      �� 5*      �� 5+      �� 5,        5.      �� 5/      $	��60* �6#   �� 50      $
��100* �6#   �� 51      $	��60* �6#   �� 52      $
��100* �6#   �� 53      $	��80* �6#   .+�55      �� $��UserNo��6   $��34��6%   $��78��61   $
��Left=�6<   $��Center=�6W   �� 56      -   5         ��Name$ 	txtUserNo��56      $��1��6)   $��26��69    �� TextWrapping$
 Wrap=�6E   �� 57      $
��Name��6   $��1��6#   $��34��60   $��78��6<   $
��Left=�6G   $��Center=�6b   �� 58      -   5        $ txtName��58      $��1��6'   $��1��64   $��26��6D   $
 Wrap=�6P   �� 59      $��Surname��6   $��2��6&   $��34��63   $��78��6?   $
��Left=�6J   $��Center=�6e   �� 5:      -   5        $ 
txtSurname��5:      $��2��6*   $��1��67   $��26��6G   $
 Wrap=�6S   �� 5;      $��
Department��6   $
��auto��6)   $
��Left=�66   $��Center=�6Q   $��34��6l   $��2��6x   �� 5<      -   5        $��cmbDepartment��5<      $��3��6,   $��Center=�6<   $��30��6W   $��0,0,0,0q�6c   6t   �� 5=      $��Position��6   $
��auto��6'   $��1��64   $
��Left=�6A   $��Center=�6\   $��34��6w   $��2��6�   �� 5>      -   5        $��cmbPosition��5>      $��3��6*   $��1��6:   $��Center=�6G   $��30��6b   $��0,0,0,0q�6n   �� 5?      -   5        $��	btnSearch��5?   6   $��4��6   $��Search��6%   $��	20,5,10,5q�6G   6Z   �� 5@      -	   5        $��btnClear��5@   B   $��4��6   $��1��6%   $��Clear��62   $��	20,5,10,5q�6R   6e   5B      �� 5C   
   -
   5         ��Name$ btnAdd��5C      $	��Add��6!   $��1��6/   $��2��6?   $��	40,5,40,5q�6L   $��18(�6_   $
��Bold"�6m   6   �� 5D   
   -   5        $ 	btnUpdate��5D      $��Update��6$   $��2��65   $��2��6E   $��	40,5,40,5q�6R   $��18(�6e   $
��Bold"�6s   6�   �� 5E   
   -   5        $ 	btnDelete��5E      $��Delete��6$   $��3��65   $��2��6E   $��	40,5,40,5q�6R   $��18(�6e   $
��Bold"�6s   5F      5G      