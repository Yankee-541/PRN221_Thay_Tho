   M S B A M L   `   `   `  ����M  ITopic1_WPF_Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Topic1_WPF_ControlTopic1_WPF_Control  5   	   -    'Topic1_WPF_Control.DemoGridViewDataGrid   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Topic1_WPF_Control     5   	     � Title$  DemoGridViewDataGrid��5   	   $	��650��6&   $	��800��63   .��5	      � .+�5
   
   �� -   5        $��MenList��5   2   $��Center=�5
      $	��168��62   $��0,37,0,0q�6A   $	��Top=�5   
   $	��780��6$    �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 100��5       �� DisplayMemberBinding 5   5   �� *Name+5      �� 5      $��ID��6%   $	 100��5       5   3   �� *ID+5      �� 5      $	��Age��6%   $	 100��5       5   4   �� *Age+5      5      5      �� 5   
   -   5        $��	txtPerson��5   5   $
��Left=�6F   $��
10,233,0,0q�6a   $	��Top=�6v   $	��503��6�   $��50��6�   ��6   �� *SelectedItem.Name+6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dbItems��5         AutoGenerateColumns$ False��6"   $��0,333,0,135q�6>      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$
 Name��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Name+  5!      $ * 6%   $ ID��6/    6;   �� *ID+  5"      $ * 6%   $	 Age��6/    6<   �� *Age+  5#      $ * 6%   $ Phone��6/    6>   �� *Phone+  5$      $ * 6%   $	 DOB��6/    6<   �� *DOB+4  .System.Windows.Controls.DataGridComboBoxColumn  5%      -   5        cbbCity��$ * 5%   :   $
 City��6D   	   DisplayMemberPath$	 CName��6R   
   SelectedItemBinding
 6l   �� *City+4  .System.Windows.Controls.DataGridCheckBoxColumn  5&      $ ACtive��6)   -   5        
active��   IsThreeState$
 True��5&   I    6]   �� *Active+5*      �� 5+   
   -   5        $��txtCar��5+   6   $
��Left=�6D   $��
10,524,0,0q�6_   $	��Top=�6t   $	��503��6�   $��50��6�   ��6   �� *SelectedItem.Color+6�   5-      5.      