   M S B A M L   `   `   `  ����P  LGemo test application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Gemo_test_applicationGemo_test_application  5   	   +    %Gemo_test_application.StudySealWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Gemo_test_application     5   	     � Title$  StudySealWindow��5   	   $	��450��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:   .��5	      �� -   5         ��Name$ canvasStudyForSeal��5	      .+�5
   
   �� $��10 0 0 0q�6   .+�5      �� $>��8Лабораторная служба "Гемотест"��6   $��20(�6H   $
��Bold"�6V   6j   �� 5      $��тел: 8-800-555-55-55��6   $��20(�64   $
��Bold"�6B   $��0 5 0 0q�6T   6g   �� 5      $;��5Информация в интернете: www.HT.ru��6   $��20(�6A   $
��Bold"�6O   $��0 5 0 0q�6a   6t   5      �� 5   
   $��0 1 0 0q�6   
���   �$��5��6?   $	��772��6J    �� Left$ 10��6V   
 �� Top$ 96��6g   6y   �� 5   
   
���   �$��1q�6%    �� CornerRadius$ 3��69   $ 10��6J   $	 106��6[   ._�5      �� -   5        $��txtOrderNumber��5      $��ЗАКАЗ №: ��6.   6A   5      �� 5   
   
���   �$��1q�6%   $ 3��69   $ 10��6J   $	 129��6[   ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��ПАЦИЕНТ: ��6   6/   �� 5      $��10 0 0 0q�6   .+�5      �� -   5        $��txtSecondName��5       $��Фамилия: ��65   6H   �� 5      -   5        $��txtName��5       $��Имя: ��6/   6>   �� 5      -   5        $��txtMiddleName��5       $��Отчество: ��65   6I   �� 5      -   5        $��	txtGender��5       $��Пол: ��61   6@   5      5      5      �� 5   
   $��0 1 0 0q�6   
���   �$��5��6?   $	��772��6J   $ 10��6V   $	 222��6g   6z   &   System.Windows.Controls.DataGrid  5   
   -   5        $��datagridSum��5         AutoGenerateColumns .     
IsReadOnly . $ 10��6T   $	 232��6e   $	��772��6v   $	��142��6�   	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 600 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Analyzes.Name+6g     5"      $
 Цена��6%   $	 200 63    6?   �� *Price+6[   5$      �� 5%   
   $ 10��6   $	 374��6"   $��1q�63   
�������$	��772��6Z   ._�5&      �� -   5        $��	txtAllSum��5&      $��20(�6)   $��
519,0,-1,0q�67   Итого:6S   5'      5(      5)      