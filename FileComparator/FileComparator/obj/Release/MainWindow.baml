   M S B A M L   `   `   `  ����   FileComparator    FileComparator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  FileComparator v.1.0.�� � WindowStartupLocation$ CenterScreen=� J� 	AllowDrop .  � Icon$ md5.jpg�� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ NoResize=� J� Opacity$	 1.1Q� � ShowActivated .  ���� .��� .+��� $��3��.+��� $��Enter file location��.��� .+��� .+�� .+��� $��	File Name��$
��Bold"�$��5q��� -   $��OpenFileDlgTextBox��$��5q�$	��420���� -   $��
browse_btn��$��1��$��5q�$��Browse��$��Right=�$��22��$��60���� $��Choose hash algorithm��$
��Left=�$	��Top=�$��Stretch=�$��Stretch=�.���� .+��� -   $��cmbBox�� �� SelectedIndex$ 0��$��5q�$	��150��$
��Left=�� .+��� $��5,5,0,5q�$��
Hash Code ��$
��Bold"��� -   $��HashCodeTextBox��$	��420��$��5q�	 �� 
IsReadOnly	 . �� -   $��CalculateHashButton��$��
 Calculate��$��22��$��60��$��5q�$��Right=�9� $��Hashcode comparison��.���� .��� 
 � ColumnDefinitions
 �� �� .+��� -   $��comparationResult��$��null.png��$
��Fill=�$��70��$��70��$��0���� $��1��.+��� -   $��CompareHashCodeTextBox��$��23��$	��420��$��2,5,5,5q�$	��Top=�$��1��	 . �� -   $��CompareButton��$��Compare��$��22��$��60��$��5q�$��1��$��Right=�