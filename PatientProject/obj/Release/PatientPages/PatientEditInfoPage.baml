   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PatientProject.PatientPagesPatientProject.PatientPages  5    /PatientProject.PatientPages.PatientEditInfoPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:PatientProject.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  PatientEditInfoPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �  .��� .+�)  #MaterialDesignThemes.Wpf.DrawerHost  $��Center=�$��Center=�$��0q�  MaterialDesignDivider#���  $	��750��$	��430��   LeftDrawerContent �� $	��250��
�������.+�� $	��750�� � RowDefinitions �� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��61* ��� $	��39* ��� $	��50* ��� $	��50* ��� $	��50* � � ColumnDefinitions �� $	��17* ��� $	��33* �.+��� -   $��HomePageButton��$��1��$��0��$��Center=�$��Center=�$��48��$��30��.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=��� -   $��HomePageText��$��1��$��1��$��16(�$
��Left=�$��Center=�$��18��Pocetna stranica�� -   $��2��$��0��$��Center=�$��Center=�$��48��$��30��.��  $
 User=��� -   $��AccountText1��$��1��$��2��$��16(�$
��Left=�$��Center=�$��18��Profil�� -   $��TherapyButton��$��3��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ Medicine=��� -   $��TherapyText��$��3��$��1��$��16(�$
��Left=�$��Center=�$��20��Prikaz terapija�� -   $��PatientChartButton��$��4��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ ChartHistogram=��� -   $��PatientChartText��$��4��$��1��$��16(�$
��Left=�$��Center=�$��20��Zdravstveni karton�� -	   $��
BlogButton��$��5��$��0��$��Center=�$��Center=�$��48��$��30��.��  $
 Blog=��� -
   $��BlogText��$��5��$��1��$��16(�$
��Left=�$��Center=�$��20��Blog�� -   $��DoctorsButton��$��6��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ Doctor=��� -   $��DoctorsText��$��6��$��1��$��16(�$
��Left=�$��Center=�$��18��Lekari�� $��8��$��0��$��Center=�$��Center=�$��16(�$��18��$��
16,7,15,14q�$��54��	Pregled�� -   $��NewExamButton��$��9��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ HospitalBox=��� -   $��NewExamText��$��9��$��1��$
��Left=�$��Center=�$��16(�$��18��Zakazite pregled�� -   $��ScheduledExamsButton��$��10��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ 
MedicalBag=��� -   $��ScheduledExamsText��$��10��$��1��$
��left=�$��Center=�$��16(�$��18��Zakazani pregledi�� -   $��EmergencyExamButton��$��11��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ HospitalBuilding=��� -   $��EmergencyExamText��$��11��$��1��$
��Left=�$��Center=�$��16(�$��18��Hitan pregled	   RightDrawerContent	 �� $	��250��
�������.+�� $	��360�� �� �� �� �� �� ��  �� $	��17* ��� $	��33* �.+��� -   $��RateDoctorButton2��$��1��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ Account=��� -   $��RateDoctorText2��$��1��$��1��$
��Left=�$��Center=�$��18(�$��22��Ocenite lekara�� -   $��FeedbackButton��$��2��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ Feedback=��� -   $��FeedbackText��$��2��$��1��$
��Left=�$��Center=�$��18(�$��22��Ostavite komentar�� -   $��LogoutButton��$��4��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ Logout=��� -   $��
LogoutText��$��4��$��1��$
��Left=�$��Center=�$��18(�$��22��$	��115��Odjavite se�� -   $��
ExitButton��$��5��$��0��$��Center=�$��Center=�$��48��$��30��.��  $ PresenceExit=��� -   $��ExitText��$��5��$��1��$
��Left=�$��Center=�$��18(�$��22��$	��115��	Izlazak
   TopDrawerContent
 �� $��Hidden=�.���� 
�������$
��Left=�$	��300��$	��Top=�$	��430�� �� CanVerticallyScroll . .+��� $y�Hidden=��� $y�Hidden=��� $��Center=�$��Center=�$��Medium"�$��20(�Notifikacije�� $y�Hidden=��� $y�Hidden=���  � IsSharedSizeScope . ����  �� Path$ notifications�����  �� DataType.   (PatientProject.PatientPages.Notification"  .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q�#���  ._��� $��8 0 0 0q�.+��� $
��Bold"�$
��Wrap=����� *Header+�� $
��Wrap=����� *	Content+.��� $	��430��$	��750��.+�� $��Center=�$��Center=�$	��750��$	��430�� �� $��23 ��� $��65 ��� $	��135 ��� $	��128 ��� $��66 ��� $��23 � �� $��63 ��� $��28 ��� .+��� ���#536878$
��Left=�$��91��$��0��$	��Top=�$	��430��$��6��$��2���� -   $
��menu��  MaterialDesignFlatButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10�� � ToolTip$
 Meni��$��1��$��0��$��60��$
��Left=�$��Bottom=�$��40��   OpenDrawerCommand#��Z "  System.Windows.Controls.Dock   Left#��Z .��  $
 Menu=�
�������$��50��$��40��$��Center=�$��Center=��� -   $
��bell��#��[ $ 10��$ Notifikacije��$��3��$��0��$��60��$��Right=�$��Bottom=�$��40��#��Z 
   Top#��Z .��  $
 Bell=�
�������$��50��$��35��$��Center=�$��Center=��� -   $
��gear��#��[ $ 10��$ Options��$��4��$��0��$��60��$��Right=�$��Bottom=�$��40��#��Z    Right#��Z .��  $ DotsVertical=�
�������$��50��$��40��$��Center=�$��Center=�� $��0��$��2��$��6�� �� $	��45* ��� $	��43* ��� $	��43* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* � �� $��23 ��� $	��142 ��� $��99 ��� $��65 ��� $	��111 �.+��� -    ��Name$
 Back�� , (MaterialDesignFloatingActionAccentButton#��[ $. (MaterialDesignFloatingActionAccentButton��$��0��$��1��$��45��$��0q�$��0q�$
��Left=�$��Center=�$��45��.��  $ 	ArrowLeft=�$��24��$��24���� $��0��$��2��$
��Left=�$��Center=�$��20(�$��Medium"�$��2��Izmenite podatke�� $��4��$��0��$��2��$��79��$��Right=�$	��Top=�$��0,4,22,0q�$��78������  �� 	UriSource$ /Resources/pacijent.jpg?��� $��1��$��1��$
��Left=�$��Center=�$��16(�Ime:�� -   $
��name��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Unesite ime��$��1��$��2��$
��Left=�$��Center=�$��14(�$	��180��$��3���� $��2��$��1��$
��Left=�$��Center=�$��16(�Ime roditelja:�� -    $��parent��$ Unesite ime roditelja��$��2��$��2��$
��Left=�$��Center=�$��14(�$	��250��$��3���� $��3��$��1��$
��Left=�$��Center=�$��16(�
Prezime:�� -!   $��lastname��$ Unesite prezime��$��3��$��2��$
��Left=�$��Center=�$��14(�$	��250��$��3���� $��4��$��1��$
��Left=�$��Center=�$��16(�JMBG:�� -"   $	��pin��$ Unesite jmbg��$��4��$��2��$
��Left=�$��Center=�$��16(�$	��250��$��3���� $��5��$��1��$
��Left=�$��Center=�$��16(�Mesto prebivalista:�� -#   $��
livingCity��$  Unesite mesto prebivalista��$��5��$��2��$
��Left=�$��Center=�$��14(�$	��250��$��3���� $��6��$��1��$
��Left=�$��Center=�$��16(�Mesto rodjenja:�� -$   $��	birthCity��$ Unesite mesto rodjenja��$��6��$��2��$
��Left=�$��Center=�$��14(�$	��250��$��3���� $��7��$��1��$
��Left=�$��Center=�$��16(�
Telefon:�� -%   $	��tel��$ Unesite telefon��$��7��$��2��$
��Left=�$��Center=�$��14(�$	��250��$��3���� $��8��$��1��$
��Left=�$��Center=�$��16(�Datum rodjenja:(  "System.Windows.Controls.DatePicker  -&   $	��dtp��$��8��$��2��$��3��$ Odaberite datum rodjenja�� ( $MaterialDesignFloatingHintDatePicker#��[ $��0,3,55,3q��� $��9��$��1��$
��Left=�$��Center=�$��16(�Pol:�� -'   $��gender��$ Odaberite pol��$��9��$��2��$��3��$��30��$	��220��$
��Left=����� $ genders��� $��10��$��1��$
��Left=�$��Center=�$��16(�	E-mail:�� -(   $��email��$ Unesite email��$��10��$��2��$��3��$
��Left=�$��Center=�$��14(�$	��250���� $��11��$��1��$
��Left=�$��Center=�$��16(�Izabrani lekar:�� -)   $��doctor��$ Odaberite lekara��$��11��$��2��$��3��$��30��$	��220��$
��Left=����� $ doctors��� -*   $��AcceptButton��#��[ $��13��$��2��$��2��$��4��$��68��$��68��$��0q�$��0q�$��Center=�$��Center=�.��  $
 Tick=�$��50��$��50��