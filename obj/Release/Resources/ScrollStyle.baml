   M S B A M L   `   `   `  ���� D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SchemeWpf.ViewModelsSchemeWpf.ViewModels  1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  3clr-namespace:SchemeWpf.ModelsSchemeWpf.Models  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089[ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null  �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels	 ��Name   CloningTemplate
 �� DataType    SchemeWpf.Models.BoardList �� CornerRadius.  (MahApps.Metro.IconPacks.PackIconMaterial � CursorE AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind �� IsReadOnlyCaretVisible �� TextWrapping J� InputBindings
 �� Key �� Command �� RelativeSource �� AncestorType �� CommandParameter ��Name �� Triggers J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Color  ScrollBarTrackThumb �Name � RowDefinitions ]�Name ]� Thumb n�Name  ]� IncreaseRepeatButton! ��Name" J� Opacity# ]� DecreaseRepeatButton$ P� 
SourceName  ButtonSelectBrush% �� 
TargetName  	DarkBrush& �� Angle  ProjectsListTemplate' � ColumnDefinitions( �� Color) �� Opacity  NotificationsTemplate�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     )vm"clr-namespace:SchemeWpf.ViewModels  #vclr-namespace:SchemeWpf.Views  )modelsclr-namespace:SchemeWpf.Models  =	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  %�  '��       &	  �     &	 -    '��     &	 <	    &	 L
    �� "  �� P�  � {� . . ���  � ��
 �����P�  � {� .  . ���  � �� �#444444.���  � �� �� " ��.R��� $ Bd��#��z��#��z��#��z�� . ._��� $	 PART_ContentHost���� "
   .R��� ���#e2e4e6���#b6bbc6$��1q�$ 3�� . ._�]� .+�  $
��Left=�$��Center=�
������ $ SizeAll��$ DragVertical=����#999999�� $	��185�� .  $��0,7,0,10q�$��0q�$
 Wrap=�
������ $��Center=�{��� *	IsEnabled+���� *Name+.�� �� $ Enter�� �� *DataContext.ChangeState+ �� $ ListBoxL� �� .���� $��Right=�$	��Top=�$��Right=�$��0,2,2,0q�$��17��$��17��$��3q����� *DataContext.ChangeState+ �� $ ListBoxL����� .���� $��10��$��10������ *ImageSource+���� "  ��.���  � ��
 ���� ��  � �� �� " ��.R��� $ 5��#��z��._�� .+��� $ MyContentPresenter��#��z�� P�  �@J�IsMouseOver . . ���  � �� �#CCCCCC��  � ��
 �����   $	 0.5Q�$ 	LightGray���� "  n�.���  � �� �� " n�.R�� $
 Grid��.+��� $��Stretch=�$��Stretch=�$
��Auto��$
��Auto��
������ �� $ CornerScrollBarRectangle��$ 4��$��Stretch=�$��Stretch=�$
��Auto��$
��Auto��#��z���� "  ��.���  �@��IsFlicksEnabled .  ��  � ��
 �   ���  �@J�Opacity$	 0.3Q���  � ��
 ���� ��  � ��$ 7����  � �� �� " ��.R�� $ GridRoot��$��7��#��z�� �� $��0.00001* �.+�]� $ 
PART_Track��$��0����. |�.   n� $ Thumb��#��z��#���    �� $! PageUp��$��ScrollBar.PageDownCommand��$" 0Q�|�.  # �� $! PageDown��$��ScrollBar.PageUpCommand��$" 0Q�|�.   P� $$ Thumb�� �@J�IsMouseOver . . ��� # �  $% Thumb�� � ��P� $$ Thumb�� �@n�
IsDragging . . ��� # �  $% Thumb�� � ��P�  � {� .  . ��� $% Thumb�� � y�$ 	Collapsed=�P�  �@��Orientation$ 
Horizontal=�. ��� $% GridRoot�� �@�LayoutTransform �� $	& -90Q��� $% 
PART_Track�� �@�LayoutTransform �� $	& -90Q���  � ��$
 Auto����  � ��$ 8���� $% Thumb�� �@�Tag$ 
Horizontal���� $% PageDown�� � ��$ ScrollBar.PageLeftCommand���� $% PageUp�� � ��$  ScrollBar.PageRightCommand���� .R��� $��0,0,0,1q�._�� $��45��' �� $��40 ��� .+��� $��0��$��/Images/board.png��$��20��$��20��$��0,0,5,0q��� $��1��$��Center=�$��Century Gothic)����#D5D5D5$��13(�$
��Bold"����� *Name+���� $( #474E5C��$	) 0.6Q��� .R��� $��0,0,0,1q�._�� $��45��' �� �� .+��� $��Center=�$��Century Gothic)����#D5D5D5$��13(�$
��Bold"�$��0��.��
08.10.18�� $��1��$��Center=�$��Century Gothic)����#D5D5D5$��13(�$
��Bold"����� *Name+���� $( #474E5C��$	) 0.6Q�