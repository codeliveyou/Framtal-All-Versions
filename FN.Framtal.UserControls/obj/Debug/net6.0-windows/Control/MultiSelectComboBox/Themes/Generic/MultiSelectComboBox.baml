   M S B A M L   `   `   `  ����R  NFN.Framtal.UserControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:FN.Framtal.UserControls.Control.API#FN.Framtal.UserControls.Control.API  5      Q-clr-namespace:FN.Framtal.UserControls.ControlFN.Framtal.UserControls.Control  5      �Iclr-namespace:FN.Framtal.UserControls.Control.MultiSelectComboBoxControls;FN.Framtal.UserControls.Control.MultiSelectComboBoxControls  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 2  .MultiSelectComboBox.DropDown.Button.Background  �� Color . *MultiSelectComboBox.DropDown.Button.Border ; 7MultiSelectComboBox.DropDown.Button.Disabled.Background 7 3MultiSelectComboBox.DropDown.Button.Disabled.Border ; 7MultiSelectComboBox.DropDown.Button.Disabled.Foreground < 8MultiSelectComboBox.DropDown.Button.MouseOver.Background 8 4MultiSelectComboBox.DropDown.Button.MouseOver.Border : 6MultiSelectComboBox.DropDown.Button.Pressed.Background 6 2MultiSelectComboBox.DropDown.Button.Pressed.Border ?	 ;MultiSelectComboBox.DropDown.ListBox.GroupHeader.Background ?
 ;MultiSelectComboBox.DropDown.ListBox.GroupHeader.Foreground E AMultiSelectComboBox.DropDown.ListBoxItem.SelectedOrder.Foreground @ <MultiSelectComboBox.DropDown.ListBoxItem.Selector.Background < 8MultiSelectComboBox.DropDown.ListBoxItem.Selector.Border @ <MultiSelectComboBox.DropDown.ListBoxItem.Selected.Background < 8MultiSelectComboBox.DropDown.ListBoxItem.Selected.Border + 'MultiSelectComboBox.SelectedItem.Border 6 2MultiSelectComboBox.SelectedItem.Button.Foreground < 8MultiSelectComboBox.SelectedItem.Button.Hover.Background < 8MultiSelectComboBox.SelectedItem.Button.Light.Foreground 1 -MultiSelectComboBox.SelectedItemsPanel.Border ' #MultiSelectComboBox.Text.FontFamily 0 ,MultiSelectComboBox.Text.Disabled.Foreground ' #MultiSelectComboBox.Text.Foreground # MultiSelectComboBox.FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  MultiSelectComboBox.Style �� 
TargetType . *MultiSelectComboBox.DefaultTextBlock.Style �� Triggers �� Binding �� RelativeSource	 �� AncestorType
 �� Value D @MultiSelectComboBox.SelectedItemsPanel.WrapableItemsSource.Style � Orientation - )MultiSelectComboBox.DropDown.Button.Style �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName ; 7MultiSelectComboBox.Dropdown.ListBox.ItemContainerStyleU    OFN.Framtal.UserControls.Control.MultiSelectComboBoxControls.ExtendedListBoxItem �� Path �� Padding    	IsChecked d� 	IsChecked9   3FN.Framtal.UserControls.Control.MultiSelectComboBox . *MultiSelectComboBox.Dropdown.ListBox.StyleQ   KFN.Framtal.UserControls.Control.MultiSelectComboBoxControls.ExtendedListBox �� Self B >MultiSelectComboBox.SelectedItemsPanel.RemoveItem.Button.Style 9  5MultiSelectComboBox.SelectedItems.ItemContainer.Style �� CornerRadius �� Orientation ��Name � ToolTip �� Stretch ^� 
Conditions �� Binding �� Value B! >MultiSelectComboBox.SelectedItemsPanel.EditMode.Glyph.Template B" >MultiSelectComboBox.SelectedItemsPanel.Readonly.Glyph.Template 3# /MultiSelectComboBox.SelectedItemsPanel.Template  � ColumnDefinitionsU   OFN.Framtal.UserControls.Control.MultiSelectComboBoxControls.ContentItemsControl!  Name" � 	Resources $ Key# ��Name$ � ForceCursor% �� TextWrapping& �� 
IsReadOnly' �� Triggers 8% 4MultiSelectComboBox.Dropdown.ListBox.Header.Template( �� DataType) �� Padding* �Name+ � ActualWidth-  'System.Windows.Input.KeyboardNavigation,   TabNavigation- �� Mode. �Name/ � AllowsTransparency0 �� ElementName1 � PlacementTarget2 �� ClearTypeHint3 ��Name4 ��Name5  Name6 �� 
GroupStyle(  "System.Windows.Controls.GroupStyle7   HeaderTemplate�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      9api1clr-namespace:FN.Framtal.UserControls.Control.API  5      9control-clr-namespace:FN.Framtal.UserControls.Control  5      imultiSelectComboBoxControlsIclr-namespace:FN.Framtal.UserControls.Control.MultiSelectComboBoxControls  5      %�:  &	        &	 %     &	 H     &	 k     &	 �     &	 �     &	 �     &	 �     &	     &		 =    &	
 ^    &	 }    &	 �    &	 �    &	 �    &	     &	 "    &	 E    &	 h    &	 �    &	 �    &	 �    &	 �    &	     &	 5    &	 �    &	 �    7  7  7  &	 �    7  &	 �
    7   7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  &	 ,    7  7  &	 �    7  7  &	  $!    7  7  7  &	! %    7  &	" �%    7  &	# �&    7  7   7  7  7 " 7 ! 7 ! &	% �/    7 	 7  7 
 '  {0    7  7 # 7  7 % 7  �� 5      $  Transparent��6M   �� 5      $  	#FF707070��6I   �� 5	      $  	#FFF4F4F4��6V   �� 5
      $  	#FFADB2B5��6R   �� 5      $  	#FF838383��6V   �� 5      $  	#FFF4F4F4��6W   �� 5      $  	#FF3C7FB1��6S   �� 5      $  	#FFF4F4F4��6U   �� 5      $  	#FF2C628B��6Q   �� 5      $  #f7f7f7��6Z   �� 5      $  Black��6Z   �� 5      $  #5291DB��6`   �� 5      $  #EEF8FE��6[   �� 5      $  #CDE6F7��6W   �� 5      $  #CDE6F7��6[   �� 5      $  #0096D6��6W   �� 5      $  	#FFACACAC��6F   �� 5      $  	#FF606060��6Q   �� 5      $  #F7F7F7��6W   �� 5      $  	#FF808080��6W   �� 5      $  	#FFACACAC��6L   *�5       Segoe UI)�6G   �� 5!      $  	#FFB8B3B3��6K   �� 5"      $  	#FF000000��6B   �� 5$      .�5%   
   ��  � �� 5&      �� 5'      .R�5(      �� $��2q�5)      $
 true��5*      #��� ��5+      $	 1 2R�5,      $��1��5-      5.      50      51      �� 53      " �6.   .�54   
   ��  � ��$
 Auto��6#   �� 55   
    � ��$
 Auto��6"   �� 56   
    �@J�SnapsToDevicePixels$
 True��60   �� 57   
    � ��$ 0q�6#   �� 58   
    �@�OverridesDefaultStyle$
 True��62   �� 59   
   " �@%�IsVirtualizingWhenGrouping$
 True��6I   �� 5:   
     �@%�IsContainerVirtualizable$
 True��6G   5;      �� 5=      " ��6?   .�5>   
   ��  � ��8   6'   �� 5?   
    � ��$ 11(�6%   �� 5@   
    � ��$ Stretch=�60   �� 5A   
    � ��$ Center=�6.   �� 5B   
    � ��$ Center=�6=   �� 5C   
    � ��$ NoWrap=�6)   �� 5D   
    � ��$ CharacterEllipsis=�6)   �� 5E   
    �@��Padding$ 1q�6$   �� 5F   
    � ��$ 1q�6#   �� 5G   
    � ��8  6'   �� 5H   
    �@��TextAlignment$
 Left=�6*    5I   
   �� 5J       6   �� *	IsEnabled+ �� "	 d�	
 False6|   .a�5K      ��  � ��8  6/   5L      5N      �� 5P      " ��6U   .�5Q   
   ��  � ��8   6'   �� 5R   
    � ��$ 11(�6%   �� 5S   
    �@J�SnapsToDevicePixels$
 True��60   �� 5T   
    �@�OverridesDefaultStyle$ False��62   �� 5U   
    � ��
 ���� 6'   �� 5V   
    � ��$ False��6&   �� 5W   
    � �� 5X      �� 5Y      .R�5Z      �� $
��True��5[      $��Disabled=�5\      $
��Auto=�5]      .��5^      �� 5_      5`      5b      �� 5c   
    � �� 5d      �� 5e      .R�5f      � $ 
Horizontal=�6�   ��6    �� *SelectedItemsPanelBackground+ �� 	 control:MultiSelectComboBox6�   5g      5i      5j      �� 5l      " ��6>   .�5m   
   ��  � ��8   6'   �� 5n   
    � ��8  6(   �� 5o   
    � ��# � ��6'   �� 5p   
    � ��$ 0q�6,   �� 5q   
    � ��$ Center=�67   �� 5r   
    � ��$ Center=�65   �� 5s   
    � ��$ 0,0,2,0q�6$   �� 5t   
    � ��$ False��6&   �� 5u   
    � �� 5v      �� 5w      " ��6"   .R�5x      �� $ border��5y      #��z��5z      #��z��5{      #��z��5|      $
 true��5}      ._�5~      �� $ contentPresenter��5      #��z��5�      #��z��5�      #��z��5�      $��False��5�      # z 5�      5�       5�      P� 5�       �@��IsDefaulted$
 true��69   . �5�      �� $ border��6%   # � ��6P    � ��5�      P� 5�       �@J�IsMouseOver$
 true��69   . �5�      �� $ border��6%   8   � ��6O   �� 5�      $ border��6%   8   � ��6P   5�      P� 5�       � ��$
 true��67   . �5�      �� $ border��6%   8   � ��6O   �� 5�      $ border��6%   8   � ��6P   5�      P� 5�       � {�$ false��67   . �5�      �� $ border��6%   8   � ��6O   �� 5�      $ border��6%   8   � ��6P   �� 5�      $ contentPresenter��6%   8   � ��6e   5�      5�      5�      5�      �� 5�      "   6L   .�5�   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5�   
    � ��$ 1q�6$   �� 5�   
    � ��$ 0q�6#   �� 5�   
    � �� 67   �� *HorizontalContentAlignment+ �� "	 ���� 5�   
    � �� 65   �� *VerticalContentAlignment+ �� "	 ���� 5�   
    � ��
 ���� 6'   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � {� 6&   �� $ 	IsEnabled��� 5�   
    �@�FocusVisualStyle8   6-   �� 5�   
    � �� 5�      �� 5�      "   6"   .R�5�      �� $ Bd��5�      # z��5�      #��z��5�      #��z��5�      #��z��5�      $
 true��5�      ._�5�      d� $��0q�5�      $��0q�5�      $��Stretch=�5�      
�������$��0q�5�      # z 5�      ��5�      �� 5�   "   " d�62   .R�5�   &   �� $ border��5�   )   $��Stretch=�5�   )   8�� $��1q�5�   )   ._�5�   *   �� $��	2,-2,0,-2q�5�   -   ��5�   -   �� ��5�   -   ��  �� *FindAncestor+"	  $" DropdownItemTemplateSelector�5�   '    5�   &   P� 5�   *    �@��IsDefaulted$
 true��6P   . �5�   .   �� $ border��65   8   � ��6`   5�   +   P� 5�   *    �@J�IsMouseOver$
 true��6I   . �5�   .   �� $ border��65   8   � ��6_   �� 5�   .   $ border��65   8   � ��6`   5�   +   P� 5�   *    �@d�	IsChecked$ falseY�6G   . �5�   .   �� $ border��65    � ��
 ���� 6`   5�   +   P� 5�   *    �@d�	IsChecked$
 trueY�6G   . �5�   .   �� $ border��65   8   � ��6_   �� 5�   .   $ border��65   8   � ��6`   5�   +   5�   #   5�      5�       5�      P� 5�       � {�$ False��67   . �5�      �� $ Bd��6%   # � ��6W    � ��5�      P� 5�       �@��
IsSelected$
 True��6A   . �5�      �� $ Bd��6%   8   � ��6K   5�      5�      5�      5�      �� 5�      "  6?   .�5�   
   ��  � ��8   6'   �� 5�   
    � ��$ 11(�6%   �� 5�   
    �@w�TextPath$
 Name��60   �� 5�   
    �@��IsTextSearchEnabled$
 True��60   �� 5�   
   % �@��IsSynchronizedWithCurrentItem$
 TrueY�6:   �� 5�   
   ! �@��IsTextSearchCaseSensitive$ False��66   �� 5�   
    �@��SelectionMode$ Single=�6*   �� 5�   
    � ��$ Stretch=�67   �� 5�   
   " �@%�IsVirtualizingWhenGrouping$
 True��6I   �� 5�   
     �@%�IsContainerVirtualizable$
 True��6G   �� 5�   
    �@%�IsVirtualizing$
 True��6B   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��8  6/   �� 5�   
    � �� 5�      �� 5�      .R�5�      $� ��6-   �� *DropDownPopupBackground+ �� 	 control:MultiSelectComboBox5�      5�       5�   
   �� 5�       6   �� # Z $ Items.Count�
 06n   .a�5�      ��  � �� 5�      �� 5�      .R�5      �� $ 4q�5  !   
�������$��1q�5  !   ._�5  "   �� No results found.6?   5     5     5     5	     5     �� 5     " ��6S   .�5  
   ��  � ��8   6'   �� 5  
    � �� 6'   Z� �� 5  
    � �� 6(   Z� �� 5  
    � ��$ 0q�6,   �� 5  
    � ��$ 0q�6$   �� 5  
    � ��$ 	-1,0,0,-1q�6#   �� 5  
    �@�Cursor$
 Hand��6#   �� 5  
    � ��$ False��6&   �� 5  
    � ��$ Center=�67   �� 5  
    � ��$ Center=�65   �� 5  
    � ��$ Center=�60   �� 5  
    � ��$ Center=�6.   �� 5  
    � ��$ 16��6#   �� 5  
    � ��$ 16��6"   �� 5  
    � �� 5     �� 5     " ��6"   .R�5     �� $ border��5      
������ 
������ $��1,0,1,1q�5#     #��z��5$     ._�5%     �� $��0q�5&     $��Center=�5'     $��Center=�5(     $��False��5)     5*      5+     P� 5,      �@J�IsMouseOver$
 True��69   . �5-     �� $ border��6%   8   � ��6O   �� 5.     $ border��6%    6P   Z�  � ��5/     �� 50     $
 False��6�    6&   ��  �� *FindAncestor+"	  $ 
IsEditMode�.a�51     ��  � y�$ 	Collapsed=�6;   52     �� 53     $
 False��6�    6&   ��  �� *FindAncestor+"	  $ 
IsEditable�.a�54     ��  � y�$ 	Collapsed=�6;   55     �� 56      6&   �� 
 6:   Z� .a�57     ��  � y�$ 	Collapsed=�6;   58     5:     5<     5=     �� 5?     " ��6J   .�5@  
   ��  � �� 5A     �� 5B     " ��6"   .R�5C     �� $ Bd��5D     $��1q�5E     8��  $��1q�5G     $ 5��5H     ._�5I     �� $ 
Horizontal=�6%   .+�5J     �� $��2,2,2,4q�5K  !   ��5L  !   �� ��5M  !   ��  �� *FindAncestor+"	  $" SelectedItemTemplateSelector��� 5O     $C =PART_MultiSelectComboBox_SelectedItemsPanel_RemoveItem_Button��5P  !   8�� $ Remove��5R  !   .��5S  "   F� $��3q�5T  %   $��Stretch=�5U  %   $��Stretch=�5V  %   |��������<R��C�Z��@��=R��m5�����O���C��m5��Ѥ���n5��C0P������n5�H<R�����Z���CѬ<R\�������<R8�� $ False��5Y  %   $ Uniform=�5Z  %   5[     5\     5]      5_     ^� 5`      5a     �� 5b  "    6,   ��  6@   Z� 0�5d     �� 5e  "   $ Bd��6)    6P   Z�  � ���� 5f  "   $ Bd��6)    � ��$ 1,0,1,0q�6K   5h     5j     5l     5m     �� 5o     .R�5p  
   F� $��Center=�5q     $��Center=�5r     "����        � 	=  	= � z     	8��  5t     5u     �� 5w     .R�5x  
   F� $��13��5y     $��Center=�5z     $��Center=�5{     �����p< lk ���A�xe ��A��[ p<0�U ��M�32 Ӏ� @, p� @,  ��32 р��   N ���pX� ���- �6���- @o@�0�f @o@�P��� ���� �L^ ���- �6	8��  $ Uniform=�5~     5     �� 5�     .R�5�  
   �� 
�������8��  $��1q�5�     ._�5�     �   5�     �� 5�     $��* �6'   �� 5�     $��20 �6'   .+�5�     �� $��0��5�     $��1q�5�     
�������$��0q�5�     ._�5�       $>! 8PART_MultiSelectComboBox_SelectedItemsPanel_ItemsControl��5�     8�� 8�� " 5�     ���� 5�     2.MultiSelectComboBox.SelectedItems.ItemTemplate$ .R�5�  "   �� $	��2,0q�5�  %   #���  5�  %   ��5�  %   �� 5�     �� 5�     =9MultiSelectComboBox.SelectedItems.Searchable.ItemTemplate$ .R�5�  "   �� $��TextBoxContainer��6-   $ 
Horizontal=�6E   .+�5�  &   �� $@# :PART_MultiSelectComboBox_SelectedItemsPanel_Filter_TextBox��5�  )   $��0q�5�  )   $��1q�5�  )   
������ 
������ $��0q�5�  )   $
|�True��5�  )   $
$ True��5�  )   $��False��5�  )   $% NoWrap=�5�  )   {�5�  )   �� *
IsEditMode+ �� 	 control:MultiSelectComboBox5�  )   �� 5�  &   $M# GPART_MultiSelectComboBox_SelectedItemsPanel_Filter_AutoComplete_TextBox��5�  )   $��-2,0,0,0q�5�  )   $��-3,1,0,1q�5�  )   
������ 
������ $��0q�5�  )   $|�False��5�  )   $
& True��5�  )   $��False��5�  )   $% NoWrap=�5�  )   5�  #   ' 5�  "   ^� 5�  &    5�  *   �� 5�  .    68   �� *
IsEditable+ �� 	 control:MultiSelectComboBox	 False6�   �� 5�  .    68   �� *EnableFiltering+ �� 	 control:MultiSelectComboBox	 False6�   .0�5�  *   �� $ TextBoxContainer��61    � y�$ 	Collapsed=�6e   5�  '   5�     5�     5�     5�     �� 5�     $. (PART_MultiSelectComboBox_Dropdown_Button��5�     $��1��5�     8�� .��5�     �� ��5�     �� 5�     " ��6$   .�5�  "   ��  � ��$ False��6>   �� 5�  "    � ��8  6D    5�  "   �� 5�  &    62   ��  �� *FindAncestor+"	  $ 
IsEditMode�
 True6�   .a�5�  *   ��  � ��8  6L   5�  '   ^� 5�  &    5�  *   �� 5�  .    68   �� *
IsEditable+ �� 	 control:MultiSelectComboBox	 False6�   �� 5�  .    68   �� *EnableFiltering+ �� 	 control:MultiSelectComboBox	 False6�   .0�5�  *   ��  � ��8  6L   5�  '   5�     5�     5�     5�     5�     5�     �� 5�     $( api:IItemGroup��6P   .R�5�  
   �� $��0,0,0,2q�5�     $	) 7,5q�5�     8��  8�� $
��Bold"�5�     8�� $��CharacterEllipsis=�5�     ��5�     �� $
 Name�5�     5�     �� 5�     "  6   .�5�  
   �� $ �@ SelectedItemsPanelBackground 69   �� *
Background+ �� *Self+�� 5�  
    �@ DropDownPopupBackground 64   �� *
Background+ �� *Self+�� 5�  
    � �� 5�     �� 5�     "  6"   .R�5�     � $* PART_MultiSelectComboBox��5�     #��z+ 5�     8��  .+�5�     d� $��False��5�     $
, None=�5�      5�     �� $ IsDropDownOpen�$- TwoWay=� �� *TemplatedParent+��5�     �� 5�  "   " d�62   .R�5�  &   �� 8�� 65   5�  #   5     � 5     $'. !PART_MultiSelectComboBox_Dropdown��5     $��2��5     #��z+ 5     $��2q�5	     $
/ True��5
     $��Bottom=�5     $��Slide=�5     ��5     �� *ActualWidth+$0 PART_MultiSelectComboBox����5     �� $ MaxDropDownHeight� �� *TemplatedParent+��5     �� $ IsDropDownOpen�$- TwoWay=� �� *TemplatedParent+1 5     �� $0 PART_MultiSelectComboBox��.��5     �� $ dropDownBorder��5  !   $��0,1,0,0q�5  !   #��� ��5  !   #��� ��5  !   $��0q�5  !   ._�5  "   � $
* grid��6'   $2 Enabled=�65   .+�5  &   �� $3 canvas��5  )   $��0��5  )   $��0��5  )   $
��Left=�5  )   $	��Top=�5  )   .+�5  *   �� $4 
opaqueRect��5  -   ��5  -   �� *ActualWidth+$0 dropDownBorder����5  -   �� *ActualHeight+$0 dropDownBorder����5   -   �� *
Background+$0 dropDownBorder��5!  '     5"  &   $/5 )PART_MultiSelectComboBox_Dropdown_ListBox��6R   8�� 6 5#  *     5$  .   87  69   " 5&  *   ���� 5'  .   51MultiSelectComboBox.Dropdown.ListBox.ItemTemplate$ .R�5(  2   �� $��2,2,2,3q�5)  5   8�� ��5+  5   �� 5,  /   5-  +   5.  '   5/  #   50     51     52      54     �� 55     $
 Stretch��6�    6&   �� *VerticalAlignment+ �� 	 control:MultiSelectComboBox.a�56     �� $ PART_MultiSelectComboBox��6%    6`   �� *ActualHeight+ �� 	 control:MultiSelectComboBox � ��57     5:     5<     5=     5?     