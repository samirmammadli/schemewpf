   M S B A M L   `   `   `  ���� D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  (    "SchemeWpf.Views.MainNavigationView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:SchemeWpf.Views       � 	Resources   �� MergedDictionaries �� Source��  �� $* $../Resources/ViewsDataTemplates.xaml?�%    .���  � RowDefinitions �� $��70 ��� .+��� $��0�� �� Orientation$ 
Horizontal=�.+��� $��Bottom=�$��	20,0,0,17q�$��Projects��$��DemiBold"� � Cursor$
 Hand������ *NavigateToprojectCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ���� ��  � �� �#D5D5D5��  � �� �� 	 �� 
TargetType"	 ��.R��� 
 �� CornerRadius$
 5��#��z��._�� .+���  ��Name$ MyContentPresenter��#��z�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��
 ���� ��  � ��
 ������� $��Bottom=�$��	30,0,0,15q�$��Notifications��$��DemiBold"�$
 Hand������ * NavigateToNotificationsCommand+���� " ��.���  � ��
 ���� ��  � �� �#D5D5D5��  � �� �� "	 ��.R��� $
 5��#��z��._��  � ColumnDefinitions �� $��70 ��� $
��auto �.+��� $ MyContentPresenter��#��z���� $��3,0,0,0q�$��1�����#FB4242$
 6������ *BorderWidth+._��� 
�������$��Center=�$
��Bold"�$��Segoe UI)�$��0,0,1,1q�$��Center=����� *CountOfNotifications+ P�  �@J�IsMouseOver . . ���  � ��
 ���� ��  � ��
 ������� $��0,0,0,50q�$��1��._���  � FocusVisualStyle Z� ���� *CurrentViewModel+ J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 3Q�   Color$ #7b8396��