   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  Pokemon��5   	   $	��350��6   $	��525��6&    � WindowStartupLocation$ CenterScreen=�62   .��5	      � .+�5
   
   �� -   5         ��Name$ listView��5
      $
��Left=�6%   $	��299��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��271��6x    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��Pokemon Name��6%   $	 100��6;    6G   �� *pokemon_name+�� 5      $��Pokemon Level��6%   $	 120��6<    6H   �� *pokemon_lvl+5      5      �� 5   
   -   5         ��Name$ label��5      $��ID��6   $
��Left=�6,   $��27��6G   $��
286,32,0,0q�6S   $	��Top=�6g   $��54��6   �� 5   
   -   5        $ label1��5      $��Pokemon Name��6    $
��Left=�67   $��30��6R   $��
286,76,0,0q�6^   $	��Top=�6r   $��93��6�   �� 5   
   -   5        $ label2��5      $��Pokemon Level��6    $
��Left=�68   $��30��6S   $��286,131,0,0q�6_   $	��Top=�6t   $��93��6�   �� 5   
   -   5         ��Name$ txtid��5      $
��Left=�6!   $��27��6<   $��
384,32,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��123��6�   �� 5   
   -   5        $ txtpokemonname��5      $
��Left=�6*   $��30��6E   $��
384,76,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��123��6�   �� 5   
   -   5        $ txtpokemonlevel��5      $
��Left=�6+   $��30��6F   $��384,131,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��123��6�   �� 5   
   -   5        	 ��Name$	 button��5      $	��Add��6!   $
��Left=�6/   $��27��6J   $��392,190,0,0q�6V   $	��Top=�6k   $��76��6�   6�   �� 5   
   -	   5        $	 btnEdit��5      $
��Edit��6"   $
��Left=�61   $��27��6L   $��392,258,0,0q�6X   $	��Top=�6m   $��76��6�   6�   �� 5   
   -
   5        $	 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��31��6P   $��392,222,0,0q�6\   $	��Top=�6q   $��76��6�   6�   5      5      