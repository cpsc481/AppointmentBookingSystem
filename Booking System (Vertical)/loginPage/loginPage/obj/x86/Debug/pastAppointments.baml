   M S B A M L   `   `   `  ����  	loginPage     loginPage.pastAppointments   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6K   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   -   5        $��pastAppointmentBox��5   :     � Title$  Patient History��6	   $	��304��6!   $	��405��6.    � Topmost .  � 
ResizeMode$ NoResize=�6c    � WindowStartupLocation$ CenterScreen=�6y   .��5      � -   5         �Name$ viewPast��5      $��0,0,0,-1.257q�6   ���	#FFE5E5E5.+�5      �� $
��Left=�6   $��8,0,0,0q�6)   $
��Wrap=�6:   $��Appointment History��6N   $	��Top=�6i   $��16(�6�   �� 5   
   -   5         ��Name$ pastCloseButton��5      $��Close��6*   $��Right=�6:   $��0,0,26,14.333q�6V   $��Bottom=�6m   $��75��6�   6�   �� 5      -   5        $��pastPatientName��5   �   $
��Left=�6   $��8,21.28,0,0q�6)   $
��Wrap=�6>   $��<Patient's name>��6R   $	��Top=�6p   $	��148��6�   �� 5   
   -   5        $��pastSelectButton��5   c   $��Select Patient��6   $��23��6*   $
��Left=�66   $��8,42,0,0q�6Q   $	��Top=�6{   $��90��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��searchDataGrid��5   )   $��12,76,23,163q�6      Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 95 63     5      $ Timeslot��6%   $ 95 67     5      $ Doctor��6%   $	 155 65   5      �� 5   
   -   5        $��
pastApptLB��5   (   $��12,101,23,43q�6   6(   5      5      