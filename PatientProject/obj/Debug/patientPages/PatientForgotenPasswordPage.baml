   M S B A M L   `   `   `  ����I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCZdravo.PatientPagesHCZdravo.PatientPages  5      0    *HCZdravo.PatientPages.ForgotenPasswordPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:HCZdravo.PatientPages     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$!  PatientForgotenPasswordPage��5
         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��158* �6   �� 5      $	��74* �6   �� 5      $	��50* �6   �� 5      $	��49* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $
��269* �6    � ColumnDefinitions 5!   
   �� 5"      $	��23* �6   �� 5#      $
��197* �6   �� 5$      $
��220* �6   .+�5'   
   �� -   5         ��Name$
 back��5'   p    , (MaterialDesignFloatingActionAccentButton#��[ 6   $��0��6S   $��1��6`   $��0q�6~   $��0q�6�   $��66��6�   $��66��6�   $
��Left=�6�   $��Center=�6�   $
��0,46q�6  .��5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6&   $��50��67   $��52��6C   $��Center=�6N   $��Center=�6k   5)      �� 5,   
   $��0��6   $��2��6   ��5-      �� 5.      	 �� 	UriSource$	 /Resources/logo.png?�6   6@   50      �� 52   
   $��1��6   $��1��6!   $
��Left=�61   $��Center=�6L   $��16(�6g   $��22��6u   $	��156��6�   $
��0,26q�6�   Zaboravili ste lozinku?6�   �� 54   
   $��2��6   $��1��6!   $
��Left=�61   $��Center=�6L   $��16(�6g   $��20��6u   $	��106��6�   $��	0,12,0,18q�6�   Korisničko ime:6�   �� 55   
   $��2��6   $��2��6"   
 �� Orientation$
 Vertical=�62   .+�56      �� -   5        $��username��56   Z   $��Center=�6   $��Center=�63   $	��160��6N   $��24��6j   �� 57      -   5         ��Name$ errorWrongName��57      $��Center=�61   $��center=�6N    J� OpacityMask
 �<��$	��200��6�   $��20��6�   ���	#FFE5572C6�   58      �� 5:   
   $��3��6   $��1��6!   $
��Left=�61   $��Center=�6L   $��16(�6g   $��20��6u   $��44��6�   JMBG:6�   �� 5;   
   $��3��6   $��2��6"   $
 Vertical=�62   .+�5<      �� -   5        $
��jmbg��5<   w   $��3��6   $��2��6#   $��Center=�63   $��Center=�6P   $	��160��6k   $��24��6�   �� 5=      -   5        $ errorWrongPin��5=      $��Center=�60   $��center=�6M   
 �<��$	��200��6   $��20��6�   ���	#FFE5572C6�   5>      �� 5A   
   $��4��6   $��1��6!   $
��Left=�61   $��Center=�6L   $��16(�6g   $��20��6u   $��94��6�   $��0,9,0,21q�6�   Nova lozinka:6�   �� 5B   
   $��4��6   $��2��6"   $
 Vertical=�62   .+�5C      G� -   5        $
��pwd1��5C   {   $��4��6   $��2��6'   $��Center=�67   $��Center=�6T   $	��160��6o   $��24��6�   �� 5D      -   5        $ errorWrongPass1��5D      $��Center=�62   $��center=�6O   
 �<��$	��200��6�   $��20��6�   ���	#FFE5572C6�   5E      �� 5H   
   $��5��6   $��1��6!   $
��Left=�61   $��Center=�6L   $��16(�6g   $��22��6u   $	��122��6�   $��0,9,0,19q�6�   Potvrdite lozinku:6�   �� 5I   
   $��5��6   $��2��6"   $
 Vertical=�62   .+�5J      G� -   5        $
��pwd2��5J   {   $��4��6   $��2��6'   $��Center=�67   $��Center=�6T   $	��160��6o   $��24��6�   �� 5K      -	   5        $ errorWrongPass2��5K      $��Center=�62   $��center=�6O   
 �<��$	��200��6�   $��20��6�   ���	#FFE5572C6�   5L      �� 5O   
   -
   5        $ errormessage��5O   C   $��6��6   $��2��6"   $��24��66   $��Center=�6Z   $��Center=�6w   
 �<��$	��300��6�   ���	#FFE5572C$��1��6�   $��54,13q�6�   �� 5P   
   -   5        $ errormessage1��5P   C   $��6��6   $��2��6"   $��24��66   $��Center=�6[   $��Center=�6x   
 �<��$	��300��6�   ���#00FFFF$��1��6�   $��54,13q�6�   �� 5R   
   -   5        $��2��5R      $��7��6%   $��Center=�62   $��Center=�6O   $��Medium"�6j   $��30(�6~   $��50��6�   $��1��6�    " MaterialDesignRaisedDarkButton#��[ 6�   $��56,109,78,110q�6  $	��274��6  .��6*  Resetujte lozinku!6>  �� 5T   
   -   5        $��	exitClick��5T   �   $��2��6   $
��Left=�6!   $��
156,10,0,0q�6<   
������ $	��Top=�6i   $��49��6�   $��37��6�   $��0q�6�   .��5U        $ Close=�6&   
���   �6H   5V      5W      5X      