   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PatientProject.PatientPagesPatientProject.PatientPages  B    <PatientProject.PatientPages.PatientScheduleEmergencyExamPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:PatientProject.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$&   PatientScheduleEmergencyExamPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
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
�������$��50��$��40��$��Center=�$��Center=�� $��0��$��0��$��6��$��4�� �� $��23 ��� $��65 ��� $��47 ��� $	��216 ��� $��66 ��� $��23 � �� $��63 ��� $��28 ��� $��82 ��� $��62 ��� $��41 ��� $	��474 �.+��� -    ��Name$
 Back�� , (MaterialDesignFloatingActionAccentButton#��[ $. (MaterialDesignFloatingActionAccentButton��$��2��$��1��$��60��$��0q�$��0q�$
��Left=�$��Center=�$��60��$
��0,11q�.��  $ 	ArrowLeft=�$��24��$��24���� $��2��$��2��$��2��$��Center=�$��Center=�$��Medium"�$��26(�Hitan pregled!�� $��4��$��1��$��4��$��Center=�$
��Wrap=�$��22(�$��Medium"�$"Posaljite zahtev za hitan pregled!� $��1��$��4��$��5�� �� $
��181* ��� $	��45* ��� $
��248* � �� $
��132* ��� $	��131 ��� $
��131* �.+��� -   $��	emergency��$��1��$��0��$��Bottom=�#��[ $ Hitan pregled��$	��129��$	��129��.��  $ 	Ambulance=�$��40��$��40��$��Center=�$��Center=�