   M S B A M L   `   `   `  ����D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  5      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation  5      6    0SchemeWpf.Views.ExternalViews.ForgotPasswordView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SchemeWpf.Views     5      0e"clr-namespace:SchemeWpf.Navigation     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! /Resources/ButtonStyle.xaml?�6%   6L   �� 5      $! /Resources/UpperWindow.xaml?�6%   6L   %    5      .��5      � .+�5   
   �    upperWindowStyle#��[  6   .+�5      ��  � Cursor$
 Hand��5      $��1��5      $
��Bold"�5        SchemeWpf.Navigation.VM   LoginViewModel#��Z 5      $��40��5      $��40��5      $��30q�5      $
��Back��5       � FocusVisualStyle 5      Z� ��5      �� *NavigationCommand+��5      �� 5       �� 
TargetType" ��6   .�5       �� -  'System.Windows.Input.KeyboardNavigation �� Property �@ TabNavigation �� Value$
 None=�6M   �� 5!       � �� �#474E5C67   �� 5"       � ��$
 Left=�6@   �� 5#       � ��$	 Top=�6>   �� 5$       � �� 5%      �� 5&   "   	 �� 
TargetType"	 ��62   .R�5'   &   �� 
 �� CornerRadius$
 2��6-   #��z��6>   ._�5(   *   � .+�5)   .   ��  ��Name$ MyContentPresenter��6@   $��20��64   $��/Images/left.png��6\   $��Center=�6v   $��Center=�6�   5*   +   5+   '    �� Triggers 5,   &   P� 5-   *    P� Property �@J�IsMouseOver P� Value . . �5.   .   ��  � �� �#5a63756K   5/   +   51   #   53      54      57      �� 58      $��1q�59      $
 10��5:       J� SnapsToDevicePixels . ���#474E5C$	��380��5=      $	��580��5>      
������  J� Effect 5@      3  -System.Windows.Media.Effects.DropShadowEffect  5A         ShadowDepth$ 1Q�6'      Color$ #687184��67   ._�5C      � $��70q�6    � RowDefinitions 5D      �� 5E      �� 5F      �� 5G      �� 5H      .+�5L      �� $��Center=�5M      $��Center=�5N       �� Orientation$ 
Horizontal=�5O      $��0,0,25,0q�5P      $��0��5Q      .+�5R      �� $��/Images/lock.png��5S      $��17��5T      $��20��5U      $��0,0,5,0q�5V      6,   �� 5W      -   5        $��Password��5X        TextBoxStyle#��[ 5Y      $��Center=�5[      ���#707070
������ $��24��5^      $	��200��5_      $��2��5`       �� 
CaretBrush �#707070��5Z      �� *
Password+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5a   *   5b      5c      �� 5d      $��Center=�5e      $��Center=�5f      $ 
Horizontal=�5g      $��0,0,25,0q�5h      $��1��5i      .+�5j      �� $��/Images/lock.png��5k      $��17��5l      $��20��5m      $��0,0,5,0q�5n      6,   �� 5o      -   5        $��Confirm��5p      #��[ 5q      $��Center=�5s      ���#707070
������ $��24��5v      $	��200��5w      $��2��5x       �#707070��5r      �� *ConfirmPassword+$ TwoWay=�$ PropertyChanged=�.��5y   *   5z      5{      �� 5|      $��Center=�5}      $��Center=�5~      $ 
Horizontal=�5      $��0,0,25,0q�5�      $��2��5�      .+�5�      �� $��/Images/confirm.png��5�      $��17��5�      $��20��5�      $��0,0,5,0q�5�      6,   �� 5�      -   5        $
��Code��5�      #��[ 5�      $��Center=�5�      ���#707070
������ $��24��5�      $	��200��5�      $��2��5�       �#707070��5�      �� *Code+$ TwoWay=�$ PropertyChanged=�.��5�   *   5�      5�      �� 5�        
MainButton#��[ 5�      $��CHANGE PASSWORD��5�      $��30��5�      $	��200��5�      $��5��5�       5�      Z� ��5�      �� *ResetPasswordCommand+6D   5�      5�      5�      � 5�   
      TabNavigation$
 None=�6+    6   Z� .+�5�      �� ��5�      �� *UpperViewModel+5�      5�      5�      5�      