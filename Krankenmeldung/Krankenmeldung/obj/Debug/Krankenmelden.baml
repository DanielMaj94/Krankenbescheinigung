   M S B A M L   `   `   `  ����  Krankenmeldung"    Krankenmeldung.Krankenmelden   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Krankenmelden��5   	   $	��421��6   $	��385��6,   .��5      � $��0,0,2,4q�6    � ColumnDefinitions 5   
   �� 5      $
��130* �6   �� 5      $
��234* �6   �� 5	      $	��11* �6   .+�5   
   �� -   5        $��cbKlasse��5      $��	3,0,0,339q�6#   $��29��6�   $��Bottom=�6�   $��16(�6�   $��1��6�    � ToolTip$, &Hier können sie die Klasse auswählen��6�    � Cursor$
 Hand��6   ��66   ��  �� Path$ AlleKlassen�6   �� 5   
   -   5         ��Name$ 
cbSchueler��5      $��	3,0,0,295q�6'   $��29��6�   $��Bottom=�6�   $��16(�6�   $��1��6�   $; 5Hier können sie einen Schüler der Klasse auswählen��6�   $
 Hand��6  ��6:   �� $ listeSchueler�6  (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	DateDatum��5      $��	2,0,0,246q�6&   $��28��69   $��Bottom=�6E   $��16(�6`   $��1��6n   $ Wählen Sie das Datum aus��6~   $
 Hand��6�   {�.  6�   �� 5   
   $��Klasse:��6   $
��Left=�6"   $��	18,22,0,0q�6=   $	��Top=�6P   $��16(�6h   $��29��6v   $��60��6�   �� 5   
   $��	Schüler:��6   $
��Left=�6#   $��	18,66,0,0q�6>   $	��Top=�6Q   $��16(�6i   $��29��6w   $��68��6�   �� 5   
   $��Datum:��6   $
��Left=�6!   $��
19,115,0,0q�6<   $	��Top=�6P   $��16(�6h   $��29��6v   $��63��6�   �� 5   
   -   5        $��tbuhrzeitVon��5      $��	2,0,0,199q�6'    �� TextWrapping$
 Wrap=�6:   $��08:00��6N   $��29��6[   $��Bottom=�6g   $��16(�6�   $��1��6�   $? 9Geben sie Hier ein, ab welcher Uhrzeit der Schüler fehlt��6�   {�.  6�   �� 5   
   -   5        $��tbuhrzeitBis��5      $��	1,0,0,152q�6&   $
 Wrap=�69   $��16:00��6M   $��29��6Z   $��Bottom=�6f   $��16(�6�   $��1��6�   $< 6Geben sie hier ein, wie lange der Schüler fehlen wird��6�   {�.  6�   �� 5   
   $��Uhrzeit Bis:��6   $
��Left=�6'   $��
19,209,0,0q�6B   $	��Top=�6V   $��16(�6n   $��29��6|   $��91��6�   �� 5   
   $��Uhrzeit Von:��6   $
��Left=�6'   $��
19,162,0,0q�6B   $	��Top=�6V   $��16(�6n   $��29��6|   $��98��6�   �� 5   
   -   5        $��btnKrankmelden��5   '   $��Krankmelden��6   $
��Left=�6=   $��
19,343,0,0q�6X   $	��Top=�6l   $	��106��6�   $��16(�6�   $��26��6�   $/ )Hier können Sie den Schüler Krankmelden��6�   $
 Hand��6�   {�.  6  �� 5   
   -   5        $ cbStatus��5      $��	1,0,0,107q�6%   $��29��6[   $��Bottom=�6g   $��16(�6�   $��1��6�   $# Geben sie hier den Status ein��6�   $
 Hand��6�   {�.  ��68   �� *
AlleStatus+6�   �� 5   
   $��Status:��6   $
��Left=�6"   $��
18,254,0,0q�6=   $	��Top=�6Q   $��16(�6i   $��29��6w   $��60��6�   �� 5   
   -   5        $��btnSchülerinfo��5      $��Schülerinfo��6'   $��0,0,0,21q�6=   $��26��6l   $��Bottom=�6x   $��16(�6�   $��1��6�   $N HHier können sie die Informationen des Schülers ausgeben und bearbeiten��6�   $
 Help��6  {�.  6  �� 5   
   $��	Dokument:��6   $
��Left=�6$   $��
19,296,0,0q�6?   $	��Top=�6S   $��16(�6k   $��29��6y   $��88��6�   �� 5   
   -	   5        $��btnHochladen��5      $��	Hochladen��6%   $��0,0,0,65q�69   {�.  $��27��6x   $��Bottom=�6�   $��16(�6�   $��1��6�   $- 'Hier können sie ein Dokument hochladen��6�   5      5      