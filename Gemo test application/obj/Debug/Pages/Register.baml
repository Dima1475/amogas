   M S B A M L   `   `   `  ����P  LGemo test application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Gemo_test_applicationGemo_test_application  5      $    Gemo_test_application.Register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Gemo_test_application     5        N� 
Background
  ����� N� Title$ Register��5	      .��5      � .+�5   
   �� $��1��6   $��10 0 0 0q�6"   .+�5      �� -   5        $��txtStudyName��5      $��20(�6,   $��0 15 0 0q�6:   
��� � �6a   �� 5       �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� $%��Номер документа: ��6   $��15(�65   
��� � �6X   �� 5      -   5        $��txtDocumentNumber��5      $��15(�63   $��10 0 0 0q�6A   $	��200��6S   
��� � �6t   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� $%��Дата проведения: ��6   $��15(�65   
��� � �6X   (  "System.Windows.Controls.DatePicker  5      -   5        $��datepickerDate��5      $��15 0 0 0q�63   $	��200��6E   
��� � �6f   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� $��Пациент: ��6   $��15(�6-   
��� � �6P   �� 5      -   5        $��comboboxPacient��5      $��75 0 0 0q�62   $	��200��6D   
��� � �6e   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� $"��Ответственный: ��6   $��15(�63   
��� � �6V   �� 5      -   5        $��comboboxDoctor��5      $��30 0 0 0q�61   $	��200��6C   
��� � �6d   5      � 5      $��0 10 0 0q�6    � ColumnDefinitions 5      �� 5       $��* �6'   63   �� 5!      $��* �6'   63   .+�5#      �� $��0��6   .+�5$      �� $��Анализы��6    $��20(�6/   
��� � �6R   &   System.Windows.Controls.DataGrid  5%      -   5        $��gridAnalyzes��5%         AutoGenerateColumns .     Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 6e      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   �� *Analyzes.Name+
   ElementStyle
 5(   "   �� 5)   &    �� 
TargetType" ��6,   .�5*   *   ��  �� Property � �� �� Value$
 Wrap=�6I   6X   5+   '   5-      4  .System.Windows.Controls.DataGridCheckBoxColumn  5.      $ Согласие��65    .  	 6G   �� *Needed+6w   50      51      �� 52      $��1��6   .+�53      �� $��Услуги��6    $��20(�6.   
��� � �6Q     54      -   5        $��gridServices��54       .     ColumnWidth$ * 6O      
IsReadOnly .  55        56      $ Название��61   	 6C   �� *Services.Name+
 57   "   �� 58   &   " ��6,   .�59   *   ��  � ��$
 Wrap=�6I   6X   5:   '   5<      5>      5?      5@      �� 5A      -   5        $��btnRefeshPrice��5A      $!��Обновить сумму��6+   $��15(�6D   
��� � �$��0q�6e   
������ $��Right=�6�   $
��10 0q�6�   $��	0 10 10 0q�6�   6�   �� 5B      -	   5        $��txtServicesPrice��5B      $��15(�60   $��Right=�6>   
��� � �$��	0 10 10 0q�6m   +)Итого стоимость услуг:6�   �� 5C      -
   5        $��txtAnalyzesPrice��5C      $��15(�60   $��Right=�6>   
��� � �$��	0 10 10 0q�6m   1/Итого стоимость анализов:6�   �� 5D      -   5        $��txtEndPrice��5D      $��15(�6+   $��Right=�69   
��� � �$��	0 10 10 0q�6h   ИТОГО:6�   5E      5F      5G      