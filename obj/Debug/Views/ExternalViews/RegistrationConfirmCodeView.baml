   M S B A M L   `   `   `  ����D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  5      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation  5      ?    9SchemeWpf.Views.ExternalViews.RegistrationConfirmCodeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SchemeWpf.Views     5      0e"clr-namespace:SchemeWpf.Navigation     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! /Resources/ButtonStyle.xaml?�6%   6L   �� 5      $! /Resources/UpperWindow.xaml?�6%   6L   %    5      .��5      � .+�5   
   �    upperWindowStyle#��[  6   .+�5   
   � .+�5      �� $��20��6   $	��200��6"   ��6.   �� *Code+6F   �� 5      $��20��6   $	��200��6!   $��	0,100,0,0q�6-   ��6@   �� *ConfirmCommand+.��6c   	Confirm6l   5      �� 5   
    � Cursor$
 Hand��5      $��1��5      $
��Bold"�5        SchemeWpf.Navigation.VM   LoginViewModel#��Z 5      $��40��5      $��40��5       $��30q�5!      $
��Back��5"       � FocusVisualStyle 5      Z� ��5      �� *NavigationCommand+��5#      �� 5$       �� 
TargetType" ��6   .�5%      �� -  'System.Windows.Input.KeyboardNavigation �� Property �@ TabNavigation �� Value$
 None=�6I   �� 5&       � �� �#474E5C63   �� 5'       � ��$
 Left=�6<   �� 5(       � ��$	 Top=�6:   �� 5)       � �� 5*      �� 5+      	 �� 
TargetType"	 ��6.   .R�5,   "   �� 
 �� CornerRadius$
 2��6)   #��z��6:   ._�5-   &   � .+�5.   *   ��  ��Name$ MyContentPresenter��6<   $��20��60   $��/Images/left.png��6X   $��Center=�6r   $��Center=�6�   5/   '   50   #    �� Triggers 51   "   P� 52   &    P� Property �@J�IsMouseOver P� Value . . �53   *   ��  � �� �#5a63756G   54   '   56      58      59      5<      �� 5=   
   $��1q�5>      $
 10��5?       J� SnapsToDevicePixels . ���#474E5C$	��380��5B      $	��580��5C      
������  J� Effect 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F         ShadowDepth$ 1Q�6#      Color$ #687184��63   ._�5H      � $��10q�6    � RowDefinitions 5I      �� 5J      �� 5K      .+�5N      �� $��Bottom=�5O      $��Center=�5P       �� Orientation$ 
Horizontal=�5Q      $��0,0,25,0q�5R      $��0��5S      .+�5T      �� $��/Images/user.png��5U      $��17��5V      $��20��5W      $��0,0,5,0q�5X      5Y      �� 5Z      -   5        $
��Code��5[      $��Center=�5]        TextBoxStyle#��[ 5^      
������ ���#707070$��24��5a       �� 
CaretBrush �#707070$	��200��5c      ��5\      �� *Code+.��5c   %   5d      �� 5e      .+�5f      �� $��24��5g      $��55��5h      $��10,0,0,0q�5i      $
 Hand��5j      ��5k      �� *ResendCommand+.��6?   Resend��5m      �� 5n   "   " ��6(   .�5o   &   ��  � �� �#5861726C   �� 5p   &    � ��
 �����6C   �� 5q   &    � ��$
 Left=�6L   �� 5r   &    � �� 5s   *   �� 5t   .   "	 ��6>   .R�5u   2   ��  �� Padding$ 0,0,0,2q�69   $
 2��6K   #��z��6\   ._�5v   6   � .+�5w   :   ��  ��Name$ MyContentPresenter��6K   #��z��6g   $��Center=�6�   $��Center=�6�   5x   7   5y   3    5z   2   P� 5{   6    �@J�IsMouseOver . . �5|   :   ��  � �� �#646e826W   5}   7   5   /   5�   '   5�   #   5�      5�      5�      �� 5�      $	��Top=�5�      $��0,20,0,0q�5�        
MainButton#��[ 5�      $��CONFIRM��5�      $��30��5�      $	��200��5�      $��1��5�       5�      Z� ��5�      �� *ConfirmCommand+6>   5�      5�      5�      � 5�         TabNavigation$
 None=�6'    6   Z� .+�5�   
   �� ��5�      �� *UpperViewModel+5�      5�      5�      5�      