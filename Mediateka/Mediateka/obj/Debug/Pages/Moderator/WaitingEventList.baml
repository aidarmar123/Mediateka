   M S B A M L   `   `   `  ����D  @Mediateka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mediateka.PagesMediateka.Pages  5      &     Mediateka.Pages.WaitingEventList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )localclr-namespace:Mediateka.Pages  5      -   5           MaterialDesignBody#���   5        N� Title$  WaitingEventList��5      .��5      � ���#062949 � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   .@�5      �� $��Мероприятия��6   .��5      �  5      �� 5      $
��auto �6(   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��20, 5q�5      .+�5      �� -   5         ��Name$ BApprove��5   !   $��Одобрить��5!      �� 5"      -   5        $ BNotApprove��5"   !   $
��10,0q�5#      $��Не одобрить��5%   
   �� 5(      -   5         ��Name$ TBSearchEvent��5(   "   $��Center=�5)      $��10, 5q�5*   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Найти заявку��5+      $��20, 5q�5,       ! MaterialDesignOutlinedTextBox#��[ 5-      .��5.   2   50      52      �� 53      -   5         ��Name$ LVEvents��53      $��10, 5q�54      $��2q�57      $��1��58      ��59      �� 5:      .R�5<   "   �� $
��Auto��6-   .+�5=   &   �� $��28(�60   $
��Bold"�5>   $   ��5?      �� *Name+�� 5@   &   $��20(�5A   $   ��5@   0   �� *City+ �� StringFormat$ Город: {0}��5A   $   �� 5B   &   $
��Wrap=�5C   %   ��5B   0   �� *Description+5C   %   �� 5E   &   ��60   �� *StatusEvent.Name+5F   #   5H      ��5J      �� 5K       �� 
TargetType" ��6$   .�5L   "   �� 	 �� Property	 � ��
 �� Value$
 10q�5M      �� 5N   "   	 � ��$
 10q�5O      �� 5P   "   	 � ��
 5Q   &   
� 5R   *   .��5S   .   �  � Color$ #223d74��6;    � Offset$	 1.0Q�6K   � 5T   .   $ #4362a1��6;   $	 0.0Q�6K   5U   +   5W   #   �� 5Z   "   	 � ��
 5[   &   �� 5\   *   .��5]   .   � $ #223d74��6;   $	 0.0Q�6K   � 5^   .   $ #4362a1��6;   $	 1.0Q�6K   5_   +   5a   #   �� 5b   "   	 � ��$
 Stretch=�5c       �� 	Resources 5e   "   ��%c   '��       �� 5f   &   " ��6,   .�5g   *   �� 	 �@��CornerRadius$
 10��5h      5j   '   5k   #   5m      5o      5p      5q      �� 5s      $��Отзывы��6   .��5t      �  5u      �� 5v      $
��auto �6(   �� 5w      .+�5y      �� $ 
Horizontal=�6!   $��20, 5q�5z      .+�5{      �� -   5        $ BDeleteReviews��5{   !   $+��%Удалить комментарий��5}      �� 5�      -   5        $ TBSearchReviews��5�   "   $��Center=�5�   !   $��10, 5q�5�   "   $' !Найти комментарий��5�      $��20, 5q�5�      #��[ 5�      .��5�   ;   5�      5�      �� 5�      -   5        $ 	LVReviews��5�      $��10, 5q�5�      $��1��5�      ��5�      �� 5�      .R�5�   "   �� $
��Auto��6-   .+�5�   &   �� $ 
Horizontal=�61   .+�5�   &   ��  �� CornerRadius$ 40��6-   $��3q�5�      $��50��5�      $��50��5�      $��1q�5�      ��5�   *   �� 5�   .    j� Stretch$
 Fill=�69    �� BitmapScalingMode$
 Fant=�5�       �� ImageSource 5�      �� *SendMsg.Avatar+5�   '   �� 5�   &   $��20(�5�   0   $��5q�5�   0   $
��Bold"�5�   0   $��Center=�5�   0   ��5�   0   �� *SendMsg.Name+5�   0   5�   '   (  "MaterialDesignThemes.Wpf.RatingBar  5�   &      
IsReadOnly . $��0q�5�   /      Orientation$ 
Horizontal=�5�   /      Value 5�   /   �� *Rating+�� 5�   &   $��20(�5�   $   $��5q�5�   0   ��5�   0   �� *
ContentMsg+5�   0   5�   #   5�      ��5�      �� 5�      " ��6$   .�5�   "   �� 	 � ��$
 10q�5�      �� 5�   "   	 � ��$
 10q�5�      �� 5�   "   	 � ��
 5�   &   
� 5�   *   .��5�   .   � $ #223d74��6;   $	 1.0Q�6K   � 5�   .   $ #4362a1��6;   $	 0.0Q�6K   5�   +   5�   #   �� 5�   "   	 � ��
 5�   &   �� 5�   *   .��5�   .   � $ #223d74��6;   $	 0.0Q�6K   � 5�   .   $ #4362a1��6;   $	 1.0Q�6K   5�   +   5�   #   �� 5�   "   	 � ��$
 Stretch=�5�       5�   "   ��%c   '��       �� 5�   &   " ��6,   .�5�   *   �� 	 �@��CornerRadius$
 10��5�      5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      