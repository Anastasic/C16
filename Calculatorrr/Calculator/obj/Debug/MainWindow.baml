   M S B A M L   `   `   `  ����  
Calculator    Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Calculator��5   	   $	��309��6   $	��279��6)    � Icon$ calc.ico��65   .��5      � .+�5   
   (� -   5         (�Name$ 
buttonsbox��5      $��56,114,67,35q�6&    (� Stretch$
 Fill=�6<   .��5      � $	��130��6   $	��196��6     � RowDefinitions 5      �� 5	      $��0* �6$   �� 5
      .+�5      �� -   5         ��Name$ 	oneButton��5      $��1��6,   $
��Left=�68   $��0,27,0,0q�6S   $	��Top=�6e   $��34��6}   $��2��6�   �� 5      -   5        $ 	offButton��5      $	��Off��6,   $
��Left=�6:   $��39,0,0,0q�6U   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 	twoButton��5      $��2��6,   $
��Left=�68   $��	39,27,0,0q�6S   $	��Top=�6f   $��34��6~   $��2��6�   �� 5      -   5        $ threeButton��5      $��3��6.   $
��Left=�6:   $��	78,27,0,0q�6U   $	��Top=�6h   $��34��6�   $��2��6�   �� 5      -   5        $ clearButton��5      $��C��6.   $
��Left=�6:   $��78,0,0,0q�6U   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 
fourButton��5      $��4��6-   $
��Left=�69   $��0,54,0,0q�6T   $	��Top=�6f   $��34��6~   $��2��6�   �� 5      -   5        $ 
fiveButton��5      $��5��6-   $
��Left=�69   $��	39,54,0,0q�6T   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -	   5        $ 	sixButton��5      $��6��6,   $
��Left=�68   $��	78,54,0,0q�6S   $	��Top=�6f   $��34��6~   $��2��6�   �� 5      -
   5        $ sevenButton��5      $��7��6.   $
��Left=�6:   $��0,81,0,0q�6U   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ eightButton��5      $��8��6.   $
��Left=�6:   $��	39,81,0,0q�6U   $	��Top=�6h   $��34��6�   $��2��6�   �� 5      -   5        $ 
nineButton��5      $��9��6-   $
��Left=�69   $��	78,81,0,0q�6T   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 
zeroButton��5      $��0��6-   $
��Left=�69   $��	0,108,0,0q�6T   $	��Top=�6g   $��73��6   $��2��6�   �� 5      -   5        $ 	subButton��5      $��-��6,   $
��Left=�68   $��
117,81,0,0q�6S   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 	addButton��5      $��+��6,   $
��Left=�68   $��
117,54,0,0q�6S   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 	divButton��5      $��/��6,   $
��Left=�68   $��
117,27,0,0q�6S   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 
multButton��5      $��*��6-   $
��Left=�69   $��	117,0,0,0q�6T   $	��Top=�6g   $��34��6   $��2��6�   �� 5      -   5        $ 
calcButton��5      $��=��6-   $
��Left=�69   $��117,108,0,0q�6T   $	��Top=�6i   $��34��6�   $��2��6�   �� 5      -   5        $ decPointButton��5      $��,��61   $
��Left=�6=   $��
78,108,0,0q�6X   $	��Top=�6l   $��34��6�   $��2��6�   �� 5      -   5        $��%��5      $
��Left=�6%   $��156,108,0,0q�6@   $	��Top=�6U   $��38��6m   $��2��6�   �� 5      -   5         ��Name$ displayTextbox��5      $
��Left=�64   $��	0,-51,0,0q�6O   $
��Wrap=�6b   $	��Top=�6v   $	��187��6�   $��20��6�   5       5!      (� 5"   
   -   5        $ buttonsbox2��5"      $��56,114,67,35q�6'   $
 Fill=�6=   .��5#      � $	��130��6   $	��196��6    .+�5$      �� -   5        $ onButton��5$      $��On��6+   $
��Left=�68   $	��Top=�6S   $��34��6k   $��20��6�   5&      5'      5)      5*      