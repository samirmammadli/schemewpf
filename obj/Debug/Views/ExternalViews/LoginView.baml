   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      D @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views 5      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation 5	      ;"clr-namespace:SchemeWpf.NavigationSchemeWpf.Navigation 5
      -   'SchemeWpf.Views.ExternalViews.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      /localclr-namespace:SchemeWpf.Views     5      0e"clr-namespace:SchemeWpf.Navigation     5	      0s"clr-namespace:SchemeWpf.Navigation     5
        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! /Resources/ButtonStyle.xaml?�6%   6L   �� 5      $! /Resources/UpperWindow.xaml?�6%   6L   %    5      .��5      � .+�5   
   �    upperWindowStyle#��[  6   .+�5      �� $��1q�5       �� CornerRadius$ 10��5       J� SnapsToDevicePixels . ���#474E5C$	��380��5      $	��580��5      
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          ShadowDepth$ 1Q�6'      Color$ #687184��67   ._�5"      � $��10q�6    � RowDefinitions 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      .+�5*      �� 
�������$��0��5,      $��Welcome back!��5-      $��Center=�5.      64   �� 5/      $��Center=�50      $��Center=�51      	 �� Orientation$	 
Horizontal=�52      $��0,0,25,0q�53      $��1��54      .+�55      �� $��/Images/user.png��56      $��17��57      $��20��58      $��0,0,5,0q�59      5:      �� 5;      -   5        $��Email��5>      -  'System.Windows.Input.KeyboardNavigation
   TabIndex$
 0��5=      $��Center=�5?        TextBoxStyle#��[ 5@      
������ ���#707070$��24��5C       �� 
CaretBrush �#707070$	��200��5E      ��5<      �� *Email+.��5E   %   5F      5G      �� 5H      $��Center=�5I      $��Center=�5J      $	 
Horizontal=�5K      $��0,0,25,0q�5L      $��2��5M      .+�5N      �� $��/Images/lock.png��5O      $��17��5P      $��20��5Q      $��0,0,5,0q�5R      6,   �� 5S      -   5        $��Password��5U      $
 1��5T      #��[ 5V      $��Center=�5X      ���#707070
������ $��24��5[      $	��200��5\      $��2��5]       �#707070��5W      �� *
Password+.��5^   *   5_      5`      �� 5a      $
 2��5b        
MainButton#��[ 5c      $��SIGN IN��5d      $��30��5e      $	��200��5f      $��3��5g       � FocusVisualStyle 5a      Z� ��5h      �� *LoginCommand+6<   �� 5i         TabNavigation$
 None=�5j      $��4��5k      $	 
Horizontal=�6"   $��Center=�5l      $��Bottom=�5m      .+�5n      ��   	LilButton#��[ 5o       SchemeWpf.Navigation.VM   SignUpViewModel#��Z 5q      $��Sign up��5r       � Cursor$
 Hand��5s      ��5p      �� *NavigationCommand+5t      �� 5u      #��[ 5v         EmailEnterViewModel#��Z 5x      $��Forgot password?��5y      $
 Hand��5z      ��5w      �� *NavigationCommand+5{      �� 5|      #��[ 5}      $��About��5      $
 Hand��5�      ��5~      �� *SignUp+5�      �� 5�      #��[ 5�      $��Contacts��5�      $
 Hand��5�      ��5�      �� *SignUp+5�      5�      5�      5�      5�      � 5�   
   $
 None=�6+    6   Z� .+�5�      �� ��5�      �� *UpperViewModel+5�      5�      5�      5�      