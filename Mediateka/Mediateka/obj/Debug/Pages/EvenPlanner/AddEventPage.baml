   M S B A M L   `   `   `  ����D  @Mediateka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mediateka.PagesMediateka.Pages  5      "    Mediateka.Pages.AddEventPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Mediateka.Pages     5      X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f43xcd)http://schemas.xceed.com/wpf/xaml/toolkit  5	         MaterialDesignBody#���   5        N� Title$  AddEventPage��5       � 	Resources 5       �� 
TargetType �� Property �� Value��%X   '��       �� 5   
   " ��6   .�5      ��  � ��
 �   �5      5      5      .��5      � ���#062949 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Мероприятие��6   $��5q�5      $��32(�5      $��Center=�5      �� 5   
    �� CornerRadius$ 30��6   $��1��5      $��10q�5    	    �� Padding$ 20q�5!   	   $��Center=�5"   	   ��5$      �� 5%      .��5&      �  � Color$ #223d74��6#   	 � Offset$		 0.0Q�63   � 5'      $ #4362a1��6#   $		 1.0Q�63   5(      ._�5*      �� $��10q�6   .��5+      �� .+�5,      �� $��Название��6    �� 5-      ��6   �� *Name+�� 5.      $��Описание��6    �� 5/      ��6   �� *Description+�� 50      $%��Город проведения��6    �� 51      ��6   �� *City+�� 53      $��
Плата��6    � 54      
 � ColumnDefinitions
 55      �� 56      �� 57      $
��auto �6/   .+�59      �� ��6"   �� *Salary+�� 5:      -   5         ��Name$ 	BCurrency��5:   !   $��1��5<   !   
������ $��0q�5>   !   5?       5@      �� 5A      $2��,Какие специалисты нужны��6    %  Xceed.Wpf.Toolkit.CheckComboBox  5B      -   5          Name$ 	CCBSkills��5B   (   $��0q�5C   %   ���#4362a1 �� DisplayMemberPath$
 Name��5F   $   �� 5G      $%��Время проведения��6    &   Xceed.Wpf.Toolkit.DateTimePicker  5H      ���#4362a1
�������$��0q�5K   %   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   DefaultValue$ 
01.01.2024X�5L   %      Value 5H   )   �� *
DateTime+5L   %   �� 5M      $(��"Крайний срок сдачи��6      5N      ���#4362a1
�������$��0q�5R   %   $ 
01.01.2024X�5T   !    5N   )   �� *
Deadline+5T   !   �� 5U      -   5        $ BSave��5U      $	��0,5q�5V      $��Сохранить��5W      5X      �� 5Y      -   5        $ BBack��5Y      $��
Назад��5Z      5[      5]      5^      5_      5`      5a      