   M S B A M L   `   `   `  ���� D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views      SchemeWpf.Views.BoardView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:SchemeWpf.Views     U QGongSolutions.WPF.DragDrop, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullddurn:gong-wpf-dragdrop    � 	Resources   �� MergedDictionaries �� Source��  �� $# ../Resources/ScrollStyle.xaml?�%    .���  � RowDefinitions �� $��50 ��� .+�� $��0�����#FFFCA6 � ColumnDefinitions �� �� �� .+��� $��0��$��8 Aug��$
��Left=�$��Center=�$��20,0,0,0q����#888888�� $��1��$��Center=�$��Center=�$
��Bold"����#616161���� *CurrentProject.Name+��  � Cursor$
 Hand��$��2��$
��auto��$��50��$��Right=����� *MaxMinProjectCommand+����  �� 
TargetType" ��.���  �� Property � �� �� Value
 ���� ��  � �� �� 	 �� 
TargetType"	 ��.R��� #��z��._�� .+��� 
 ��Name$
 MyContentPresenter��$��20������ *ImageSource+ �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#DFDD92�� $��1��$
��Auto=�$��Disabled=����#545B6A � FocusVisualStyle Z� .���  �� $
��auto ��� $
��auto �.+��� $��0��$��10q����� *
BoardLists+ Z� ���� .R��� $��0��$��25q����#cfd0d2
������ $��1,1,1,1q� �� CornerRadius$ 5��$	��Top=�._�� $��5,5,5,0q�
������  �� $��20 ��� $��1* ��� $
��auto �.+��� $��arial)�$��15(����#333333$
��Bold"�$��Center=�$��Center=�$��0������ *Name+�� $��1��$��Disabled=�$
��Auto��$	��700��
������ 
������ $��Stretch=�   CloningTemplate)  #GongSolutions.Wpf.DragDrop.DragDrop   DragAdornerTemplate# [     IsDragSource .    IsDropTarget . #   UseDefaultEffectDataTemplate . #��[  $
��auto��$	��235�� �� SelectedItem �� *SelectedCard+���� *Cards+���� " ��.���  �@�FocusVisualStyle Z� ��  � �� �� "	 ��.R���  ��Name$ Bd��#��z��#��z��#��z�� �� Padding# z�� J� SnapsToDevicePixels . ._��� #��z��# z #��z�� P�  �@J�IsMouseOver . . ���  � ��
 ���� � $
��Left=�$��Bottom=�$��2��$��3,0,0,3q�$	��230��.+��� $
��Left=�$��33��$	��221��$��14(�$
 Hand��$��+ Add another card������ *AddAnotherCardCommand+���� ���� " ��.���  � ��
 ���� ��  � �� �#707070��  � y�$ Visible=���  � �� �� "	 ��.R��� $ 5��#��z��._�� .+���  ��Name$ MyContentPresenter��#��z��$
��Left=�$��5,0,0,0q�$��Center=� P�  �@J�IsMouseOver . . ���  � ��
 ����  �� Triggers ��  �� Binding �� *AddAnotherCardIsVisible+ �� Value	 false.a���  � y�$ 	Collapsed=���  �� *AddAnotherCardIsVisible+ true.a���  � y�$ Visible=��� $	��227��$��70�����#cfd0d2
������ $��1,1,1,1q�$ 5��._��  �� $
��auto �$��35���� $��35 � �� �� .+��� $��0��$��2��$��3,0,3,2q�$ 3��
�������
�������._��� $��2q�$��13(� �� TextWrapping$
 Wrap=� �� MaxLines$ 10��
������ $��Center=����� *NewCardText+ �� UpdateSourceTrigger$ PropertyChanged=�.�� J� InputBindings �� 
  �� Key$  Enter��! �� Command! �� *AddACardCommand+" �� CommandParameter" �� .��# J� Effect# 3  -System.Windows.Media.Effects.DropShadowEffect  $   ShadowDepth$$ 1Q�%   Color$% 	LightGray���� $��1��$��Add Card��$
��Bold"�$
 Hand��$
��auto��$��80��$��3,3,0,0q����� *AddACardCommand+���� ���� " ��.���  � �� �#97C05B��  � ��
 �������  � ��$
 Left=���  � �� �� "	 ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �#82A54E��  � ��
 �����#   $$ 1Q�$% 	LightGray���� $��1��$��1��$��Right=�$
 Hand��$��25��$��25��$��3,3,3,0q����� *ExitCardCommand+���� ���� " ��.���  � ��
 ���� ��  � ��$
 Left=���  � �� �� "	 ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� $��10��$��10��$��/Images/cancel.png�� P�  �@J�IsMouseOver . . ���  � �� �#B1B2B2���� " �� ��  �� *AddCardIsVisible+	 false.a���  � y�$ 	Collapsed=���  �� *AddCardIsVisible+ true.a���  � y�$ Visible=�#   $$ 10Q�$% #7b8396������ .R��� & �� Orientation$& 
Horizontal=��� $��1��$
��Left=�$	��Top=�$��15,35,295,0q�.+��� $
��Left=�$��40��$	��245��$��14(�$��+ Add another list��$
 Hand������ *AddAnotherList+���� " ��.���  � �� �#4C5463��  � �� �#C5C2C2��  � y�$ Visible=���  � �� �� "	 ��.R��� $ 5��#��z��._�� .+��� $ MyContentPresenter��#��z��$
��Left=�$��5,0,0,0q�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �#444B58��  � �� �#C5C2C2 ��  �� *AddAnotherListButton+	 false.a���  � y�$ Hidden=���  �� *AddAnotherListButton+ true.a���  � y�$ Visible=��� $	��245��$��75�����#cfd0d2
������ $��1,1,1,1q�$ 5��._��  �� $
��auto �$��40���� $��40 � �� �� .+��� $��0��$��2��$��2,5,2,2q�$ 3��
�������$	��215��
�������._��� $��2q�$��13(�' �� 	MaxLength$' 20��$
 Wrap=�
������ $��Center=����� *NewListText+$ PropertyChanged=�.�� �� $  Enter��! �� *	AddList+.��#   $$ 1Q�$% 	LightGray���� $
 Hand��$��1��$��Add List��$
��Bold"�$
��auto��$��80��$��14,3,0,4q����� *	AddList+���� " ��.���  � �� �#97C05B��  � ��
 �������  � ��$
 Left=���  � �� �� "	 ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=� P�  �@J�IsMouseOver . . ���  � �� �#82A54E��  � ��
 �����#   $$ 1Q�$% 	LightGray���� $��1��$��1��$��Right=�$��25��$��25��$��3,3,14,0q�$
 Hand������ *ExitListCommand+���� ���� " ��.���  � ��
 ���� ��  � ��$
 Left=���  � �� �� "	 ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� $��10��$��10��$��/Images/cancel.png�� P�  �@J�IsMouseOver . . ���  � �� �#B1B2B2���� " �� ��  �� *BorderIsVisible+	 false.a���  � y�$ Hidden=���  �� *BorderIsVisible+ true.a���  � y�$ Visible=�