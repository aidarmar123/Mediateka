   M S B A M L   `   `   `  ����D  @Mediateka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Mediateka.WindowsMediateka.Windows  5   	   #    Mediateka.Windows.EventWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Mediateka.Windows     5   	   X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f43xcd)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignWindow#��[  5   	     � Icon$  /Resourse/Icon128.ico��5
      ���#062949$	��600��5   	   $	��900��5   	    � Title$ Мероприятие��5   	   $	��450��6   $	��800��6-   .��5      � .+�5   
   � $��5q�6   .+�5      ��  �� CornerRadius$ 30��6   $��1��5   
   $��10q�5       �� Padding$ 20q�5      $��Center=�5      ��5      �� 5      .��5      �  � Color$ #223d74��6'    � Offset$	 0.0Q�67   � 5      $ #4362a1��6'   $	 1.0Q�67   5      ._�5      �� .��5      �� .+�5       �� $��Название��6$   $��	ExtraBold"�5!   $   �� 5"      ��6$   �� *Name+�� 5#      $��Описание��6$   $
��Bold"�5$   %   �� 5%      ��6$   �� *Description+�� 5&      $%��Город проведения��6$   $
��Bold"�5'   %   �� 5(      ��6$   �� *City+�� 5*      $��
Плата��6$   $
��Bold"�5+   %   � 5,       � ColumnDefinitions 5-      �� 5.   "   �� 5/   "   $
��auto �63   .+�51      �� ��6&   �� *Salary+�� 52      -   5         ��Name$ 	BCurrency��52   %   $��1��54      
������ $��0q�56      57      58      �� 59      $2��,Какие специалисты нужны��6$   $
��Bold"�5:   %   �� 5;      -   5         ��Name$ 	CCBSkills��5;   "   $��1q�5<      ���#4362a1	 �� DisplayMemberPath$	 
Skill.Name��5?      ��5>      �� *
EventSkill+5?      �� 5@      $%��Время проведения��6$   $
��Bold"�5A   $   :  4System.Windows.Controls.Primitives.DatePickerTextBox  5B      
 �� 
IsReadOnly
 . ��6,   �� *
DateTime+ �� StringFormat$# dd.MM.yyyy  время: MM:mm��5C   (   �� 5F      $(��"Крайний срок сдачи��6$   $
��Bold"�5G   $     5H      
 . ��6,   �� *
Deadline+$ 
dd.MM.yyyy��5I      9� 5J      $��Организатор��6#   
������ .��5L      �� $��10q�6)   .+�5N   "   �� $
��Left=�6-    �� Orientation$ 
Horizontal=�5O   -   .+�5P   &   �� $ 40��6-   $��3q�5Q   
   $	��100��5R   
   $	��100��5S   
   ��5U   *   �� 5V   .    j� Stretch$
 Fill=�69    �� BitmapScalingMode$
 Fant=�5W       �� ImageSource 5X      �� *EventPlanner.Avatar+5Z   '   �� 5[   &   $��10q�5\   0   $��Center=�5]   0   ��5[   0   �� *EventPlanner.FullName+5]   0   5^   #   �� 5b   "   $��Телефон��6,   �� 5c   "   ��6,   �� *EventPlanner.Phone+�� 5e   "   $��E-mail��6,   �� 5f   "   ��6,   �� *EventPlanner.Email+9� 5g   "   $��Отзывы��6+   
������ .��5k   &   �� .��5l   *   �� .+�5n   .   �� -   5        $ BAddComment��5n   5   $!��Добавить отзыв��5q      {�5o   5   �� *isWork+5q      �� 5r   .   ��67   �� *EventPlanner.ReceivingReviews+��5s   2   �� 5t   6   .R�5u   :   �  5v   >   �� 5w   B   �� 5x   B   $��3* �6S   .+�5z   >   �� $ 40��6E   $��3q�5{   -   $��50��5|   -   $��50��5}   -   $��1q�5~   -   ��5   B   �� 5�   F   $
 Fill=�6Q   $
 Fant=�5�   9    5�   9   �� *EventPlanner.Avatar+5�   ?   �� 5�   >   $��1��6I   .+�5�   B   �� $��28(�5�   4   ��5�   L   �� *EventPlanner.FullName+5�   4   �� 5�   B   ��6L   �� *
ContentMsg+(� 5�   B   $��16��5�      $��0,4,0,8q�5�      $
��Left=�5�      .��5�   F   (  "MaterialDesignThemes.Wpf.RatingBar     
IsReadOnly . $��0q�5�         Orientation$ 
Horizontal=�5�         Value 5�      �� *Rating+5�   C   5�   ?   5�   ;   5�   7   ��5�   2   �� 5�   6    �� 
TargetType" ��6<   .�5�   :   ��  �� Property � �� �� Value$ Stretch=�5�   )   5�   7   5�   /   5�   +   5�   '   5�   #   5�      5�      �� 5�      -   5        $ 	BResponse��5�   !   $	��0,5q�5�      $��Откликнуться��5�      5�      �� 5�      -   5        $ BBack��5�   !   $��
Назад��5�      5�      5�      5�      5�      5�      5�      5�      