   M S B A M L   `   `   `  ����N  JWPFPersonalTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFPersonalTrackingWPFPersonalTracking  5   	   E'clr-namespace:WPFPersonalTracking.ViewsWPFPersonalTracking.Views  5   	   O,clr-namespace:WPFPersonalTracking.ViewModelsWPFPersonalTracking.ViewModels  5   	   $    WPFPersonalTracking.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFPersonalTracking     5   	   9views'clr-namespace:WPFPersonalTracking.Views     5   	   ;vm,clr-namespace:WPFPersonalTracking.ViewModels     5   	   -   5          �Name$  PersonalMainWindow��5   	    � Title$ WPF Personal Tracking��5
   	   $	��540��6'   $
��1200��64   $��24(�6A   ���	#FF29C8EC � Icon$ Smart_Think_Icon.ico��6}    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�   $
��Bold"�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��/Image/Logo.png��6   �� 5   
   $��1��6-   $��1��6>   $��8��6K   $	��NaN��6\   $	��NaN��6i   ��6   �� 6i   �� 5   
   -   5         ��Name$ lblWindowName��5      $��1��6'   $��Windows Name��67   $
��Left=�6N   $��	246,0,0,0q�6i   $��Center=�6|   $��36(�6�   $
��Bold"�6�   �� 5   
   $��1��6   $��0,2,0,0q�6"   .+�5       �� -   5         ��Name$ btnEmployee��5    "   $��1��6   $
��Left=�67   $	��250��6S   $��60��6_   .��5!      � $	��230��6    5"      �� 5#      $
��auto �6+   �� 5$      $
��auto �6+   .+�5&      �� -   5        	 ��Name$	 EmployeeImage��5&      $��/Image/Employee.png��63   $
��Left=�6P   $
��auto��6k   $��73��6y   �� 5'      $��Employee��6    $��1��60   $
��Left=�6@   $��Center=�6[   5(      5)      5*      �� 5+   
   $��2��6   $��0,2,0,0q�6"   .+�5,      �� -   5        $ btnTask��5,   "   $��2��6   $
��Left=�63   $	��250��6O   $��60��6[   .��5-      � $	��230��6    5.      �� 5/      $
��auto �6+   �� 50      $
��auto �6+   .+�52      �� -   5        $	 	TaskImage��52      $
��Left=�6/   $
��auto��6J   $��73��6X   $��/Image/Task.png��6c   �� 53      $
��Task��6    $��1��6,   $
��Left=�6<   $��Center=�6W   54      55      56      �� 57   
   $��3��6   $��0,2,0,0q�6"   .+�58      �� -   5        $ 	btnSalary��58   "   $��3��6   $
��Left=�65   $	��250��6Q   $��60��6]   .��59      � $	��230��6    5:      �� 5;      $
��auto �6+   �� 5<      $
��auto �6+   .+�5>      �� -   5        $	 SalaryImage��5>      $
��Left=�61   $
��auto��6L   $��73��6Z   $��/Image/Salary.png��6e   �� 5?      $��Salary��6    $��1��6.   $
��Left=�6>   $��Center=�6Y   5@      5A      5B      �� 5C   
   $��4��6   $��0,2,0,0q�6"   .+�5D      �� -	   5        $ btnPermission��5D   "   $��4��6   $
��Left=�69   $	��250��6U   $��60��6a   .��5E      � $	��230��6    5F      �� 5G      $
��auto �6+   �� 5H      $
��auto �6+   .+�5J      �� -
   5        $	 PermissionImage��5J      $
��Left=�65   $
��auto��6P   $��73��6^   $��/Image/Permission.png��6i   �� 5K      $��
Permission��6    $��1��62   $
��Left=�6B   $��Center=�6]   5L      5M      5N      �� 5O   
   -   5        
 ��Name$
 stackDepartment��5O      $��5��6.   $��0,2,0,0q�6;   .+�5P      �� -   5        $��btnDepartment��5P   "   $��5��6   $��60��67   $	��250��6C   $
��Left=�6O   .��5Q      � $	��230��6    5R      �� 5S      $
��auto �6+   �� 5T      $
��auto �6+   .+�5V      �� -   5        $	 DpImage��5V      $
��Left=�6-   $
��auto��6H   $��73��6V   $��0,0,0,0q�6a   $��/Image/Department.png��6r   �� 5W      $��
Department��6    $��1��62   $
��Left=�6B   $��Center=�6]   5X      5Y      5Z      �� 5[   
   -   5        $
 stackPosition��5[      $��6��6,   $��0,2,0,0q�69   .+�5\      �� -   5        $��btnPosition��5\   "   $��6��6   $��60��65   $	��250��6A   $
��Left=�6M   .��5]      � $	��230��6    5^      �� 5_      $
��auto �6+   �� 5`      $
��auto �6+   .+�5b      �� -   5        $	 PositionImage��5b      $
��Left=�63   $
��auto��6N   $��73��6\   $��0,0,0,0q�6g   $��/Image/Position.png��6x   �� 5c      $��Position��6    $��1��60   $
��Left=�6@   $��Center=�6[   5d      5e      5f      �� 5g   
   -   5        $
 stacklogoff��5g      $��7��6*   $��0,2,0,0q�67   .+�5h      �� -   5        $��	btnLogOut��5h   "   $��7��6   $��60��63   $	��250��6?   $
��Left=�6K   .��5i      � $	��230��6    5j      �� 5k      $
��auto �6+   �� 5l      $
��auto �6+   .+�5n      �� -   5        $	 LogoutImage��5n      $
��Left=�61   $
��auto��6L   $��73��6Z   $��0,0,0,0q�6e   $��/Image/Logout.png��6v   �� 5o      $��Log Out��6    $��1��6/   $
��Left=�6?   $��Center=�6Z   5p      5q      5r      �� 5s   
   -   5        $
 	stackexit��5s      $��8��6(   $��0,2,0,0q�65   .+�5t      �� -   5        $��btnExit��5t   "   $��8��6   $��60��61   $	��250��6=   $
��Left=�6I   .��5u      � $	��230��6    5v      �� 5w      $
��auto �6+   �� 5x      $
��auto �6+   .+�5z      �� -   5        $	 	ExitImage��5z      $
��Left=�6/   $
��auto��6J   $��73��6X   $��0,0,0,0q�6c   $��/Image/Exit.png��6t   �� 5{      $
��Exit��6    $��1��6,   $
��Left=�6<   $��Center=�6W   5|      5}      5~      5       � 	Resources 5�       �� DataType8   2WPFPersonalTracking.ViewModels.DepartmentViewModel.   (WPFPersonalTracking.Views.DepartmentList6   0WPFPersonalTracking.ViewModels.PositionViewModel,   &WPFPersonalTracking.Views.PositionList6   0WPFPersonalTracking.ViewModels.EmployeeViewModel,   &WPFPersonalTracking.Views.EmployeeList��%=  (��       5�   3   *, +)(�� R     5�   1   *, +)(�� �     5�   1   *, +)�� 5�   
   DepartmentTemplate��"  63   .R�5�        5�      5�      �� 5�   
   PositionTemplate��"  61   .R�5�        5�      5�      �� 5�   
   EmployeeTemplate��"  61   .R�5�        5�      5�      5�      5�      