   M S B A M L   `   `   `  ����O  Kwpf_hw_MVVM2_Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:wpf_hw_MVVM2_Librarywpf_hw_MVVM2_Library  5   	   %    wpf_hw_MVVM2_Library.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:wpf_hw_MVVM2_Library     5   	   -   5          �Name$  window��5	   	    � Title$ 
MainWindow��5   	   $	��500��6   $	��600��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� 
���������6%   �� *books+��5      �� 5      .R�5      � .+�5      �� $��5q�6;   $
��Wrap=�6F   ��6$   �� *Title+6F   �� 5      $��5q�6<   $
��Wrap=�6G   ��6$   �� *Author+6G   �� 5      $��+��6!   ��5   !   ��  �� ElementName$ window�� �� Path$! DataContext.ShowBookCommand���5   !   �� 5      5      5      �� 5   
   $��1��6   
�������.+�5      �� $��details:��6   $��5q�6(   �� 5       $
��Wrap=�69   $��20q�6M   ��6   �� *BookDescription+6M   5!      5#      5$      