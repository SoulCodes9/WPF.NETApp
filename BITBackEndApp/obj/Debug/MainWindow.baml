   M S B A M L   `   `   `  ����H  DBITBackEndApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BITBackEndAppBITBackEndApp  5   	       BITBackEndApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BITBackEndApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��190 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������.+�5      �� $!��/images/bitI-logo-unbit.png��6   $��81��69   $
��10,0q�6E   5      �� 5   
   $��1��6   
�������.+�5      �� -   5         ��Name$ 	btnClient��5   ?   
���   �
����ح�$��50��6R   $��Client Management��6^   $��16(�6z   6�   �� 5      -   5        $ btnContractor��5   ?   
���   �
����ح�$��50��6V   $��Contractor Mangement��6b   $��16(�6�   6�   �� 5       -   5        $ btnEmployee��5    ?   
���   �
����ح�$��50��6T   $��Employee Mangement��6`   $��16(�6}   6�   �� 5"      -   5        $ btnRequests��5"   ?   
���   �
����ح�$��50��6T   $��Request Mangement��6`   $��16(�6|   6�   �� 5#      -   5        $ 	btnSkills��5#   ?   
���   �
����ح�$��50��6R   $��Skill Mangement��6^   $��16(�6x   6�   5$      �� 5&   
    �� Orientation$ 
Horizontal=�6   $��0��6.   $��1��6;   
�������.+�5'      �� -   5         ��Name$ companyName��5'      $��BIT Services Manager��6-   
����� �$��32(�6b   $��10q�6p   �� 5(      -   5        $ 	btnLogout��5(      
����ح�$��Logout��6?   $��80��6P   $��35��6[   $��50,0,0,0q�6g   6y   5)       � 5+   
   -   5          �Name$ contentFrame��5+      $��1��6&   $��1��63   5-      5.      