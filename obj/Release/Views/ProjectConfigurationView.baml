   M S B A M L   `   `   `  ���� D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  3clr-namespace:SchemeWpf.ModelsSchemeWpf.Models  .    (SchemeWpf.Views.ProjectConfigurationView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:SchemeWpf.Views     1modelsclr-namespace:SchemeWpf.Models       � 	Resources     SprintsListTemplate �� DataType  SchemeWpf.Models.Sprint J� SnapsToDevicePixels �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color  BacklogListTemplate  SchemeWpf.Models.BackLog � ColumnDefinitions��%  &	        &	 �    �� "  .R���  . $��35��$��arial)�$��13(�$��DemiBold"�$��0,0,0,3q����� " ��.���  � �� �#e2e4e6��  � �� �#333333��  � �� �� " ��.R��� ���#b6bbc6$��0q�$ 3��#��z��._�� .+��� $ MyContentPresenter��$��10,0,0,0q�$��Center=����� *Name+	 P� 
 �@J�IsMouseOver . . ���  � �� �#838594��  � ��
 �����   $	 0.5Q�$ 	LightGray���� "  .R��� ���#e2e4e6$��1q�$ 3��$��35��._�� ���#e2e4e6 �� �� $��30 �.+��� ���#333333$
��Wrap=�
������ $��Center=�$��	10,7,0,10q�$��0������ *Name+�� $��5q�$��1������ *
DeleteCard+���� " ��.���  � �� �#333333��  � �� �� " ��.R��� ���#b6bbc6$��0q�$ 3��#��z��._��� $��10��$��10��$��/Images/cancel.png��	 P� 
 �@J�IsMouseOver . . ���  � �� �#838594��  � ��
 �����   $	 0.5Q�$ 	LightGray��   $	 0.5Q�$ 	LightGray��.��� ���#545B6A �� �� �� .+��� $	��400��$��0��$��25q����#cfd0d2
������ $��1,1,1,1q�$ 5��$	��Top=�._�� $��5,5,5,0q�
������  � RowDefinitions �� $��20 ��� $��1* ��� $
��auto �.+��� ���#333333$��arial)�$��15(�$
��Bold"�$��Center=�$��Center=�$��Latest Sprints��$��0���� $��0,0,0,8q�$��1��$��Disabled=�$
��Auto��$	��700��
������ 
������ $��Stretch=�#��[  $
��auto�� �� SelectedItem �� *SelectedCard+���� *	Sprints+���� " ��.���  �@�FocusVisualStyle Z� ��  � �� �� " ��.R���  ��Name$ Bd��#��z��#��z��#��z�� �� Padding# z�� . ._��� #��z��# z #��z��	 P� 
 �@J�IsMouseOver . . ���  � ��
 ����    $ 10Q�$ #7b8396���� $	��400��$��1��$��25q����#cfd0d2
������ $��1,1,1,1q�$ 5��$	��Top=�._�� $��5,5,5,0q�
������  �� $��20 ��� $��1* ��� $
��auto �.+��� $��arial)�$��15(����#333333$
��Bold"�$��Center=�$��Center=�$��Backlog��$��0���� $��1��$��Disabled=�$
��Auto��$	��700��
������ 
������ $��Stretch=�#��[ $
��auto��$	��235�� �� *SelectedCard+���� *
Backlogs+���� " ��.���  �@�FocusVisualStyle Z� ��  � �� �� " ��.R��� $ Bd��#��z��#��z��#��z��# z�� . ._��� #��z��# z #��z��	 P� 
 �@J�IsMouseOver . . ���  � ��
 ���� � $��Bottom=�$��2��$��3,0,3,3q�.+��� $
��Left=�$��33��$��14(� � Cursor$
 Hand��$��+ Add another card������ *AddAnotherCardCommand+���� ���� " ��.���  � ��
 ���� ��  � �� �#707070��  � y�$ Visible=���  � �� �� " ��.R��� $ 5��#��z��._�� .+��� $ MyContentPresenter��#��z��$
��Left=�$��5,0,0,0q�$��Center=�	 P� 
 �@J�IsMouseOver . . ���  � ��
 ����  �� Triggers ��  �� Binding �� *AddAnotherCardIsVisible+ �� Value	 false.a���  � y�$ 	Collapsed=���  �� *AddAnotherCardIsVisible+ true.a���  � y�$ Visible=��� $��70�����#cfd0d2
������ $��1,1,1,1q�$ 5��._��  �� $
��auto �$��35���� $��35 � �� �� .+��� $��0��$��2��$��3,0,3,2q�$ 3��
�������
������ ._��� $��2q�$��13(� �� 	MaxLength$ 10�� �� MaxLines$ 1��$��Center=�$��0q����� *NewCardText+ �� UpdateSourceTrigger$ PropertyChanged=�.�� J� InputBindings �� 
 �� Key$ Enter�� �� Command �� *AddACardCommand+ �� CommandParameter �� .��   $ 1Q�$ 	LightGray���� $��1��$��Add Card��$
��Bold"�$
 Hand��$
��auto��$��80��$��3,3,0,0q����� *AddACardCommand+���� ���� " ��.���  � �� �#97C05B��  � ��
 �������  � ��$
 Left=���  � �� �� " ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ���  � �� �#82A54E��  � ��
 �����   $ 1Q�$ 	LightGray���� $��1��$��1��$��Right=�$
 Hand��$��25��$��25��$��3,3,3,0q����� *ExitCardCommand+���� ���� " ��.���  � ��
 ���� ��  � ��$
 Left=���  � �� �� " ��.R��� $ 2��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� $��10��$��10��$��/Images/cancel.png��	 P� 
 �@J�IsMouseOver . . ���  � �� �#B1B2B2���� " �� ��  �� *AddCardIsVisible+	 false.a���  � y�$ 	Collapsed=���  �� *AddCardIsVisible+ true.a���  � y�$ Visible=�   $ 10Q�$ #7b8396��