   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   bool2VisibilityConverter  �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&     System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType'   !System.Windows.VisualStateManager   VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState   
Storyboard	 �� 
TargetName
 �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime  ControlMouseOverColor �� Value  ControlPressedColor R� KeyTime  System.Windows.Visibility   	Collapsed R� Value ��Name J� SnapsToDevicePixels �� EndPoint �� 
StartPoint  BorderLightColor � Color � Offset  BorderMediumColor  ControlLightColor  ControlMediumColor �Name J� Opacity � Points �� Stretch  
GlyphColor �� Color  BorderDarkColor ��Name �� Padding ��Name � ColumnDefinitions � RowDefinitions     SelectAllCommand7   1System.Windows.Controls.DataGridHeadersVisibility
!   All" �� ConverterParameter!#    HeadersVisibilityConverter$ �� 	Converter% �� RelativeSource& �� AncestorTypeG   ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter'  Name(   Column) ��Name* �� CanContentScroll+ ��Name, �� Orientation- �� ViewportHeight. �� ViewportSize/ �� ScrollableHeight0 � Maximum*1 �� #ComputedVerticalScrollBarVisibility2 � Value3 �� Mode4 �� ViewportWidth5 �� ScrollableWidth,6 �� %ComputedHorizontalScrollBarVisibility7 �� Triggers8 P� Property9 P� Value*   $System.Windows.Controls.DataGridCell "	 DatagridCurrentCellBorderColor)	   #System.Windows.Controls.DataGridRow 
 ContentAreaColorLight  ContentAreaColorDark  ControlDarkColor?
   9System.Windows.Controls.Primitives.SelectiveScrollingGrid?   9System.Windows.Controls.Primitives.DataGridCellsPresenter: 	  
ItemsPanelA   ;System.Windows.Controls.Primitives.DataGridDetailsPresenter; 	  DetailsVisibility$< 
  SelectiveScrollingOrientation;   5System.Windows.Controls.SelectiveScrollingOrientation=   Vertical#>    RowDetailsScrollingConverter:   4System.Windows.Controls.Primitives.DataGridRowHeader
?   Row  RowHeaderGripperStyle@ �� OrientationA n�Name  ColumnHeaderGripperStyle=   7System.Windows.Controls.Primitives.DataGridColumnHeaderB  NameC J� IsHitTestVisible�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�:  &	        (��      5   
   $" DataGridSelectAllButtonStyle��"   )7  7  '       '  m    7 	 '	      7 
 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �*    '  �+    7  7   7  7  &	 �3    '  �4    7  7  '  �8    �� 5      6!   �� 5      "  ��6
   .�5
      ��  � �� 5      �� 5   
   " ��6   .R�5      �  5        5      CommonStates��. 5        
Normal��6     5      	MouseOver��. 5      �� .��5      �� $	 Border��63   $a
 [(Shape.Fill).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5   3   .g�5        $ 0��6,   8   5   ,   5      5      5        5      Pressed��. 5      �� .��5      �� $	 Border��63   $a
 [(Shape.Fill).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5   3   .g�5         $ 0��6,   8  5!   ,   5"      5#      5$        5%      Disabled��. 5&      �� .��5'      T� $
 (UIElement.Visibility)�64   $	 Arrow��5(   4   ..�5)      i� $ 0��6/   # Z 5*   /   5+      5,      5-      5.      .+�50      �� $ Border��6    . ��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�54   &   .��55      � # �  6!   $ 0Q�56   !   � 57      # �  6!   $ 1Q�58   !   59      ��5;      �� 5<      $ 0.5,1&�6&   $ 0.5,0&�5=   &   .��5>      � # �  6!   $ 0Q�5?   !   � 5@      # �  6!   $ 1Q�5A   !   5B      5D      � 5E      $ Arrow��6   $��Right=�5F      $��8,8,3,3q�5G      $
 0.15Q�5H       �   ��� ��� ��� ��� $ Uniform=�5J      $��Bottom=�5K      ��5L      �� 5M      # �  6"   5O      5P      5Q      5S      5T      �� 5W      "    6
   .�5X      ��  � ��# � ��5Y      �� 5Z       � �� 5[      �� 5\   
   $ 0.5,1&�6   $ 0.5,0&�5]      .��5^      � # �  6   $ 0Q�5_      � 5`      # �  6   $ 1Q�5a      5b      5d      �� 5e       � ��$ 1q�5f      �� 5g        �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�5h      �� 5i       � �� . 5j      �� 5k       �@��PanningMode$
 Both=�5l      �� 5m       �@��IsFlicksEnabled .  5n      �� 5o       � �� 5p      �� 5q   
   "   6   .R�5r      �� $ border��6    . #��z��5t      #��z��5u      # z��5v      ��5w      �� 5x      # �  6     5z        5{      CommonStates��. 5|        Disabled��. 5}      �� .��5~      �� $	 border��63   $I
 C(Panel.Background).                         (SolidColorBrush.Color)�5   3   .g�5�        $ 0��6,   # �  5�   ,   5�      5�      5�        5�      
Normal��6   5�      ._�5�      �� $ DG_ScrollViewer��6   |�.  
���   ���5�      �� 5�      " ��6"   .R�5�      �  5�      �� 5�      $
��Auto �6)   �� 5�      $��* �6)   �� 5�      $
��Auto �6)    5�      �� 5�      $
��Auto �6&   �� 5�      $��* �6&   �� 5�      $
��Auto �6&   .+�5�      �� |�.  #��Z  5�      ��5�      C� *�� $" DataGridSelectAllButtonStyle��"   +y�5�      �� *HeadersVisibility+#" Z! #$ Z# % �� "&   ��5�      �� *CellsPanelHorizontalOffset+% �� "&     5�      $!' PART_ColumnHeadersPresenter��65   $��1��5�   5   y�5�   5   �� *HeadersVisibility+#" Z( #$ Z# % �� "&   �� 5�      $!) PART_ScrollContentPresenter��6-   $��2��5�   -   $��1��5�   -   #* z��5�   -   �� 5�      $+ PART_VerticalScrollBar��6    $��2��5�       $��1��5�       $, Vertical=�5�       #. z- 5�       #0 z/ 5�       #y�z1 5�       2 5�       �� *VerticalOffset+$3 OneWay=�% �� *TemplatedParent+� 5�      $��1��6   $��2��5�       5�      �� 5�      ��6+   �� **(NonFrozenColumnsViewportHorizontalOffset+% �� "&   �� 5�      $��* �6+   .+�5�      �� $+ PART_HorizontalScrollBar��6"   $��1��5�   "   $, 
Horizontal=�5�   "   #. z4 5�   "   #0 z5 5�   "   #y�z6 5�   "   2 5�   "   �� *HorizontalOffset+$3 OneWay=�% �� *TemplatedParent+5�      5�      5�      .��5�      �� # z 6   5�      5�      5�      5�      7 5�      P� 5�      8 �@��
IsGrouping9 . . �5�   
   ��  � �� .  5�      5�   	   5�      �� 5�      "   6
   .�5�      ��  � �� 5�      �� 5�   
   "  6   .R�5�      �� $ border��6   
������ $��1q�5�      
������  .  5�        5�      FocusStates��. 5�        	Unfocused��6     5�      Focused��6   5�        5�      CurrentStates��. 5�        Regular��6     5�      Current��. 5�      �� .��5�      �� $	 border��63   $K
 E(Border.BorderBrush).                         (SolidColorBrush.Color)�5�   3   .g�5�        $ 0��6,   8   5�   ,   5�      5�      5�      5�      ._�5�      �� # z 6   5�      5�      5     5     �� 5     "  	 6
   .�5     ��  � �� 5     �� 5  
   # �  6   5
     �� 5      �@J�SnapsToDevicePixels . 5     �� 5      �@=�ErrorTemplate 5     Z� �� 5      �@	 ValidationErrorTemplate 5     �� 5  
   .R�5     �� 
���  ��$��2,0,0,0q�5     $��!��5     $��Center=�5     5     5     �� 5      � �� 5     �� 5  
   " 	 6   .R�5     �� $ 
DGR_Border��6   #��z��5     #��z��5      . ��5      �� 5!     $ 0.5,1&�6$   $ 0.5,0&�5"  $   .��5#     � $ Transparent��6   $ 0Q�5$     � 5%     # �  6   $ 1Q�5&     5'      5)       5*     CommonStates��. 5+       
Normal��6     5.     Normal_AlternatingRow��. 5/     �� .��50     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�51  3   .g�53       $ 0��6,   8   54  ,   55     �� 56     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�57  3   .g�5:       $ 0��6,   8  5;  ,   5<     5=     5>       5E     Normal_Selected��. 5F     �� .��5G     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5H  3   .g�5J       $ 0��6,   8  5K  ,   5L     �� 5M     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5N  3   .g�5P       $ 0��6,   8  5Q  ,   5R     5S     5T       5V     Unfocused_Selected��. 5W     �� .��5X     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5Y  3   .g�5[       $ 0��6,   8  5\  ,   5]     �� 5^     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5_  3   .g�5a       $ 0��6,   8  5b  ,   5c     5d     5e       5g     Normal_Editing��. 5h     �� .��5i     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5j  3   .g�5l       $ 0��6,   8  5m  ,   5n     �� 5o     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5p  3   .g�5r       $ 0��6,   8  5s  ,   5t     5u     5v       5x     MouseOver_Editing��. 5y     �� .��5z     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5{  3   .g�5}       $ 0��6,   8  5~  ,   5     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8 	 5�  ,   5�     5�     5�       5�     MouseOver_Unfocused_Editing��. 5�     �� .��5�     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8 
 5�  ,   5�     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     5�     5�       5�     Unfocused_Editing��. 5�     �� .��5�     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     5�     5�       5�     	MouseOver��. 5�     �� .��5�     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     5�     5�       5�     MouseOver_Selected��. 5�     �� .��5�     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     5�     5�       5�      MouseOver_Unfocused_Selected��. 5�     �� .��5�     �� $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[0].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     �� 5�     $	 
DGR_Border��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�  3   .g�5�       $ 0��6,   8  5�  ,   5�     5�     5�     5�     ._�5�     
   5�     �� 5�     $
��Auto �6#   �� 5�     $��* �6#    5�     �� 5�     $��* �6    �� 5�     $
��Auto �6    .+�5�       $��1��6'   #��z: 5�  '   # z 5�  '     5�     $��1��6)   $��1��5�  )   #y�z; 5�  )   < 5�  )   �� *AreRowDetailsFrozen+#" Z= #$ Z> % �� "&     5�     $��2��6"   $< Vertical=�5�  "   y�5�  "   �� *HeadersVisibility+#" Z? #$ Z# % �� "&   5�     5�     5      5     5     �� 5     "  n�5  
   .�5     ��  � ��$ 8��5	     �� 5
      � ��
 ���� 5     �� 5      �@�Cursor$ SizeNS��5     �� 5      � �� 5     �� 5  
   " n�6   .R�5     �� #��z��6   # z��5     5     5     5     �� 5     "   6
   .�5     ��  � �� 5     �� 5  
   "  6   .R�5     �  5       5#     CommonStates��. 5$       
Normal��6     5%     Normal_CurrentRow��6     5&     Unfocused_EditingRow��6     5'     Normal_EditingRow��6     5(     	MouseOver��. 5)     �� .��5*     �� $	 rowHeaderBorder��63   $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�5+  3   .g�5-       $ 0��6,   8   5.  ,   5/     50     51       52     MouseOver_CurrentRow��6     53     "MouseOver_Unfocused_EditingRow��6     54     MouseOver_EditingRow��6     55      MouseOver_Unfocused_Selected��6     56     MouseOver_Selected��6     57     +'MouseOver_Unfocused_CurrentRow_Selected��6     58     !MouseOver_CurrentRow_Selected��6     59     Unfocused_Selected��6     5:     !Unfocused_CurrentRow_Selected��6     5;     Normal_CurrentRow_Selected��6     5<     Normal_Selected��6   5=     .+�5?     �� $ rowHeaderBorder��6   $��10��5@     $��1q�5A     ��5B     �� 5C     $ 0.5,1&�6&   $ 0.5,0&�5D  &   .��5E     � # �  6!   $ 0Q�5F  !   � 5G     # �  6!   $ 1Q�5H  !   5I     ��5K     �� 5L     $ 0.5,1&�6&   $ 0.5,0&�5M  &   .��5N     � # �  6!   $ 0Q�5O  !   � 5P     # �  6!   $ 1Q�5Q  !   5R     ._�5T     �� $@ 
Horizontal=�6   .+�5U     �� $��Center=�6#   # z 5V  #   �� 5W      .  ��5X     �� *ValidationErrorTemplate+% �� "& 	 y�5Z     �� *(Validation.HasError)+8$  % �� "& 	 5]     5^     n� 5`     $A PART_TopHeaderGripper��6   8�� $	��Top=�5b     n� 5c     $A PART_BottomHeaderGripper��6   8�� $��Bottom=�5e     5f     5g     5i     5j     �� 5m     "  n�5n  
   .�5o     ��  � ��$ 8��5p     �� 5q      � ��
 ���� 5r     �� 5s      �@�Cursor$ SizeWE��5t     �� 5u      � �� 5v     �� 5w  
   " n�6   .R�5x     �� #��z��6   # z��5y     5z     5|     5}     �� 5�     "   6
   .�5�     ��  � ��$ Center=�5�     �� 5�      � �� 5�     �� 5�  
   "  6   .R�5�     � .+�5�     �� $ columnHeaderBorder��6   $��1q�5�     $ 3,0,3,0q�5�     ��5�     �� 5�     $ 0.5,1&�6&   $ 0.5,0&�5�  &   .��5�     � # �  6!   $ 0Q�5�  !   � 5�     # �  6!   $ 1Q�5�  !   5�     ��5�     �� 5�     $ 0.5,1&�6&   $ 0.5,0&�5�  &   .��5�     � # �  6!   $ 0Q�5�  !   � 5�     # �  6!   $ 1Q�5�  !   5�     ._�5�     �� #��z��6!   # z 5�  !   #��z��5�  !   5�     n� 5�     $A PART_LeftHeaderGripper��6   $
��Left=�5�     8��  5�     n� 5�     $A PART_RightHeaderGripper��6   $��Right=�5�     8�� 5�     5�     5�     5�     �� 5�      � �� 5�     �� 5�  
   $ 0.5,1&�6   $ 0.5,0&�5�     .��5�     � # �  6   $ 0Q�5�     � 5�     # �  6   $ 1Q�5�     5�     5�     5�     �� 5�     "   6
   .�5�     ��  � �� 5�     �� 5�  
   "  6   .R�5�     � .+�5�       $B PART_FillerColumnHeader��6#   C .  5�  #   �� 5�     5�     5�     5�     5�     5�     