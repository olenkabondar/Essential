   M S B A M L   `   `   `  ����@  <4Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_4Task_4Task  5   	       _4Task.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:_4Task     5   	     � Title$   Калькулятор MVP��5   	   $	��300��6!   $	��500��6.   .��5	      � $��10,10,10,10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ FirstNumberBox��5      $��1��6*   $��0��67   $��5q�6G   �� 5   
   -   5        $ SecondNumberBox��5      $��1��6+   $��1��68   $��5q�6H   �� 5   
   -   5         ��Name$ 	AddButton��5      $��+��6$   $��2��60   $��0��6=   $��5q�6M   �� 5   
   -   5        $ SubtractButton��5      $	��−��6)   $��2��65   $��1��6B   $��5q�6R   �� 5   
   -   5        $ MultiplyButton��5      $��×��6)   $��3��65   $��0��6B   $��5q�6R   �� 5   
   -   5        $ DivideButton��5      $��÷��6'   $��3��63   $��1��6@   $��5q�6P   �� 5   
   -   5         ��Name$ 
ResultText��5      $��4��6(   $��2��65   $��5q�6I   $��16(�6T    �� TextAlignment$ Center=�6b   �� 5   
   $��0��6   $��0��6   $+��%Введіть перше число:��6-   $
��Left=�6L   $��5q�6g   $��Center=�6r   �� 5   
   $��0��6   $��1��6   $+��%Введіть друге число:��6-   $
��Left=�6L   $��5q�6g   $��Center=�6r   5       5!      