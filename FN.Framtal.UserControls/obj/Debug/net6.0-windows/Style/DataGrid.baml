   M S B A M L   `   `   `  ����R  NFN.Framtal.UserControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:FN.Framtal.UserControls.Converter!FN.Framtal.UserControls.Converter  5      Q-clr-namespace:FN.Framtal.UserControls.ControlFN.Framtal.UserControls.Control  5      A%clr-namespace:FN.Framtal.UserControlsFN.Framtal.UserControls  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� SourceE   ?FN.Framtal.UserControls.Converter.StringNullOrEmptyToVisibility !  StringNullOrEmptyToVisibility �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType ��Name	 J� SnapsToDevicePixels
 �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName  HeaderedDataGridStyle6   0FN.Framtal.UserControls.Control.HeaderedDataGrid �� Padding � ColumnDefinitions � RowDefinitions  SimpleBorderStyle  SubHeaderTextBlock   ChapterNumber �� TextAlignment   TitleContent �� 	Converter   RowsTitleContent ��Name   SelectAllCommand �� RelativeSource �� AncestorType7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter! �� 	ConverterG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter"  Name#   Column$ ��Name% �� CanContentScroll& ��Name' �� ScrollableHeight( � Maximum) �� Orientation* �� ViewportHeight+ �� ViewportSize*, �� #ComputedVerticalScrollBarVisibility- � Value. �� Mode/ �� ScrollableWidth0 �� ViewportWidth,1 �� %ComputedHorizontalScrollBarVisibility2 �� Triggers3 ]� 
Conditions4 �� Property5 �� Value6 �� BasedOn�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      =	Converter/clr-namespace:FN.Framtal.UserControls.Converter  5      9control-clr-namespace:FN.Framtal.UserControls.Control  5      /local%clr-namespace:FN.Framtal.UserControls  5        5      �� 5   
   $ Border.xaml?�6   �� 5	   
   $ Textblock.xaml?�6   %|  &	        (��      5      $" DataGridSelectAllButtonStyle��"  )&	 �    7  7  7  7   '  �    7     5      6.   �� 5      " ��6{   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ Border��5      #��� ��5      $
	 True��5      � 5      $
 Arrow��5      $��8,8,3,3q�5      $��Right=�5      $��Bottom=�5      
���   �$
 0.15Q�5       �   ��� ��� ��� ��� $ Uniform=�5      5       5      P� 5        �@J�IsMouseOver$
 True��69   . �5!      �� $ Border��6%   # � ��6K    � ��5"      P� 5#       � ��$
 True��67   . �5$      �� $ Border��6%   # � ��6I    � ��5%      P� 5&       � {�$ False��67   . �5'      �� $ Arrow��6%    � y�$ 	Collapsed=�6N   5(      5*      5,      5-      �� 5.      "  6*   .�5/   
   ��  � ��# � ��6'   �� 50   
    � ��# � ��6'   �� 51   
    � �� �	#FF688CAF6(   �� 52   
    � ��$ 0q�6,   �� 53   
     �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 54   
    � ��$
 true��6:   �� 55   
    �@��PanningMode$
 Both=�65   �� 56   
    �@��IsFlicksEnabled$ False��63   �� 57   
    � �� 58      �� 59      "  6"   .R�5:      �� # z��5;      #��z��5<      #��z��5=      #��z��5>      $
	 True��5?      ._�5@      �  5A      �� 5B   "   $��41 �63   �� 5C   "   $��1* �63    5E      �� 5F   "   $
��Auto �60   �� 5G   "   $��1* �60   .+�5I      �� $��41��5J   !   
������ 8��  ._�5M   "   �� 8�� #��z 6X   $��0q�5N   ,   $ Center=�5O   ,   $��Stretch=�5P   ,   $��Center=�5Q   ,   5R      �� 5S      $��1��5T   !   
������ $��0,1,1,1q�5V   !   8�� ._�5X   "   �� #��z 5Y   %   $��12(�5Z   %   $
��Bold"�5[   %   5\      �� 5]      $��1��6%   
�������62   � 5^      $��1��6#   $��1��60    5_   "   �� 5`   &   $
��Auto �67   $	��150��6D   �� 5a   &   $��1* �67   .+�5c   "   �� $��1��5d   %   $��0��5e   %   $	��150��5f   %   
������ $��1,0,0,1q�5h   %   #���  5i   %   y�5j   %   �� *RowsTitleContent+8  ._�5l   &   �� #��z 67   $��12(�6d   5n   #   �� 5o   "   $��1��5p   %   $��1��5q   %   $ 0q�5r   %   
�������$��1,0,1,1q�5t   %   #���  5u   %   ._�5v   &   �� $ DG_ScrollViewer��63   $|�false��6L   ��5w   *   �� 5x   .   " ��6>   .R�5y   2   �  5z   6   �� 5{   :   $
��Auto �6K   �� 5|   :   $��* �6K   �� 5}   :   $
��Auto �6K    5   6   �� 5�   :   $
��Auto �6H   �� 5�   :   $��* �6H   �� 5�   :   $
��Auto �6H   .+�5�   6   �� #��Z 5�   9   $|�false��5�   9   ��5�   9   �� *CellsPanelHorizontalOffset+ �� "  ��5�   9   C� *�� $" DataGridSelectAllButtonStyle��"  +y�5�   9   �� *HeadersVisibility+# Z #! Z   �� "    5�   6   $!" PART_ColumnHeadersPresenter��5�   9   $��1��5�   9   y�5�   9   �� *HeadersVisibility+# Z# #! Z   �� "  �� 5�   6   $!$ PART_ScrollContentPresenter��5�   9   $��1��5�   9   $��2��5�   9   #% z��5�   9   �� 5�   6   $& PART_VerticalScrollBar��5�   9   $��1��5�   9   $��2��5�   9   #( z' 5�   9   $) Vertical=�5�   9   #+ z* 5�   9   #y�z, 5�   9   - 5�   9   �� *VerticalOffset+$. OneWay=� �� *TemplatedParent+� 5�   6   $��2��6;   $��1��6H    5�   :   �� 5�   >   ��6O   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5�   >   $��* �6O   .+�5�   :   �� $& PART_HorizontalScrollBar��5�   =   $��1��5�   =   #( z/ 5�   =   $) 
Horizontal=�5�   =   #+ z0 5�   =   #y�z1 5�   =   - 5�   =   �� *HorizontalOffset+$. OneWay=� �� *TemplatedParent+5�   7   5�   3   5�   /   .��5�   *   �� #	 z	 69   5�   '   5�   #   5�      5�      5�      5�      5�      2 5�   
   ]� 5�      3 5�      �� 5�      4 �@��
IsGrouping$
5 true��66   �� 5�      "4 �@%�IsVirtualizingWhenGrouping$5 false��6X   ./�5�      ��  � ��$ false��6B   5�      5�      �� 5�      86   "  6=   5�      