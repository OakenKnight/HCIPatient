   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PatientProject.PatientPagesPatientProject.PatientPages  2    ,PatientProject.PatientPages.PatientChartPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:PatientProject.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  PatientChartPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
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
��Wrap=����� *	Content+.��� $	��430��$	��750��.+�� $��Center=�$��Center=�$	��750��$	��430�� �� $��23 ��� $��66 ��� $	��175 ��� $��87 ��� $��66 ��� $��23 � �� $��63 ��� $��28 ��� .+��� ���#536878$
��Left=�$��91��$��0��$	��Top=�$	��430��$��6��$��2���� -   $
��menu��  MaterialDesignFlatButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10�� � ToolTip$
 Meni��$��1��$��0��$��60��$
��Left=�$��Bottom=�$��40��   OpenDrawerCommand#��Z "  System.Windows.Controls.Dock   Left#��Z .��  $��Center=�$��Center=�$
 Menu=�
�������$��50��$��40���� -   $
��bell��#��[ $ 10��$ Notifikacije��$��3��$��0��$��60��$��Right=�$��Bottom=�$��40��#��Z 
   Top#��Z .��  $
 Bell=�
�������$��Center=�$��Center=�$��50��$��35���� -   $
��gear��#��[ $ 10��$ Opcije��$��4��$��0��$��60��$��Right=�$��Bottom=�$��40��#��Z    Right#��Z .��  $ DotsVertical=�
�������$��Center=�$��Center=�$��50��$��40��� $��0��$��0��$��6��$��3��$��0,0,10,0q� �� $��23 ��� $��65 ��� $��47 ��� $	��216 ��� $��66 ��� $��23 � �� $��63 ��� $��28 ��� $	��82* ��� $
��577* �.+��� $��2��$��3��$��Center=�$��Bottom=�$��
19,0,197,0q�$��16��$��0���� -    ��Name$
 Back�� , (MaterialDesignFloatingActionAccentButton#��[ $. (MaterialDesignFloatingActionAccentButton��$��2��$��1��$��60��$��60��$��0q�$��0q�$
��Left=�$��Center=�$
��0,11q�.��  $ 	ArrowLeft=�$��24��$��24���� $��2��$��3��$��2��$��Center=�$��Center=�$��Medium"�$��22(�$��15,28,14,27q�$��27��$	��300��Pregled zdravstvenog kartona� $��3��$��0��$��5�� �� $	��16* ��� $
��152* ��� $
��249* � �� $	��28* ��� $	��29* ��� $	��29* ��� $	��29* ��� $	��29* ��� $	��29* ��� $	��45* ��� $	��45* ��� $	��46* ��� $	��45* ��� $
��223* �.+��� $��0��$��1��$
��Left=�$��Center=�$��16(�$��18��$	��0,5q�$��30��Ime:�� -   $
��name��$��0��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$	��0,5q��� $��1��$��1��$
��Left=�$��Center=�$��16(�$��18��$��0,6,0,5q�$��92��Ime roditelja:�� -    $��parent��$��1��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$��0,6,0,5q��� $��2��$��1��$
��Left=�$��Center=�$��16(�$��18��$��0,5,0,6q�$��60��
Prezime:�� -!   $��lastname��$��2��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$��0,5,0,6q��� $��3��$��1��$
��Left=�$��Center=�$��16(�$��18��$��0,6,0,5q�$��44��JMBG:�� -"   $	��pin��$��3��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$��0,6,0,5q��� $��4��$��1��$
��Left=�$��Center=�$��16(�$��18��$��0,5,0,6q�$	��133��Mesto prebivalista:�� -#   $��
livingCity��$��4��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$��0,5,0,6q��� $��5��$��1��$
��Left=�$��Center=�$��16(�$��18��$��0,6,0,5q�$	��113��Datum rodjenja:�� $��5��$��2��$
��Left=�$��Center=�$��16(�$��18��$	��200��$��0,6,0,5q��� $��6��$��1��$
��Left=�$��Center=�$��16(�$��18��$��	0,13,0,14q�$��57��	Alergije:�� -$   $��showAlergies�� $  MaterialDesignRaisedAccentButton#��[ +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#DD000000$��6��$��2��$��Center=�$��Center=�$��16(�$��25��$	��150��$��Prikazi��$��50,10,49,10q��� $��7��$��1��$
��Left=�$��Center=�$��16(�$��18��$��	0,14,0,13q�$	��135��Prepisivani lekovi:�� -%   $��	showDrugs��#��[  �	#DD000000$��7��$��2��$��Center=�$��Center=�$��16(�$��24��$	��150��$��Prikazi��$��50,10,49,11q��� $��8��$��1��$
��Left=�$��Center=�$��16(�$��18��$��	0,15,0,13q�$	��135��Prethodni pregledi:�� -&   $��showExaminations��#��[  �	#DD000000$��8��$��2��$��Center=�$��Center=�$��16(�$��24��$	��150��$��Prikazi��$��50,11,49,11q��� $��9��$��1��$
��Left=�$��Center=�$��16(�$��18��$��	0,15,0,12q�$	��152��
Dijagnoze:�� -'   $��showDiagnosis��#��[  �	#DD000000$��9��$��2��$��Center=�$��Center=�$��16(�$��24��$	��150��$��Prikazi��$��50,11,49,10q�� -(   $��AlergiesPopup��$
��Left=�$	��Top=�$	��300��$	��450����.  $��Center=� � 	StaysOpen .  $��3��$��11��.���� $��Hidden=�.���� 
�������|�.  $
��Auto��.+��� $y�Hidden=��� $y�Hidden=��� -)   $��dateText��$��Center=�$��Center=�$��Medium"�$��20(�Prikaz alergija�� $y�Hidden=��� $y�Hidden=��� -*   $��itemControl�� . ���� *
alergies+���� /   )PatientProject.PatientPages.ExpandersItem"  .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��� $��8 0 0 0q�.+��� $
��Bold"�$
��Wrap=����� *Header+�� $
��Wrap=����� *	Content+� -+   $��
DrugsPopup��$
��Left=�$	��Top=�$	��300��$	��450����.  $��Center=� .  $��3��$��11��.���� $��Hidden=�.���� 
�������|�.  $
��Auto��.+��� $y�Hidden=��� $y�Hidden=��� $��Center=�$��Center=�$��Medium"�$��20(�Prikaz prepisivanih lekova�� $y�Hidden=��� $y�Hidden=��� -,   $��itemControlDrugs�� . ���� *drugs+���� "  .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��� $��8 0 0 0q�.+��� $
��Bold"�$
��Wrap=����� *Header+�� $
��Wrap=����� *	Content+� --   $��
ExamsPopup��$
��Left=�$	��Top=�$	��300��$	��450����.  $��Center=� .  $��3��$��11��.���� $��Hidden=�.���� 
�������|�.  $
��Auto��.+��� $y�Hidden=��� $y�Hidden=��� $��Center=�$��Center=�$��Medium"�$��20(�Prikaz prethodnih pregleda�� $y�Hidden=��� $y�Hidden=��� -.   $��itemControlExams�� . ���� *examinations+���� &	    PatientProject.PatientPages.Exam" 	 .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��� $��8 0 0 0q�.+��� $
��Bold"�$
��Wrap=����� *Date+�� $
��Wrap=����� *Doctor+� -/   $��DiagnosisPopup��$
��Left=�$	��Top=�$	��300��$	��450����.  $��Center=� .  $��3��$��11��.���� $��Hidden=�.���� 
�������|�.  $
��Auto��.+��� $y�Hidden=��� $y�Hidden=��� $��Center=�$��Center=�$��Medium"�$��20(�Prikaz dijagnoza�� $y�Hidden=��� $y�Hidden=��� -0   $��itemControlDiagnosis�� . ���� *	diagnosis+���� +
   %PatientProject.PatientPages.Diagnosis" 
 .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��� $��8 0 8 0q� �� Orientation$ Vertical=�.+��� $
��Bold"����� *Header+�� $y�Hidden=��� $y�Hidden=�9� $��Stretch=�$��Prikaz simptoma��
�������.���� $��4 4 4 4q�$ Vertical=�#���   .+��� $
��Left=�$��Medium"����� *
TimePeriod+�� $
��Left=�$
��Wrap=����� *	Content+