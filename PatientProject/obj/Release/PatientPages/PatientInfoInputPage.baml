   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HCZdravo.PatientPagesHCZdravo.PatientPages  0    *HCZdravo.PatientPages.PatientInfoInputPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:HCZdravo.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  PatientInfoInputPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �  .���  � ColumnDefinitions �� $	��23* ��� $
��129* ��� $	��34* ��� $
��107* ��� $
��147* � � RowDefinitions �� $	��82* ��� $	��48* ��� $��0* ��� $	��49* ��� $	��49* ��� $	��49* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��49* ��� $	��53* ��� $	��50* ��� $	��50* ��� $	��49* ��� $	��72* �.+��� $��1��$��3��$
��Left=�$��Center=�$��28(�$��Medium"�$	��0,6q�$��36��$	��214��$��1��Unesite podatke:�� -    ��Name$
 back�� , (MaterialDesignFloatingActionAccentButton#��[  � ToolTip$. (MaterialDesignFloatingActionAccentButton��$��0��$��1��$��0q�$��0q�$��66��$��66��$
��Left=�$��Center=�$	��0,8q�.��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 	ArrowLeft=�$��50��$��52��$��Center=�$��Center=��� $��0��$��4��$��2��$��0,0,0,5q����� 
 �� 	UriSource$!
 /Resources/social-media.png?��� $��3��$��1��$
��Left=�$��Center=�$��18(�$��24��$	��124��$��	0,12,0,13q�Ime:�� -   $
��name��$��3��$��2��$��3��$
��Left=�$	��230��$��30����  �� Orientation$ Vertical=�$��3��$��1��$��3��$��0,47,0,1q�$��2��.+��� $
��Left=�$
��Wrap=�$��Center=�$��17(�$��50��$	��119��Ime jednog roditelja:�� -   $��
parentName��$��4��$��2��$��3��$
��Left=�$	��230��$��30���� $��5��$��1��$
��Left=�$��Center=�$��18(�$��22��$��70��$��	0,13,0,14q�
Prezime:�� -   $��lastname��$��5��$��2��$��3��$
��Left=�$	��230��$��30���� $��6��$��1��$
��Left=�$��Center=�$��18(�$��22��$��56��$��	0,15,0,13q�JMBG:�� -   $	��pin��$��6��$��2��$��3��$
��Left=�$	��230��$��30���� $��7��$��1��$
��Left=�$��Center=�$��18(�$��22��$	��150��$��2��$
��0,14q�Mesto prebivališta:�� -   $��
livingCity��$��7��$��2��$��3��$
��Left=�$	��230��$��30���� $��8��$��1��$
��Left=�$��Center=�$��18(�$��24��$	��118��$
��0,13q�Mesto rođenja:�� -   $��	birthCity��$��8��$��2��$��3��$
��Left=�$	��230��$��30���� $��9��$��1��$
��Left=�$��Center=�$��18(�$��24��$��62��$��	0,13,0,12q�
Telefon:�� -   $	��tel��$��9��$��2��$��3��$��Center=�$
��Left=�$	��230��$��30���� $��10��$��1��$
��Left=�$��Center=�$��18(�$��24��$	��124��$��	0,14,0,15q�Datum rođenja:(  "System.Windows.Controls.DatePicker  -	   $	��dtp��$��10��$��3��$��2��$	��220��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Odaberite datum rodjenja�� ( $MaterialDesignFloatingHintDatePicker#��[ $
��Left=��� $��11��$��1��$
��Left=�$��Center=�$��18(�$��24��$��26��$
��0,13q�Pol:�� -
   $��gender��$��11��$��3��$��2��$
��Left=�$	��230��$��30������  �� Path$ genders��� $��12��$��1��$
��Left=�$��Center=�$��18(�$��24��$��50��$
��0,13q�	e-mail:�� -   $��email��$��12��$��3��$��2��$��Center=�$
��Left=�$	��230��$��30���� $��13��$��1��$
��Left=�$��Center=�$��18(�$��24��$	��110��$��	0,13,0,12q�Izabrani lekar:�� -   $��doctor��$��13��$��3��$��2��$
��Left=�$	��230��$��30������ $ doctors��� -    ��Name$ errorWrongInput��$��14��$��1��$��3��$��Center=�$��center=� J� OpacityMask
 �<��$	��220��$��20�����	#FFE5572C$��25,26q��� -   $��4��$��14��$��Potvrdi��$
��Left=�$��Center=�$��24(�$��Medium"�$��44��$	��120�� " MaterialDesignRaisedDarkButton#��[ $
��0,14q�