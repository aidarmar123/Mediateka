   M S B A M L   `   `   `  ����D  @Mediateka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Mediateka	Mediateka  5   	   A%clr-namespace:Mediateka.UsersControlsMediateka.UsersControls  5   	       Mediateka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Mediateka     5   	   4uc%clr-namespace:Mediateka.UsersControls     5   	     � Icon$  /Resourse/Icon128.ico��5	   	      MaterialDesignWindow#��[  5
   	    � Title$ Медиатека��5   	   $	��450��6   $	��800��6+   $	��650��5   	   $	��900��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � -   5         �Name$ GProfile��5      ���#5773b0$y�	Collapsed=�5       � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��10,5q�5      .+�5      �� -   5        $ 
Horizontal=�5      .+�5       �� -   5         ��Name$ IAdmin��5!      $��/Resourse/Icon128.png��5       $y�	Collapsed=�5"      �� 5#      -   5         ��Name$ BUser��5$       �� CornerRadius$ 20��5#      $y�	Collapsed=�5%      $��5q�5&      $��70��5'      $��70��5(      ��5)      �� 5*      	 �� ImageSource	 6%   �� *Avatar+5,      �� 5-      $��24(�5.      $��Center=�5/      ��5-      �� *
FullName+5/      51      52      �� 53      $��1��54      $��Center=�55      $��10q�56      .+�57      �� -   5        
 ��Name$
 BExit��57      $��3q�58      $��
Выйти��5:      �� 5<      -   5        $
 BAddUser��5<      $��3q�5=      $y�	Collapsed=�5>      $/��)Добавить пользователя��5@      5A      5C       � 5D   
   -   5          �Name$ 	MainFrame��5D      $��1��5E        � NavigationUIVisibility$ Hidden=�5F      5G      5H      