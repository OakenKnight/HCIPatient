   M S B A M L   `   `   `  ����I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PatientProjectPatientProject  5      &     HCZdravo.PatientRegistrationPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:PatientProject     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  PatientRegistrationPage��5	         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��23* �6   �� 5      $
��197* �6   �� 5      $
��220* �6    � RowDefinitions 5   
   �� 5      $
��145* �6   �� 5      $	��89* �6   �� 5      $	��89* �6   �� 5      $	��63* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5       $	��43* �6   �� 5!      $
��197* �6   .+�5$   
   �� -   5         ��Name$
 back��5$   p    , (MaterialDesignFloatingActionAccentButton#��[ 6   $��0��6S   $��1��6`   $��0q�6~   $��0q�6�   $��66��6�   $��66��6�   $
��Left=�6�   $��Center=�6�   .��5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   $��50��67   $��52��6C   $��Center=�6N   $��Center=�6k   5&      �� 5'   
   $��0��6   $��2��6   ��5(      �� 5)      	 �� 	UriSource$	 /Resources/logo.png?�6   6@   5+      �� 5.   
   $��2��6   $��1��6(   $��Center=�65   $��Center=�6R   $��28(�6m   $��Medium"�6{   $��36��6�   $	��180��6�   $��1��6�   Registrujte se:6�   �� 50   
   $
��Left=�6   
 �� Orientation$
 Vertical=�60   $��1��6G   $��2��6W   $	��161��6d   .+�51      �� $��20(�6   $
��Wrap=�6&   $(��"Unesite korisničko ime i lozinku:��6;   $��74��6d   52      �� 54   
   $��1��6   $��3��6$   $
��Left=�61   $��Center=�6L   $��20(�6g   $��26��6u   $	��169��6�   $��	0,19,0,18q�6�   Korsničko ime: *6�   �� 55   
   $��Center=�6   $
 Vertical=�62   $��2��6I   $��3��6Y   $	��190��6f   $��Center=�6r   .+�56      �� -   5        $��username��56   f   $��Center=�6   $��Center=�63   $	��190��6N   $��24��6Z   6�   �� 57      -   5         ��Name$ errorWrongUsername��57   %   $��20��6   $��Center=�6B   $��center=�6_    J� OpacityMask
 �<��$	��190��6�   ���	#FFE5572C6�   58      �� 5:   
   $��1��6   $��4��6$   $
��Left=�61   $��Center=�6L   $��20(�6g   $��26��6u   $	��169��6�   $
��0,18q�6�   
Lozinka: *6�   �� 5;   
   $��Center=�6   $
 Vertical=�62   $��2��6I   $��4��6Y   $	��190��6f   $��Center=�6r   .+�5<      G� -   5        $
��pwd1��5<   j   $��Center=�6   $��Center=�67   $	��190��6R   $��24��6^   6�   �� 5=      -   5        $ errorWrongPwd1��5=   %   $��20��6   $��Center=�6>   $��center=�6[   
 �<��$	��190��6�   ���	#FFE5572C6�   5>      �� 5A   
   $��1��6   $��5��6$   $
��Left=�61   $��Center=�6L   $��20(�6g   $��28��6u   $	��169��6�   $
��0,17q�6�   Potvrdite lozinku: *6�   �� 5B   
   $��Center=�6   $
 Vertical=�62   $��2��6I   $��5��6Y   $	��190��6f   $��Center=�6r   .+�5C      G� -   5        $
��pwd2��5C   �   $��2��6   $��5��6*   $��Center=�67   $��Center=�6T   $	��190��6o   $��24��6{   6�   �� 5D      -   5        $ errorWrongPwd2��5D   %   $��20��6   $��Center=�6>   $��center=�6[   
 �<��$	��190��6�   ���	#FFE5572C6�   5E      �� 5G   
   $��6��6   $��2��6"   $��Center=�66   $��center=�6S   
 �<��$��1��6�   $5��/Sva polja sa zvezdicom moraju biti popunjena...��6�   �� 5J   
   $��Center=�6   $
 Vertical=�62   $��0��6I   $��7��6Y   $	��350��6f   $	��Top=�6r   $��3��6�   .+�5K      �� -   5        $ errormessage��5K   G   $��6��6   $��2��6&   $��30��6:   $��Center=�6^   $��center=�6{   
 �<��$	��340��6�   ���	#FFE5572C$��1��6�   5L      �� 5N   
   -	   5        $��3��5N      $��7��6%   $��Center=�62   $��Center=�6O   $��Medium"�6j   $��30(�6~   $��50��6�   $	��132��6�   $��0��6�    " MaterialDesignRaisedDarkButton#��[ 6�   .��6  	Nastavi6  �� 5O   
   -
   5        $��	exitClick��5O   �   $��2��6   $
��Left=�6!   $��
156,10,0,0q�6<   
������ $	��Top=�6i   $��49��6�   $��37��6�   $��0q�6�   .��5P        $ Close=�6&   
���   �6H   5Q      5R      5S      