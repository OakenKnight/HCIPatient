   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PatientProjectPatientProject  &     HCZdravo.PatientRegistrationPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:PatientProject     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  PatientRegistrationPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �  .���  � ColumnDefinitions �� $	��23* ��� $
��197* ��� $
��220* � � RowDefinitions �� $
��145* ��� $	��89* ��� $	��89* ��� $	��63* ��� $	��62* ��� $	��62* ��� $	��43* ��� $
��197* �.+��� -    ��Name$
 back�� , (MaterialDesignFloatingActionAccentButton#��[  � ToolTip$. (MaterialDesignFloatingActionAccentButton��$��0��$��1��$��0q�$��0q�$��66��$��66��$
��Left=�$��Center=�.��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 	ArrowLeft=�$��50��$��52��$��Center=�$��Center=��� $��0��$��2������ 
 �� 	UriSource$
 /Resources/logo.png?��� $��2��$��1��$��Center=�$��Center=�$��28(�$��Medium"�$��36��$	��180��$��1��Registrujte se:�� $
��Left=� �� Orientation$ Vertical=�$��1��$��2��$	��161��.+��� $��20(�$
��Wrap=�$(��"Unesite korisničko ime i lozinku:��$��74���� $��1��$��3��$
��Left=�$��Center=�$��20(�$��26��$	��128��Korsničko ime:�� -   $��username��$��2��$��3��$��Center=�$��Center=�$	��190��$��24���� $��1��$��4��$
��Left=�$��Center=�$��20(�$��26��$��72��
Lozinka:G� -   $
��pwd1��$��2��$��4��$��Center=�$��Center=�$	��190��$��24���� $��1��$��5��$
��Left=�$��Center=�$��20(�$��28��$	��152��Potvrdite lozinku:G� -   $
��pwd2��$��2��$��5��$��Center=�$��Center=�$	��190��$��24���� -    ��Name$ errormessage��$��6��$��2��$��30��$��Center=�$��center=� J� OpacityMask
 �<��$	��340�����	#FFE5572C$��1���� -   $��3��$��7��$��Center=�$��Center=�$��Medium"�$��30(�$��50��$	��132��$��0�� " MaterialDesignRaisedDarkButton#��[ .��	Nastavi