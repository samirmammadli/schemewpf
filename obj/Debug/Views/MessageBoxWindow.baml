   M S B A M L   `   `   `  ����D  @SchemeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SchemeWpf.ViewsSchemeWpf.Views  5   	   &     SchemeWpf.Views.MessageBoxWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SchemeWpf.Views     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�6    � ShowInTaskbar .   � AllowsTransparency . 
������ $	��180��5
      $	��300��5      .��5      � .+�5   
   �� 
�������$	��150��5      $	��280��5      $��Center=�5      $��0q�5       �� CornerRadius$ 10��5      ._�5      �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��Center=�5      $��Center=�5      $��0��5      $��DemiBold"�5      $��13(�5       $
��Wrap=�5!      $��	10,0,10,0q�5"      ���#2c2b25��5#   *   �� *	Message+6E   �� 5$      $��Center=�5%       � Cursor$
 Hand��5&      $��2��5'      $��OK��5(      $
��Bold"�5)      $��30��5+      $��80��5,      ��5*      �� *	OkCommand+��5-      �� 5.       �� 
TargetType" ��6    .�5/      ��  �� Property � ��	 �� Value	 �#89d4f76;   �� 50       � ��
	 �����6;   �� 51       � ��$
	 Left=�6D   �� 52       � ��	 53   "   �� 54   &   
 �� 
TargetType"
 ��66   .R�55   *   �� $ 10��61   #��z��6C   ._�56   .   � .+�57   2   ��  ��Name$ MyContentPresenter��6C   #��z��6_   $��Center=�6�   $��Center=�6�   58   /   59   +    �� Triggers 5:   *   P� 5;   .    P� Property �@J�IsMouseOver P� Value . . �5<   2   ��  � ��	 �#78bbdb6O   �� 5=   2    � ��
	 �����6O   5>   /   5@   '   5B      5C      5E      5F      5G      5H      5I      