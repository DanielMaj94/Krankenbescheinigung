   M S B A M L   `   `   `  ����  Krankenmeldung    Krankenmeldung.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��wMainWindow��5   5     � WindowState$  	Maximized=�5   	    � Title$ 
MainWindow��5   	   $	��350��6   $	��719��6)   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5	      $
��145* �6    �� 5
      $
��178* �6     � ColumnDefinitions 5      �� 5      $��0* �6#   �� 5      .+�5      �� -   5         ��Name$ lstData��5      {�. 
�������$��
2,58,10,66q�6~   $��2��6�   $��18(�6�   $��1��6�   ��6(   ��  �� Path$ AlleKrankenSchueler� �� View 5      �� 5      .P�5      �� $��ID��6)    �� Width$
 Auto��65    �� DisplayMemberBinding 6B   �� $ Schueler.Id��� 5      $
��Name��6)   $
 Auto��67    6D   �� $ Schueler.Name��� 5      $��Vorname��6)   $
 Auto��6:    6G   �� $ Schueler.Vorname��� 5      $��Klasse��6)   $
 Auto��69    6F   �� $ Schueler.Klasse��� 5      $��Datum��6)   $
 Auto��68    6E   �� $ Datum��� 5      $��Uhrzeit von��6)   $
 Auto��6>    6K   �� $ Uhrzeit��� 5      $��Uhrzeit Bis��6)   $
 Auto��6>    6K   �� $ 
UhrzeitBis��� 5      $��Status��6)   $
 Auto��69    6F   �� $ Status�5      5      �� 5      -   5        $��Benutzer krankmelden��5      $
��Left=�64   $��2,0,0,10q�6O   $	��191��6a   	 J� RenderTransformOrigin$	 	0.04,0.05&�6m   $��1��6�   $��39��6�   $��Bottom=�6�   $��16(�6�   $��1��6�   �� 5       -   5        $��btnAkt��5       $��Aktuallisieren��6#   $��
211,0,0,10q�6<   $	 	0.04,0.05&�6P   $��1��6�   $��1��6�   $��39��6�   $��Bottom=�6�   $��16(�6�   $
��Left=�6�   $	��128��6�   �� 5!      -   5        $��cbKlasse��5!      $
��Left=�6'   $��2,10,0,0q�6B   $	��Top=�6T   $	��154��6l   $��33��6�   $��16(�6�   $��1��6�   �� 5"      -   5        $��btnDokument��5"      $��Dokument��6(   $��1��6;   $��
356,0,0,10q�6K   $��1��6y   $��39��6�   $��Bottom=�6�   $��16(�6�   $
��Left=�6�   $	��128��6�   (  "System.Windows.Controls.DatePicker  5#      -   5        $��DPDatum��5#      $��2��6(   $
��Left=�6<   $��
183,10,0,0q�6W   $	��Top=�6k   $��33��6�   $	��182��6�   $��16(�6�   �� 5$      -   5        
 ��Name$
 btnEinstellungen��5$      $��Einstellungen��6/   $��1��6G   $��	0,0,10,10q�6W   $��1��6�   $��39��6�   $��Bottom=�6�   $��16(�6�   $��Right=�6�   $	��128��6�   {�.  6�   5%      5'      5(      