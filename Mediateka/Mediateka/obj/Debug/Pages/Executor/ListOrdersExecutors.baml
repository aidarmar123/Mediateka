   M S B A M L   `   `   `  ����D  @Mediateka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mediateka.PagesMediateka.Pages  5      )    #Mediateka.Pages.ListOrdersExecutors   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )localclr-namespace:Mediateka.Pages  5         MaterialDesignBody#���   5      $��18(�5	        N� Title$  ListOrdersExecutors��5      .��5      � ���#062949.+�5   
   �� $��5q�6   .@�5      �� $��Заказы��6   .��5      �  � RowDefinitions 5      �� 5      $
��auto �6(   �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ TBSearch��5   "   $��Center=�5      $��10, 5q�5   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Найти заказ��5      $��20, 5q�5       ! MaterialDesignOutlinedTextBox#��[ 5      .��5    2   5"      �� 5#      -   5        $-��'Рейтинг организатора��5#   $   $
��Bold"�5%   $   $��Center=�5&   $   (  "MaterialDesignThemes.Wpf.RatingBar  5'      -   5          Name$ 	RatingBar��5(      $��Center=�5+      5,      �� 5-      -   5         ��Name$ LVEvents��5-      $��1��5/      ��50      �� 51      .R�52   "   �� .+�53   &   �� $��28(�60   $
��Bold"�54   0   ��55      �� *Name+�� 56   &   $��18(�57   0   ��56   0   �� *City+ �� StringFormat$ Город: {0}��57   0   �� 58   &   $��18(�6{   $
��Wrap=�59   !   ��58   0   �� *Description+59   !   �� 5;   &   y�60   �� *	isComment+��5<   0   �� *CommentExecutor+$&  Причина отказа: {0}���� 5=   &   .+�5>   *   ��  ��Name$ 	BResponse��61   -   5        $��5q�5@   "   $��Right=�5A      $��Откликнуться��5C      {�5?   1   �� *IsNotResponseExecutor+5C      5D   '   5F   #   5H      ��5J      �� 5K      	 �� 
TargetType"	 ��6$   .�5L   "   �� 
 �� Property
 � �� �� Value$ 10q�5M      �� 5N   "   
 � �� 5O   &   
� 5P   *   .��5Q   .   �  � Color$ #223d74��6;    � Offset$	 1.0Q�6K   � 5R   .   $ #4362a1��6;   $	 0.0Q�6K   5S   +   5U   #   �� 5W   "   
 � ��$ 10q�5X   
   �� 5Y   "   
 � �� 5Z   &   �� 5[   *   .��5\   .   � $ #223d74��6;   $	 0.0Q�6K   � 5]   .   $ #4362a1��6;   $	 1.0Q�6K   5^   +   5`   #   �� 5a   "   
 � ��$ Stretch=�5b       �� 	Resources 5d   "   ��%c   '��       �� 5e   &   "	 ��6,   .�5f   *   �� 
 �@��CornerRadius$ 10��5g      5h   '   5i   #   5j      5l      5m      5n      �� 5o      $%��Одобреные заказы��6   .��5q      �  5r      �� 5s      $
��auto �6(   �� 5t      .+�5v      �� $ 
Horizontal=�6!   .+�5w      �� -   5        $ BUpload��5w   !   $	��5,0q�5x   !   $'��!Добавить материал��5z      5|      �� 5~      -   5        $ LVOrders��5~      $��1��5      ��5�      �� 5�      .R�5�   "   �� .+�5�   &   �� $
��Bold"�5�   0   $��32(�5�   0   ��5�   0   �� *
Event.Name+5�   0   �� 5�   &   ��60   �� *Event.DateTime+$ Дата dd.MM.yyyy���� 5�   &   ��60   �� *Event.DateTime+$ Время HH:mm���� 5�   &   ��60   �� *Event.Deadline+$/ )Срок сдачи dd.MM.yyyy до HH:mm��&   System.Windows.Controls.DataGrid  5�   &   $��10q�5�   /      
IsReadOnly .    AutoGenerateColumns .  ��5�   /   �� *Event.ContextMaterialEvent+   Columns 5�   *   0  *System.Windows.Controls.DataGridTextColumn  5�   .   ,  &System.Windows.Controls.DataGridColumn   Header$ Имя файла��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   A   �� *
NameFile+  5�   .   $ Комментарий��6A    5�   A   �� *CommentFile+   ElementStyle 5�   2   �� 5�   6   "	 ��6<   .�5�   :   �� 
 � ��$
 Wrap=�6Y   5�   7   5�   /     5�   .   $! Дата отправким��6A    5�   A   �� *DateTimeSend+4  .System.Windows.Controls.DataGridTemplateColumn  5�   .      CellTemplate 5�   2   �� 5�   6   .R�5�   :   �� $ BRemoveFile��6A   -   5        $��Удалить файл��5�      5�   7   5�   /   5�   '   5�   #   5�      ��5�      �� 5�      "	 ��6$   .�5�   "   �� 
 � ��$ 10q�5�      �� 5�   "   
 � ��$ 10q�5�   )   �� 5�   "   
 � �� 5�   &   
� 5�   *   .��5�   .   � $ #223d74��6;   $	 1.0Q�6K   � 5�   .   $ #4362a1��6;   $	 0.0Q�6K   5�   +   5�   #   �� 5�   "   
 � �� 5�   &   �� 5�   *   .��5�   .   � $ #223d74��6;   $	 0.0Q�6K   � 5�   .   $ #4362a1��6;   $	 1.0Q�6K   5�   +   5�   #   �� 5�   "   
 � ��$ Stretch=�5�       5�   "   ��%c   '��       �� 5�   &   "	 ��6,   .�5�   *   �� 
 �@��CornerRadius$ 10��5�      5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      