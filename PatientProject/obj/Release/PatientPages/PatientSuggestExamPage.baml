   M S B A M L   `   `   `  ���� I  EPatientProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PatientProject.PatientPagesPatientProject.PatientPages  8    2PatientProject.PatientPages.PatientSuggestExamPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:PatientProject.PatientPages     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  PatientSuggestExamPage��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
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
��Wrap=����� *	Content+.��� $	��430��$	��750��.+�� $��Center=�$��Center=�$	��750��$	��430�� �� $��23 ��� $��66 ��� $	��175 ��� $��87 ��� $��66 ��� $��23 � �� $��63 ��� $��28 ��� $	��91* ��� $
��568* �.+��� ���#536878$
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
�������$��Center=�$��Center=�$��50��$��40���� -    ��Name$
 Back�� , (MaterialDesignFloatingActionAccentButton#��[ $. (MaterialDesignFloatingActionAccentButton��$��2��$��1��$��60��$��60��$��0q�$��0q�$
��Left=�$��Center=�.��  $ 	ArrowLeft=�$��24��$��24���� $��2��$��2��$��2��$��Center=�$��Center=�$��Medium"�$��24(�$��28��$	��229��Zakazivanje pregleda� $��3��$��0��$��6�� �� $	��23* ��� $	��146 ��� $
��261* � �� $��50 ��� $	��120 ��� $	��120 ��� $	��120 ��� $	��166 �.+��� $��1��$��1��$��Medium"�$��Center=�$��Center=�$��26��$��14(�Odaberite lekara:��  �� Orientation$ Vertical=�$��1��$��2��$��Center=�.+��� -   $��doctorCB��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Izaberite lekara��$��1��$��2��$	��220��$��Center=����� $ doctors��� -     ��Name$ errorNoInputDoctor��$��24��$��Center=�$��center=� J� OpacityMask
 �<��$	��220�����	#FFE5572C$��1���� $��2��$��1��$��Medium"�$��Center=�$��Center=�$
��Wrap=�'%Odaberite pocetak vremenskog perioda:�� $ Vertical=�$��2��$��2��$��Center=�.+�(  "System.Windows.Controls.DatePicker  -!   $��	startDate��$	��220��$ Odaberite pocetak perioda�� ( $MaterialDesignFloatingHintDatePicker#��[ $��Center=��� -"   $ errorNoInputStart��$��24��$��Center=�$��center=�
 �<��$	��220�����	#FFE5572C$��1���� $��3��$��1��$��Medium"�$��Center=�$��Center=�$
��Wrap=�$"Odaberite kraj vremenskog perioda:�� $ Vertical=�$��3��$��2��$��Center=�.+�  -#   $��endDate��$��3��$��2��$	��220��$ Odaberite kraj perioda��#��[ $��Center=��� -$   $ errorNoInputEnd��$��24��$��Center=�$��center=�
 �<��$	��220�����	#FFE5572C$��1��� -%   $��unsuccssfullPopup1��$
��Left=�$	��Top=�$	��300��$	��450����.  $��Center=� � 	StaysOpen .  .��� 
�������|�.   �� $	��76* ��� $	��76* ��� $	��74* ��� $	��75* � �� $	��43* ��� $
��118* ��� $
��289* �.+��� -&   $��unsuccessfullNum1��$��1��$��0��$��4��$��Center=�$��Center=�$	��250��$��98��$
��Wrap=�$��26,10,24.623,10q��� $��2��$��1��$��3��$��0,0,74.623,0q�.+��� $
��Bold"�$
��Wrap=�,*Molim Vas, odaberite prioritet za pregled!�� $y�Hidden=��� $y�Hidden=��� $y�Hidden=��� $y�Hidden=�	� -'   $��radioDoctor��.��Lekar	� -(   $��radioTimePeriod��.��Vremenski period�� $y�Hidden=��� $y�Hidden=��� $y�Hidden=��� $y�Hidden=��� -)   $��suggestExamPriority�� $  MaterialDesignRaisedAccentButton#��[ $	��100��$ Preporuci mi pregled��+	  %MaterialDesignThemes.Wpf.RippleAssist 	  Feedback �	#DD000000.��
Preporuci!�� $y�Hidden=��� $y�Hidden=��� -*   $ errorNoRadioButton��$
��Wrap=�$��50��$��Center=�$��center=�
 �<��$	��150�����	#FFE5572C� -+   $��unsuccssfullPopup2��$
��Left=�$	��Top=�$	��300��$	��160����.  $��Center=� .  .��� 
�������|�.   �� $	��76* ��� $	��76* ��� $	��74* ��� $	��75* � �� $
��118* �.+��� -,   $��unsuccessfullNum2��$��0��$��0��$��4��$��Center=�$��Center=�$	��250��$��98��$
��Wrap=�$��Medium"�� --   $��unsuccssfullPopup3��$
��Left=�$	��Top=�$	��300��$	��160����.  $��Center=� .  .��� 
�������|�.   �� $	��76* ��� $	��76* ��� $	��74* ��� $	��75* � �� $
��118* �.+��� -.   $��unsuccessfullNum3��$��0��$��0��$��4��$��Center=�$��Center=�$	��250��$��98��$
��Wrap=�$��Medium"�� -/   $��successPopup��$
��Left=�$	��Top=�$	��300��$	��220����.  $��Center=� .  .��� 
�������|�.   �� $	��76* ��� $	��76* ��� $	��74* ��� $	��75* � �� $��43 ��� $	��117 ��� .+��� -0    & "MaterialDesignIconForegroundButton#��[ $��0��$��0��$��Center=�$��Center=�$��35��$��	13,4,14,4q�.��  $ 	ArrowLeft=��� -1   $��itemControl��$��1��$��0��$��4�� . $��2������ ���� /
   )PatientProject.PatientPages.ScheduledExam" 
 .R��� $ Border��$ 8q�$��0 0 0 1q�#���  ._��  ��  z� SharedSizeGroup$ Checkerz���� .+��� $��8 0 0 0q�$��1��.+��� ���� *Doctor+�� ���� *Time+�� ���� *Room+�� -2   $��scheduleExam��$��2��$��1��$��2��$	��140��#��[ $ Potvrdi pregled!�� �	#DD000000.��Zakazi pregled!�� $ Vertical=�$��4��$��0��$��3��.+��� -3   $ errorDateWrong��$��50��$
��Wrap=�$��Center=�$��center=�
 �<��$	��220�����	#FFE5572C�� $y�Hidden=��� $y�Hidden=��� $y�Hidden=��� -4   $��suggestExam��#��[ $	��150��$ Preporuci mi pregled�� �	#DD000000.��Preporuci pregled