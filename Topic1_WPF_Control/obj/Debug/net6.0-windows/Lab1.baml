   M S B A M L   `   `   `  ����M  ITopic1_WPF_Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Topic1_WPF_ControlTopic1_WPF_Control  5   	       Topic1_WPF_Control.Lab1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Topic1_WPF_Control     5   	   -   5          � Title$
  Lab1��5   	   $	��900��6   $	��800��6#   .��5	      � $��0,0,0,-6q�6    � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��Person management��6   
���  ��$��20(�6>   $��Center=�6L   $��	0,0,0,345q�6i   $	��192��6|   $��1��6�   �� 5   
    �� Orientation$ Vertical=�6   $��0,70,400,213q�6,   $��2��6B   .+�5      � .+�5      �� $��ID(*)��6   �� 5      -   5        $��txtId��5       �� TextWrapping$
 Wrap=�6'   $��21��6;   $��	60,2,72,2q�6G   ��6[   ��  �� Path$ Id� �� Mode$ OneWay=� � DataContext 6�   ��  �� ElementName$ dbItems��$ SelectedItem��� 5      $��Name(*)��6   $��
0,50,0,-50q�6*   �� 5      -   5        $��txtName��5      $
 Wrap=�6)   $��21��6=   $��60,52,72,-47q�6I   ��6_   �� $
 Name�$ OneWay=� 6�   �� $ dbItems��$ SelectedItem��� 5      $��Active��6   $��1,93,-1,-93q�6)   �� 5      -   5        $��cbActive��5      $��60,99,280,-93q�6+   	 d� IsThreeState$
	 True��6B   
 d� 	IsChecked
 6V   �� $ Active�$ OneWay=� 6�   �� $ dbItems��$ SelectedItem�5      5      �� 5   
   $ Vertical=�6   $��400,70,30,213q�6,   $��2��6C   .+�5       � .+�5!      �� $��DOB(*)��6   (  "System.Windows.Controls.DatePicker  5"      -   5        $��dpDob��5"      $��	78,0,0,10q�6*      Text 6=   �� $	 Dob�$ OneWay=� 6d   �� $ dbItems��$ SelectedItem��� 5$      $��
Country(*)��6   $��5,50,-5,-50q�6-   �� 5%      -   5        $��	cbCountry��5%   0   $��78,50,0,-40q�6    �� SelectedIndex$ 0��6A    �� SelectedValue$ Id��6S    �� DisplayMemberPath$
 Name��6f    �� SelectedItem 6   �� *CountryNavigation+ 6�   �� $ dbItems��$ SelectedItem�6�   �� 5'      $��Gender��6   $��
0,93,0,-93q�6)   	� 5(      -   5        $��isMale��5(   1    	� 	GroupName$ gender��6   $

 TrueY�6?   $��190,102,91,-84q�6P   $
	 True��6h   .��6}   Male6�   	� 5)      -   5        $��isFemale��5)   1   $ gender��6   $��78,102,200,-84q�6A   $
	 True��6Y   .��6m   Female6u   5*      5+      �� 5,   
   $ 
Horizontal=�6   $��218,196,218,596q�6.   $��2��6G   .+�5-      �� -	   5        $��	btnDelete��5-      $��Delete��6&   $��15q�67   $��80��6C   $��25��6N   6Z   �� 5.      -
   5        $��btnAdd��5.      $	��Add��6#   $��15q�61   $��80��6=   $��25��6H   6T   �� 5/      -   5        $��	btnUpdate��5/      $��Update��6&   $��15q�67   $��80��6C   $��25��6N   6Z   50      &   System.Windows.Controls.DataGrid  51   
   -   5        $��dbItems��51         AutoGenerateColumns$ False��6"   $��0,273,0,259q�6>   $��2��6S      Columns 52      4  .System.Windows.Controls.DataGridTemplateColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Select��6)      CellTemplate 54      �� 55      .R�56      �� $��selectedPerson��6_   -   5        $��Center=�56   '   $��Center=�6D   6�   57      59      0  *System.Windows.Controls.DataGridTextColumn  5:         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%   $ ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id+  5;      $ * 6%   $
 Name��6/    6=   �� *Name+  5<      $ * 6%   $
 Name��6/    6=   �� *Gender+  5=      $ * 6%   $	 DOB��6/    6<   �� *Dob+ �� StringFormat$ 
dd/MM/yyyy��4  .System.Windows.Controls.DataGridComboBoxColumn  5>      -   5        cbbCity��$ * 5>   :   $
 City��6D      DisplayMemberPath$
 Name��6R      SelectedValuePath$ Id��6k      SelectedValueBinding 6�   �� *CountryNavigation.Id+4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5?      $ Active��6)   -   5        
active�� 	  IsThreeState$
 True��5?   I    6]   �� *Active+  5@      $ Delete��6)    5A      �� 5B      .R�5C      �� -   5        $��Delete��5C   %   66   5D      5F      5H      5K      5L      