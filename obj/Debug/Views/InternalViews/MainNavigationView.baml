   M S B A M L   `   `   `  ����D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  5      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation  5      6    0SchemeWpf.Views.InternalViews.MainNavigationView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SchemeWpf.Views     5      0e"clr-namespace:SchemeWpf.Navigation     5      ���#474E5C  � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $( "/Resources/ViewsDataTemplates.xaml?�6%   6S   �� 5      $! /Resources/UpperWindow.xaml?�6%   6L   %    5      .��5      � .+�5   
   �    upperWindowStyleInternal#��[  6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��5       �� Orientation$ 
Horizontal=�5      .+�5       �� $��Bottom=�5!      $��	20,0,0,17q�5"        SchemeWpf.Navigation.VM   ProjectsListViewModel#��Z 5$      $��Projects��5%      $��DemiBold"�5&       � Cursor$
 Hand��5'      ��5#      �� *NavigationCommand+��5(      �� 5)       �� 
TargetType" ��6$   .�5*   "   �� 	 �� Property	 � ��
 �� Value

 ���� 6?   �� 5+   "   	 � ��
 �#D5D5D56?   �� 5,   "   	 � ��
 5-   &   �� 5.   *    �� 
TargetType" ��6:   .R�5/   .   ��  �� CornerRadius$ 5��65   #��z��6F   ._�50   2   � .+�51   6   ��  ��Name$ MyContentPresenter��6G   #��z��6c   52   3   53   /    �� Triggers 54   .   P� 55   2    P� Property �@J�IsMouseOver P� Value . . �56   6   �� 	 � ��

 ���� 6S   �� 57   6   	 � ��

 �����6S   58   3   5:   +   5<   #   5=      5?      �� 5@      $��Bottom=�5A      $��	30,0,0,15q�5B      $��Notifications��5C         NotificationsViewModel#��Z 5E      $��DemiBold"�5F      $
 Hand��5G      ��5D      �� *NavigationCommand+��5H      �� 5I      " ��6$   .�5J   "   �� 	 � ��

 ���� 6?   �� 5K   "   	 � ��
 �#D5D5D56?   �� 5L   "   	 � ��
 5M   &   �� 5N   *   " ��6:   .R�5O   .   �� $ 5��65   #��z��6F   ._�5P   2   �  5Q   6   �� 5R   :   $��70 �6K   �� 5S   :   $
��auto �6K   .+�5U   6   �� $ MyContentPresenter��5V   1   #��z��5W   1   �� 5X   6   $��3,0,0,0q�5Y   1   $��1��5Z   1   ���#FB4242$ 6��5\   1   ��5]   1   �� *BorderWidth+._�5^   :   �� 
�������$��Center=�5`   =   $
��Bold"�5b   =   $��Segoe UI)�5c   =   $��0,0,1,1q�5d   =   $��Center=�5e   =   ��5a   =   �� *CountOfNotifications+5e   =   5f   7   5g   3   5h   /    5i   .   P� 5j   2    �@J�IsMouseOver . . �5k   6   �� 	 � ��

 ���� 6S   �� 5l   6   	 � ��

 �����6S   5m   3   5o   +   5q   #   5r      5t      5v      �� 5x      $��1��5y      $��Bottom=�5z      $��Right=�5{      $��	0,0,20,17q�5|      $��Sign out��5~      $��DemiBold"�5      $
 Hand��5�      ��5}      �� *	SignOut+��5�      �� 5�      " ��6    .�5�      �� 	 � ��

 ���� 6;   �� 5�      	 � ��
 �#D5D5D56;   �� 5�      	 � ��
 5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ 5��61   #��z��6B   ._�5�   .   � .+�5�   2   �� $ MyContentPresenter��6C   #��z��6_   5�   /   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver . . �5�   2   �� 	 � ��

 ���� 6O   �� 5�   2   	 � ��

 �����6O   5�   /   5�   '   5�      5�      5�      5�      �� 5�      $��0,0,0,50q�5�      $��1��5�      ._�5�      ��  � FocusVisualStyle 5�      Z� ��5�      �� *CurrentViewModel+ J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         ShadowDepth$ 3Q�6#      Color$ #7b8396��63   5�      5�      � 5�      -  'System.Windows.Input.KeyboardNavigation   TabNavigation$
 None=�6'    6   Z� .+�5�   
   �� ��5�      �� *UpperViewModel+5�      5�      5�      5�      