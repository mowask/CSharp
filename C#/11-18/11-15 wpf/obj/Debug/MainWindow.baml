   M S B A M L   `   `   `  ����D  @11-15 wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:_11_15_wpf
_11_15_wpf  5   	       _11_15_wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:_11_15_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)   .��5	      �� .@�5
   
   �� $��Authors��6   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� -   5         ��Name$ 
buttonFill��5      $
��Fill��61   $��10q�6@   $	��100��6L   �� 5      -   5        $ buttonUpdate��5      $��Update��63   $��10q�6D   $	��100��6P   �� 5      -   5        $ buttonDelete��5      $��Delete Selection��63   $��10q�6N   $	��100��6Z   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$
 grid��5      $��1��6)      AutoGenerateColumns .  $��Center=�6R      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Id��6V   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 60 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6-   �� *Id+6b     5      $ 	FirstName��6K   $		 140 6^   
 6-   �� *	FirstName+6^     5      $ LastName��6J   $		 140 6\   
 6-   �� *
LastName+6\   5      5      5      �� 5   
   $��Books��6   .��5      �  5       �� 5!      $
��Auto �6$   �� 5"      $��* �6$   .+�5$      �� $��Center=�6   $ 
Horizontal=�6:   .+�5%      �� -   5        $ btnFill��5%      $
��Fill��6.   $��10q�6=   $	��100��6I   �� 5&      -   5        $ 	btnUpdate��5&      $��Update��60   $��10q�6A   $	��100��6M   �� 5'      -   5        $ 	btnDelete��5'      $��Delete Selection��60   $��10q�6K   $	��100��6W   5(        5)      -   5        $ grid2��5)      $��1��6*    .  $��Center=�6S    5*        5+       . $ Id��6V   $	 60 6b   
 6-   �� *Id+6b     5,      $ Title��6G   $		 240 6V   
 6-   �� *Title+6V     5-      $ AuthorId��6J   $	 70 6\   
 6-   �� *
AuthorId+6\     5.      $ Pages��6G   $	 70 6V   
 6-   �� *PAGES+6V     5/      $ Price��6G   $	 70 6V   
 6-   �� *PRICE+6V   51      52      53      54      55      