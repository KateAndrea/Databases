   M S B A M L   `   `   `  ����B  >BD_labs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BD_labsBD_labs  5   	       BD_labs.StartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BD_labs     5   	   -   5          � Title$E  ?АРМ секретаря приймальної комісії��5   	   $	��600��63   $	��850��6@    � WindowStartupLocation$ CenterScreen=�6L    � 
ResizeMode$ CanMinimize=�6q   $��Century Schoolbook)�6�   .��5	      � $
��Left=�6   $	��842��6&    � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   �� ���	#FFC8D7DA$��50,54q�6(   $��2��67   �� 5   
   $��1.jpg��6   $
��Fill=�6   $��186,107q�6.   $��2��6?    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5      5      �� 5   
   -   5        $��Увійти��5      $��Century Schoolbook)�6"   $��24(�6B   $��24,392,244,131q�6P   &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6h   $��Black"�6�   $��1��6�   �� 5   
   -   5         ��Name$ logText��5       �� TextWrapping$
 Wrap=�6#   $��
Nirmala UI)�67   $��18(�6O   $��317,184,317,349q�6]   $��2��6v   �� 5   
   $��Пароль��6   $��37��6!   $��374,253,374,0q�6-   $��Century Schoolbook)�6D   $��20(�6d   $ Fixed=�6r   $
��Bold"�6�   $	��Top=�6�   $��2��6�   �� 5   
   $��Користувач��6   $��37��6%   $��351,142,351,0q�61   $��Century Schoolbook)�6H   $��20(�6h   $ Fixed=�6v   $	��Top=�6�   $��2��6�   $
��Bold"�6�   G� 5   
   -   5         G�Name$ passBox��5      $
��Left=�6'   $��35��6B   $��317,290,0,0q�6N   $	��Top=�6c   $	��208��6{   $��18(�6�   	 G� PasswordChar$		 •��6�   $��
Nirmala UI)�6�   $��2��6�   �� 5   
   -   5        
 ��Name$
 	checkBox1��5      $)��#відобразити пароль��6&   $
��Left=�6C   $��16��6^   $��346,330,0,0q�6j   $	��Top=�6   $	��145��6�   $��Century Schoolbook)�6�    d� 	IsChecked$ FalseY�6�   $��2��5   ?   �� 5   
   -   5        $ passText��5      $
��Left=�6$   $��35��6?   $
 Wrap=�6K   $	��Top=�6_   $	��208��6w   $��317,290,0,0q�6�   $��
Nirmala UI)�6�   $��18(�6�   $y�	Collapsed=�6�   $��2��6�   �� 5   
   -   5         ��Name$
 exit��5      $��
Вихід��6   $��244,392,24,131q�6/   $��Century Schoolbook)�6G   $��24(�6g   $
��Bold"�6u   6�   5      5       