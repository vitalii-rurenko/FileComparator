   M S B A M L   `   `   `  ����  FileComparator    FileComparator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  FileComparator v.1.0.��5   	    � WindowStartupLocation$ CenterScreen=�6)    J� 	AllowDrop .  � Icon$ md5.jpg��6_    � SizeToContent$ WidthAndHeight=�6n    � 
ResizeMode$ NoResize=�6�    J� Opacity$	 1.1Q�6�    � ShowActivated .  ��5      �� 5   
   .��5      � .+�5	   
   �� $��3��6   .+�5
      �� $��Enter file location��6   .��5      � .+�5      �� .+�5      � .+�5      �� $��	File Name��6(   $
��Bold"�69   $��5q�6K   �� 5      -   5        $��OpenFileDlgTextBox��5   &   $��5q�6@   $	��420��6L   5      �� 5      -   5        $��
browse_btn��5   A   $��1��5   !   $��Browse��61   $��5q�6B   $��Right=�5   %   $��22��5   >   $��60��6J   5      5      5      �� 5      $��Choose hash algorithm��6   $
��Left=�66   $	��Top=�5      $��Stretch=�6:   $��Stretch=�5      .��5      �� .+�5      �� -   5        $��cmbBox��5   >    �� SelectedIndex$ 0��5      $��5q�61   $	��150��6<   $
��Left=�5   #   5      � 5      .+�5      �� $��5,5,0,5q�6$   $��
Hash Code ��65   $
��Bold"�6G   �� 5       -   5        $��HashCodeTextBox��5    9   $	��420��6"   $��5q�6.   	 �� 
IsReadOnly	 . 6P   5!      �� 5"      -   5        $��CalculateHashButton��5"      $��
 Calculate��68   $��22��6M   $��60��5#   !   $��5q�6-   $��Right=�5$   !   5%      5&      9� 5'      $��Hashcode comparison��6   .��5(      �� .��5)      � 
 � ColumnDefinitions
 5*      �� 5+      �� 5,      .+�5/      �� -   5        $��comparationResult��5/       $��null.png��69   $
��Fill=�50   $   $��70��63   $��70��6?   $��0��51   $   �� 52      $��1��6%   .+�53      �� -   5        $��CompareHashCodeTextBox��54   &   $��23��53   &   $	��420��62   $��2,5,5,5q�6>   $	��Top=�54   D   $��1��55   &   	 . 66   �� 57      -   5        $��CompareButton��57   %   $��Compare��6:   $��22��58   %   $��60��61   $��5q�6<   $��1��5:   %   $��Right=�65   5;      5<      5=      5>      5?      5@      5A      