   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCZdravo.PatientPagesHCZdravo.PatientPages  0    *HCZdravo.PatientPages.ForgotenPasswordPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:HCZdravo.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$!  PatientForgotenPasswordPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �  .���  � RowDefinitions �� $
��153* ��� $	��68* ��� $	��39* ��� $	��39* ��� $	��39* ��� $	��39* ��� $	��39* ��� $
��309* � � ColumnDefinitions �� $	��23* ��� $
��197* ��� $
��220* �.+��� -    ��Name$
 back�� , (MaterialDesignFloatingActionAccentButton#��[  � ToolTip$. (MaterialDesignFloatingActionAccentButton��$��0��$��1��$��0q�$��0q�$��66��$��66��$
��Left=�$��Center=�.��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 	ArrowLeft=�
�������$��50��$��52��$��Center=�$��Center=��� $��0��$��2������ 
 �� 	UriSource$
 /Resources/logo.png?��� $��1��$��1��$
��Left=�$��Center=�$��16(�$��22��$	��156��Zaboravili ste lozinku?�� $��2��$��1��$
��Left=�$��Center=�$��16(�$��20��$	��106��Korisničko ime:�� -   $��username��$��2��$��2��$��Center=�$��Center=�$	��160��$��24���� $��3��$��1��$
��Left=�$��Center=�$��16(�$��20��$��44��JMBG:�� -   $
��jmbg��$��3��$��2��$��Center=�$��Center=�$	��160��$��24���� $��4��$��1��$
��Left=�$��Center=�$��16(�$��20��$��94��Nova lozinka:G� -   $
��pwd1��$��4��$��2��$��Center=�$��Center=�$	��160��$��24���� $��5��$��1��$
��Left=�$��Center=�$��16(�$��22��$	��122��Potvrdite lozinku:G� -   $
��pwd2��$��5��$��2��$��Center=�$��Center=�$	��160��$��24���� -    ��Name$ errormessage��$��6��$��2��$��24��$��Center=�$��Center=� J� OpacityMask
 �<��$	��300�����	#FFE5572C$��1���� -   $ errormessage1��$��6��$��2��$��24��$��Center=�$��Center=�
 �<��$	��300�����#00FFFF$��1���� -   $��3��$��7��$��Center=�$��Center=�$��Medium"�$��30(�$��50��$��0�� " MaterialDesignRaisedDarkButton#��[ .��Resetujte lozinku!