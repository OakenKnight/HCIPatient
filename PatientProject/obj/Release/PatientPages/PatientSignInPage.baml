   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HCZdravoHCZdravo       HCZdravo.PatientSignInPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:HCZdravo     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �   N� Title$ PatientSignInPage��.��� .+��  � RowDefinitions �� $
��122* ��� $	��50* ��� $	��50* ��� $	��49* ��� $��25.767 ��� $	��34* ��� $	��81* ��� $	��32* ��� $	��64* ��� $	��69* ��� $	��35* ��� $
��138* � � ColumnDefinitions �� $	��23* ��� $
��124* ��� $
��147* ��� $
��147* �.+��� $��0��$��0��$��2��$��0,0,1,0q�����  �� 	UriSource$ /Resources/logo.png?��� $��0��$��2��$��2��$��Center=�$��Center=�$��22(�$	��180��$��28��KLINIKA ZDRAVO!�� $��1��$��1��$
��Left=�$��Center=�$��16(�$��22��$��80��$
��0,14q�Prijavite se!�� $��2��$��1��$
��Left=�$��Center=�$��16(�$��22��$	��106��$
��0,14q�Korisničko ime:�� -   $
��user��$��Center=�$��Center=�$	��200��$��24��$��2��$��2��$��2���� $
��Left=�$��Center=�$��16(�$��21��$��56��$��3��$��1��$
��0,14q�
Lozinka:G� -   $	��pwd��$��Center=�$��Center=�$	��200��$��24��$��2��$��2��$��3���� 
������$��2q�$��Zapamti me!�� d� 	IsChecked$ FalseY�$
��Left=�$��Center=�$��20��$��94��$��4��$��1���� -   $��	Underline{�$��Center=�$��Center=�
����  �$��20��$	��148��$��4��$��2��$��2��Zaboravili ste lozinku?�� -   	 ��Name$	 errormessage��$��5��$��3��$��24��$��Center=�$��center=�
 J� OpacityMask

 �<��$	��300�����	#FFE5572C$��1���� -   $	 errorWrongInput��$��5��$��3��$��24��$��Center=�$��center=�

 �<��$	��300�����	#FFE5572C$��1���� -   $��signIn��$��Prijavite se!��$��48��$��Center=�$��Center=�$��18(�$��Medium"�$��6��$��1��$��3��$	��250���� $��Center=�$��Center=�$��16��$��7��$��2��$��12��$��	67,8,68,8q�ili�� $��8��$��0��$��4q�$��10,16,11,16q�$��2��$
��Auto��.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Facebook=�$��24���� 
Facebook�� $��8��$��2��$��4q�$��
9,16,10,16q�$
��Auto��.���� $ 
Horizontal=�.+�  $ Twitter=�$��24���� �� $�Twitter���� $��8��$��3��$��4q�$��10,16,8.667,16q�$
��Auto��.���� $ 
Horizontal=�.+�  $ Google=�$��24���� �� $�Google���� $��9��$��2�� �� CornerRadius$ 62�� �� Padding$ 0,20,0,0q�
������
���   �$��1q�$��	43,3,44,4q�._��� $��Center=�$	��ili��$��16(��� $��9��$��0�� �� Stretch$
 Fill=�
���   �	 �� X2$ 3��$��3��$��
10,0,102,0q��� $��9��$��2��$
 Fill=�
���   �$ 3��$��103,0,10.667,0q�$��2���� $��4��$��11��$��Center=�$
��Fill=�$��0,0,-0.333,0q�$��1������ $( "/Resources/registration-banner.jpg?��� -   $��11��$��Center=�$��Center=�$��Registrujte se!��$��46��$��22(�$��Medium"�$��3��$	��250��$��1��