   M S B A M L   `   `   `  ����  DigitalFishing    DigitalFishing.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $��599.468��6   $��763.298��6-   .��5      � $��0,0,3.6,0.2q�6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $��	10,10,0,0q�6D   $	��Top=�6W   $	��710��6o   .@�5      �� $��Contrats��6   .��5	      � ���	#FFE5E5E5$	��Top=�6.   $	��500��6F   .+�5
      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgContrat��5
      $
��Left=�63   $	��Top=�6N   $	��450��6f   $	��255��6s      AutoGenerateColumns . ��6�   �� 6�   �� 5      -   5         ��Name$ txtNumContrat��5      $
��Left=�65   $��23��6P   $��
346,40,0,0q�6\    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��150��6�   $��14.667(�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ lblNumContrat��5      $��Numéro de contrat��63   $
��Left=�6O   $��
346,15,0,0q�6j   $	��Top=�6~   $	��115��6�   �� 5      -   5         ��Name$ cboEtatContrat��5      $
��Left=�67   $��
540,40,0,0q�6R   $	��Top=�6f   $	��155��6~   .@�5      �� $��Contrat à récupérer��6'   ���	#FFEF42426E   �� 5      $��Paiment à faire��6'   ���	#FFD09F296A   �� 5      $��Paiement effectué��6'   ���	#FF22B3296C   5      �� 5      -   5        $ 
cboPigiste��5      $
��Left=�63   $��
540,92,0,0q�6N   $	��Top=�6b   $	��155��6z   �� 5      -   5        $ txtMontantBrutContrat��5      $
��Left=�6=   $��23��6X   $��346,147,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��150��6�   6�   �� 5      -   5        $ txtMontantNetContrat��5      $
��Left=�6<   $��23��6W   $��346,201,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $	��150��6�   �� 5      -	   5        $ cboMagazine��5      $
��Left=�64   $��540,146,0,0q�6O   $	��Top=�6d   $	��155��6|   �� 5      -
   5         ��Name$ 	chkAgessa��5      $��Déclaration AGESSA��62   $
��Left=�6O   $��540,216,0,0q�6j   $	��Top=�6   $��20��6�   $	��150��6�   �� 5      -   5        	 ��Name$	 btnModifierContrat��5      $��Modifier��69   $
��Left=�6L   $��540,298,0,0q�6g   $	��Top=�6|   $	��155��6�   6�   �� 5      -   5        $	 btnAjouterContrat��5      $��Ajouter��68   $
��Left=�6J   $��539,262,0,0q�6e   $	��Top=�6z   $	��155��6�   6�   �� 5      -   5        $	 btnSupprimerContrat��5      $��	Supprimer��6:   $
��Left=�6N   $��539,332,0,0q�6i   $	��Top=�6~   $	��155��6�   $��20��6�   6�   �� 5      -   5        $ lblMontantBrutContrat��5      $��Montant Brut��6;   $
��Left=�6R   $��346,121,0,0q�6m   $	��Top=�6�   $	��115��6�   �� 5      -   5        $ lblMontantNetContrat��5      $��Montant Net��6:   $
��Left=�6P   $��346,175,0,0q�6k   $	��Top=�6�   $	��115��6�   �� 5      -   5        $ lblEtatContrat��5      $��Etat du contrat��64   $
��Left=�6N   $��
540,15,0,0q�6i   $	��Top=�6}   $	��115��6�   �� 5      -   5        $ lblPigisteContrat��5      $��Pigiste��67   $
��Left=�6I   $��
540,66,0,0q�6d   $	��Top=�6x   $	��115��6�   �� 5      -   5        $ lblMagazineContrat��5      $��Magazine��68   $
��Left=�6K   $��540,120,0,0q�6f   $	��Top=�6{   $	��115��6�   �� 5      -   5        $ 
chkFacture��5      $��Facture��63   $
��Left=�6E   $��540,191,0,0q�6`   $	��Top=�6u   $��20��6�   $	��155��6�   �� 5       -   5        $ cboFiltreMagazine��5       $
��Left=�6:   $��
10,455,0,0q�6U   $	��Top=�6i   $	��120��6�   
 J� RenderTransformOrigin$
 -0.218,0.313&�6�   �� 5!      -   5        $ cboFiltrePigiste��5!      $
��Left=�69   $��135,455,0,0q�6T   $	��Top=�6i   $	��120��6�   �� 5"      -   5        $ txtLettreAccordContrat��5"      $
��Left=�6>   $��23��6Y   $��
346,92,0,0q�6e   $
 Wrap=�6y   $	��Top=�6�   $	��150��6�   �� 5#      -   5        $  lblMontantBrutContrat_Copy��5#      $��Référence Lettre Accord��6@   $
��Left=�6b   $��
346,66,0,0q�6}   $	��Top=�6�   $	��150��6�   (  "System.Windows.Controls.DatePicker  5$      -   5          Name$ 
dtpPaiment��5$   !   $
��Left=�65   $��346,260,0,0q�6P   $	��Top=�6e   $	��150��6}   �� 5%      -   5        $ lblDatePaiement1��5%      $��Date Paiement��66   $
��Left=�6N   $��346,229,0,0q�6i   $	��Top=�6~   $
 -0.053,0.192&�6�   $	��150��6�   5'      5(      �� 5)      $��Magazine��6   .��5*      � ���	#FFE5E5E5$	��Top=�6.   $	��500��6F   .+�5+        -   5        $ dtgMagazine��5+      $
��Left=�64   $	��Top=�6O   $	��450��6g   $	��255��6t    . ��6�   �� 6�   �� 5,      -   5        $ txtNumMagazine��5,      $
��Left=�66   $��23��6Q   $��
346,40,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��150��6�   $��14.667(�6�   $
��Bold"�6�   {�.  6�   �� 5-      -   5        $ lblNumMagazine��5-      $��Numéro de magazine��64   $
��Left=�6Q   $��
346,15,0,0q�6l   $	��Top=�6�   $	��150��6�     5.      -   5        $ dtpBouclageMagazine��5.   !   $
��Left=�6>   $��
524,39,0,0q�6Y   $	��Top=�6m     5/      -   5        $ dtpParutionMagazine��5/   !   $
��Left=�6>   $��524,107,0,0q�6Y   $	��Top=�6n   �� 50      -   5        $ lblBouclageMagazine��50      $��Date de bouclage��69   $
��Left=�6T   $��
524,13,0,0q�6o   $	��Top=�6�   $	��150��6�   �� 51      -    5        $ lblParutionMagazine��51      $��Date de parution��69   $
��Left=�6T   $��
524,81,0,0q�6o   $	��Top=�6�   $	��150��6�   �� 52      -!   5        $ txtBudgetMagazine��52      $
��Left=�69   $��23��6T   $��346,108,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��150��6�   �� 53      -"   5        $ lblBudgetMagazine��53      $��Budget��67   $
��Left=�6H   $��
346,81,0,0q�6c   $	��Top=�6w   $	��150��6�   �� 54      -#   5        $	 btnModifierMagazine��54      $��Modifier��6:   $
��Left=�6M   $��540,296,0,0q�6h   $	��Top=�6}   $	��155��6�   6�   �� 55      -$   5        $	 btnAjouterMagazine��55      $��Ajouter��69   $
��Left=�6K   $��540,272,0,0q�6f   $	��Top=�6{   $	��155��6�   6�   �� 56      -%   5        $	 btnSupprimerMagazine��56      $��	Supprimer��6;   $
��Left=�6O   $��540,321,0,0q�6j   $	��Top=�6   $	��155��6�   $��20��6�   6�     57      -&   5        $ dtpPaiementMagazine��57   !   $
��Left=�6>   $��524,175,0,0q�6Y   $	��Top=�6n   �� 58      -'   5        $ lblDatePaiement��58      $��Date de paiement��65   $
��Left=�6P   $��524,144,0,0q�6k   $	��Top=�6�   $
 -0.132,-0.058&�6�   $	��108��6�   5:      5;      �� 5<      $��Pigiste��6   .��5=      � ���	#FFE5E5E5$	��Top=�6.   $	��500��6F   $
 0.503,0.506&�6S   .+�5>        -(   5        $ 
dtgPigiste��5>      $
��Left=�63   $	��Top=�6N   $	��450��6f   $	��255��6s    . ��6�   �� 6�   �� 5?      -)   5        $ txtNumPigiste��5?      $
��Left=�65   $��23��6P   $��
346,40,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��150��6�   $��14.667(�6�   $
��Bold"�6�   {�.  6�   �� 5@      -*   5        $ labelNumPigiste��5@      $��Numéro de pigiste��65   $
��Left=�6Q   $��
346,15,0,0q�6l   $	��Top=�6�   $	��150��6�   �� 5A      -+   5        $ txtNomPigiste��5A      $
��Left=�65   $��23��6P   $��
346,91,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��150��6�   �� 5B      -,   5        $ txtPrenomPigiste��5B      $
��Left=�68   $��23��6S   $��346,145,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��150��6�   �� 5C      --   5        $ lblNomPigiste��5C      $	��Nom��63   $
��Left=�6A   $��
346,65,0,0q�6\   $	��Top=�6p   $	��150��6�   �� 5D      -.   5        $ lblPrenomPigiste��5D      $��Prénom��66   $
��Left=�6G   $��346,119,0,0q�6b   $	��Top=�6w   $	��150��6�   �� 5E      -/   5        $ lblNumPigiste��5E      $��Numéro de pigiste��63   $
��Left=�6O   $��
346,15,0,0q�6j   $	��Top=�6~   $	��150��6�   �� 5F      -0   5        $ txtCPPigiste��5F      $
��Left=�64   $��23��6O   $��
544,91,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��150��6�   �� 5G      -1   5        $ txtVillePigiste��5G      $
��Left=�67   $��23��6R   $��544,145,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��150��6�   �� 5H      -2   5        $ lblCPPigiste��5H      $��Code Postal��62   $
��Left=�6H   $��
545,65,0,0q�6c   $	��Top=�6w   $	��150��6�   �� 5I      -3   5        $ lblVillePigiste��5I      $��Ville��65   $
��Left=�6E   $��545,119,0,0q�6`   $	��Top=�6u   $	��150��6�   �� 5J      -4   5        $ txtAdressePigiste��5J      $
��Left=�69   $��23��6T   $��
544,40,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��150��6�   �� 5K      -5   5        $ lblAdressePigiste��5K      $��Adresse��67   $
��Left=�6I   $��
545,15,0,0q�6d   $	��Top=�6x   $	��150��6�   �� 5L      -6   5        $	 btnModifierPigiste��5L      $��Modifier��69   $
��Left=�6L   $��539,319,0,0q�6g   $	��Top=�6|   $	��155��6�   6�   �� 5M      -7   5        $	 btnAjouterPigiste��5M      $��Ajouter��68   $
��Left=�6J   $��540,294,0,0q�6e   $	��Top=�6z   $	��155��6�   6�   �� 5N      -8   5        $	 btnSupprimerPigiste��5N      $��	Supprimer��6:   $
��Left=�6N   $��540,344,0,0q�6i   $	��Top=�6~   $	��155��6�   $��20��6�   6�   �� 5O      -9   5        $ txtNumSecuPigiste��5O      $
��Left=�69   $��23��6T   $��346,217,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��150��6�   �� 5P      -:   5        $ lblSecuPigiste��5P      $��Sécurité Sociale��64   $
��Left=�6O   $��346,191,0,0q�6j   $	��Top=�6   $	��150��6�   �� 5Q      -;   5        $ txtEmail��5Q      $
��Left=�60   $��23��6K   $��545,217,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��149��6�   �� 5R      -<   5        $ txtContratCadre��5R      $
��Left=�67   $��23��6R   $��346,291,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��150��6�   �� 5S      -=   5        $ lblContratCadre��5S      $��Contrat Cadre Pigiste��65   $
��Left=�6U   $��346,265,0,0q�6p   $	��Top=�6�   $	��122��6�   �� 5T      ->   5        $ lblMail��5T      $��Email��6-   $
��Left=�6=   $��545,191,0,0q�6X   $	��Top=�6m   $��78��6�   5U      5V      5W      5Y      5Z      