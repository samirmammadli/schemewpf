   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      D @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views 5      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation 5      .   (SchemeWpf.Views.ExternalViews.SignUpView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      /localclr-namespace:SchemeWpf.Views     5      0e"clr-namespace:SchemeWpf.Navigation     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! /Resources/ButtonStyle.xaml?�6%   6L   �� 5      $! /Resources/UpperWindow.xaml?�6%   6L   %    5      .��5      � .+�5   
   �    upperWindowStyle#��[  6   .+�5   
   ��  � Cursor$
 Hand��5      $��1��5      $
��Bold"�5       SchemeWpf.Navigation.VM   LoginViewModel#��Z 5      $��40��5      $��40��5      $��30q�5      $
��Back��5       � FocusVisualStyle 5      Z� ��5      �� *NavigationCommand+��5      �� 5        �� 
TargetType" ��6   .�5!      �� -  'System.Windows.Input.KeyboardNavigation �� Property �@ TabNavigation �� Value$
 None=�6I   �� 5"       � �� �#474E5C63   �� 5#       � ��$
 Left=�6<   �� 5$       � ��$	 Top=�6:   �� 5%       � �� 5&      �� 5'      	 �� 
TargetType"	 ��6.   .R�5(   "   �� 
 �� CornerRadius$
 2��6)   #��z��6:   ._�5)   &   � .+�5*   *   ��  ��Name$ MyContentPresenter��6<   $��20��60   $��/Images/left.png��6X   $��Center=�6r   $��Center=�6�   5+   '   5,   #    �� Triggers 5-   "   P� 5.   &    P� Property �@J�IsMouseOver P� Value . . �5/   *   ��  � �� �#5a63756G   50   '   52      54      55      58      �� 59      $��1q�5:      $
 10��5;       J� SnapsToDevicePixels . ���#474E5C$	��380��5>      $	��580��5?      
������  J� Effect 5A      3  -System.Windows.Media.Effects.DropShadowEffect  5B         ShadowDepth$ 1Q�6'      Color$ #687184��67   ._�5D      � $��10q�6    � RowDefinitions 5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      .+�5N      �� $��Center=�5O      $��Center=�5P       �� Orientation$ 
Horizontal=�5Q      $��0,0,25,0q�5R      $��0��5S      .+�5T      �� $��/Images/user.png��5U      $��17��5V      $��20��5W      $��0,0,5,0q�5X      5Y      �� 5Z      -   5        $
��Name��5[      $��Center=�5]        TextBoxStyle#��[ 5^      
������ ���#707070$��24��5a       �� 
CaretBrush �#707070$	��200��5c      ��5\      �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��5c   %   5d      5e      �� 5f      $��Center=�5g      $��Center=�5h      $ 
Horizontal=�5i      $��0,0,25,0q�5j      $��1��5k      .+�5l      �� $��/Images/user.png��5m      $��17��5n      $��20��5o      $��0,0,5,0q�5p      5q      �� 5r      -   5        $��Surname��5s      $��Center=�5u      #��[ 5v      
������ ���#707070$��24��5y       �#707070$	��200��5{      ��5t      �� *	Surname+$ TwoWay=�$ PropertyChanged=�.��5{   %   5|      5}      �� 5~      $��Center=�5      $��Center=�5�      $ 
Horizontal=�5�      $��0,0,25,0q�5�      $��2��5�      .+�5�      �� $��/Images/envelope.png��5�      $��18��5�      $��20��5�      $��0,0,5,0q�5�      5�      �� 5�      -   5        $��Email��5�      $��Center=�5�      #��[ 5�      
������ ���#707070$��24��5�       �#707070$	��200��5�      ��5�      �� *Email+$ TwoWay=�$ PropertyChanged=�.��5�   %   5�      5�      �� 5�      $��Center=�5�      $��Center=�5�      $ 
Horizontal=�5�      $��0,0,25,0q�5�      $��3��5�      .+�5�      �� $��/Images/lock.png��5�      $��17��5�      $��20��5�      $��0,0,5,0q�5�      6,   �� 5�      -   5        $��Password��5�      #��[ 5�      $��Center=�5�      ���#707070
������ $��24��5�      $	��200��5�      $��2��5�       �#707070��5�      �� *
Password+$ TwoWay=�$ PropertyChanged=�.��5�   *   5�      5�      �� 5�      $��Center=�5�      $��Center=�5�      $ 
Horizontal=�5�      $��0,0,25,0q�5�      $��4��5�      .+�5�      �� $��/Images/lock.png��5�      $��17��5�      $��20��5�      $��0,0,5,0q�5�      6,   �� 5�      -   5        $��Confirm��5�      #��[ 5�      $��Center=�5�      ���#707070
������ $��24��5�      $	��200��5�      $��2��5�       �#707070��5�      �� *ConfirmPassword+$ TwoWay=�$ PropertyChanged=�.��5�   *   5�      5�      �� 5�        
MainButton#��[ 5�      $��SIGN UP��5�      $��30��5�      $	��200��5�      $��5��5�       5�      Z� ��5�      �� *SignUp+66   5�      5�      5�      � 5�         TabNavigation$
 None=�6'    6   Z� .+�5�   
   �� ��5�      �� *UpperViewModel+5�      5�      5�      5�      