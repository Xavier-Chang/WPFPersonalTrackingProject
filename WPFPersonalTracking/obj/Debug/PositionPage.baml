   M S B A M L   `   `   `  ����N  JWPFPersonalTracking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFPersonalTrackingWPFPersonalTracking  5   	   &     WPFPersonalTracking.PositionPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFPersonalTracking     5   	   -   5          � Title$  Position Page��5   	   $	��300��6   $	��450��6,    � Icon$ Image/Logo.png��68    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d   $��18(�6�   $
��Bold"�6�   ���	#FF4AC7EC.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
Department��6   $��0��6%   $��0��65   $��Center=�6B   $��Center=�6_   �� 5   
   -   5         ��Name$ cmbDepartment��5      $��1��6*   $
��Left=�6:   $��Center=�6U   $	��155��6p   �� 5   
   $��Position��6   $��0��6#   $��1��63   $��Center=�6@   $��Center=�6]   �� 5   
   -   5         ��Name$ txtPosition��5      $��1��6'   $��1��67   $
��Left=�6D   $��Center=�6_   $	��155��6z    �� TextWrapping$
 Wrap=�6�   �� 5   
   -   5        	 ��Name$	 btnSave��5      $
��Save��6"   $��0��61   $��2��6A   $��Center=�6N   $��Center=�6k   $	��100��6�   $��50,0,0,0q�6�   6�   �� 5   
   -   5        $	 btClose��5      $��Close��6"   $��1��62   $��2��6B   $��Center=�6O   $��Center=�6l   $	��100��6�   $��0,0,53,0q�6�   6�   5      5      