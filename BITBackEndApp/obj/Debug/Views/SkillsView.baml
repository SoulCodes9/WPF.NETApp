   M S B A M L   `   `   `  ����H  DBITBackEndApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BITBackEndApp.ViewsBITBackEndApp.Views  5      $    BITBackEndApp.Views.SkillsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:BITBackEndApp.Views     5        N� Title$  
SkillsView��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������.+�5      �  � ColumnDefinitions 5      �� 5      $��2* �6'   �� 5      $	��300 �6'   .+�5      �� $��10,0,0,0q�6   $"��Contractor Skills Management��6*   $��32(�6Q   
����� �6_   5      5      �� 5   
   $��3��6   .+�5      �  5      �� 5      $��1* �6'    5       �� 5!      $��* �6$   .+�5#      �� $��3��6   $��	10,0,10,0q�6*   .+�5$      �  5%      �� 5&      $��1* �6/   �� 5'      $��1* �6/   �� 5(      $��1* �6/   .+�5*      �� -   5         ��Name$ btnRemoveSkill��5*   D   $��0,5,10,5q�6\   $��20(�6n   $��Remove Skill��5+   "   $��0��69   
����ح���5*   "   �� *RemoveCommand+5+   I   �� 5,      -   5        $# btnBackToContractorManagement��5,   "   $��10,5,6,5q�6I   $��20(�5-   "   
����ح�$��Cancel��5.   "   $��2��63   6C   �� 5/      -   5        $ btnAddSkill��5/   A   $��	10,5,10,0q�6V   $��20(�50   "   $��Insert Skill��60   $��1��6G   
����ح�$��31��51   "   $	��Top=�6.   ��5/   "   �� *
AddCommand+51   .   52      53      54      55      �� 56   
   $��2��6   .+�57      �  58      �� 59      $��1* �6'   �� 5:      $��1* �6'   �� 5;      $��1* �6'   �� 5<      $��1* �6'   .+�5>      &   System.Windows.Controls.DataGrid  -   5          Name$ dgContractors��5>   8   $��0��6   $��0��6(   $��10, 10, 10, 10q�6O      AutoGenerateColumns .  $��2��5B   ;    �� SelectedItem 5@      �� *SelectedContractor+��5A      �� *Contractors+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	   Columns	 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Contractor��6N      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *ContractorId+6b     5E      $
 
First Name��6K   $
 1.5* 6_    6-   �� *	FirstName+6_     5F      $
 	Last Name��6J   $
 1.5* 6]    6-   �� *
LastName+6]   5H        5I      -   5        $ dgContractorSkills��5I   8   $��0��6   $��2��6(   $��10, 10, 10, 10q�6T    .   5K      �� *SelectedPreferredSkill+��5L      �� *$"SelectedContractor.PreferredSkills+$ TwoWay=�$ PropertyChanged=�	 5N        5O      $
 Contractor Skills��6K   $ * 6f    6-   �� *	SkillName+6f   5Q        5R      -   5        $ dgActiveSkills��5U   0    .  $��10, 10, 10, 10q�5T   /   $��0��5U      $��3��6     5R      �� *SelectedSkillToAdd+��5S      �� *ActiveSkills+$ TwoWay=�	 5V        5W      $
 All Active Skills��6K   $ * 6f    6-   �� *	SkillName+6r   5Y      5Z      5[      5\      5]      